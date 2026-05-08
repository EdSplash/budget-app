using BudgetAppV2.Data;
using BudgetAppV2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetAppV2
{
     public partial class MainMenuForm : Form
     {
          public MainMenuForm()
          {
               InitializeComponent();
          }

          private void btnCategoryBudgets_Click(object sender, EventArgs e)
          {
               CategoryBudgetsForm form = new CategoryBudgetsForm();
               form.ShowDialog();

               //LoadPeriodBudgets();
               LoadDashboardData();
          }

          private void btnCategories_Click(object sender, EventArgs e)
          {
               CategoriesForm form = new CategoriesForm();
               form.ShowDialog();

               //LoadPeriodBudgets();
               LoadDashboardData();
          }

          private void btnTransactions_Click(object sender, EventArgs e)
          {
               TransactionsForm form = new TransactionsForm();
               form.ShowDialog();

               LoadPeriodBudgets();
               LoadDashboardData();
          }

          private void btnPeriodBudgets_Click(object sender, EventArgs e)
          {
               PeriodBudgetsForm form = new PeriodBudgetsForm();
               form.ShowDialog();

               //LoadPeriodBudgets();
               LoadDashboardData();
          }

          private void MainMenuForm_Load(object sender, EventArgs e)
          {
               LoadPeriodBudgets();
               LoadDashboardData();
          }

          private void LoadPeriodBudgets()
          {
               using (var context = new BudgetAppContext())
               {
                    var periodBudgets = context.PeriodBudgets
                         .OrderByDescending(pb => pb.PeriodStartDate)
                         .ToList();

                    cboPeriod.DataSource = periodBudgets;  // Where does cbo get data from 

                    DateTime today = DateTime.Today;

                    // Finds the current Period
                    var currentPeriod = periodBudgets
                         .FirstOrDefault(pb =>
                         pb.PeriodStartDate <= today &&
                         pb.PeriodEndDate >= today);

                    // Finds the latest Period
                    if (currentPeriod != null)
                    {
                         cboPeriod.SelectedItem = currentPeriod;
                    }
                    else if (periodBudgets.Count > 0)
                    {
                         cboPeriod.SelectedItem = periodBudgets.Last();
                    }

                    
               }

          }

          private void cboPeriod_SelectedIndexChanged(object sender, EventArgs e)
          {
               LoadDashboardData();
          }

          private void LoadDashboardData()
          {
               if (cboPeriod.SelectedItem == null)
                    return;

               // Sets value for Period Limit
               PeriodBudget selectedPeriod = (PeriodBudget)cboPeriod.SelectedItem;

               lblPeriodLimitValue.Text = selectedPeriod.TotalLimit.ToString("C");

               // Make Transactions list ordered in Date order
               using (var context = new BudgetAppContext())
               {
                    // Get Total Expenses in current period
                    decimal totalExpenses = context.Transactions
                         .Where(t => t.Date >= selectedPeriod.PeriodStartDate &&
                              t.Date <= selectedPeriod.PeriodEndDate &&
                              t.Category != null &&
                              t.Category.Type == CategoryType.Expense)
                         .Sum(t => (decimal?)t.Amount) ?? 0;
                    lblTotalExpenseValue.Text = totalExpenses.ToString("C");

                    // Get Total Income in current period
                    decimal totalIncome = context.Transactions
                         .Where(t => t.Date >= selectedPeriod.PeriodStartDate &&
                              t.Date <= selectedPeriod.PeriodEndDate &&
                              t.Category != null &&
                              t.Category.Type == CategoryType.Income)
                         .Sum(t => (decimal?)t.Amount) ?? 0;
                    lblTotalIncomeValue.Text = totalIncome.ToString("C");
                    
                    // Calculates Net Value and sets it
                    decimal netValue = totalIncome - totalExpenses;
                    lblNetValue.Text = netValue.ToString("C");

                    // Calculates Budget Left and sets it
                    decimal budgetLeft = selectedPeriod.TotalLimit - totalExpenses;
                    lblTotalRemaining.Text = budgetLeft.ToString("C");

                    LoadCategoryBreakdown(selectedPeriod);
               }
           
          }

          private void LoadCategoryBreakdown(PeriodBudget selectedPeriod)
          {
               // Clear the table
               dgvCategoryBreakdown.Rows.Clear(); 

               // Access the Database
               using (var context = new BudgetAppContext())
               {
                    // List of Category Budgets in current period
                    var categoryBudgets = context.CategoryBudgets
                         .Include(cb => cb.Category)  // Include Category entity from CategoryBudgets
                         .Where(cb => cb.PeriodBudgetId == selectedPeriod.Id)  // Adds Category Budgets that have same PeriodBudgetId 
                         .ToList();                                            // as the selected PeriodBudget to a list

                    // List of CategoryIds that were budgeted
                    var budgetedCategoryIds = categoryBudgets
                         .Select(cb => cb.CategoryId)  // Takes CategoryIds from CategoryBudgets and adds to list
                         .ToList();

                    // Loop for adding rows to table
                    foreach (var categoryBudget in categoryBudgets)
                    {
                         // Gets Category name from categoryBudget, checks if not null, then use the name, else "Unknown Category"
                         string categoryName = categoryBudget.Category != null
                              ? categoryBudget.Category.Name
                              : "Unknown Category";

                         // Gets the set Limit for each Category Budget
                         decimal budgetedAmount = categoryBudget.Limit; 

                         // Gets the amount spent for each category from transactions in current period
                         decimal amountSpent = context.Transactions
                              .Where(t => t.Date >= selectedPeriod.PeriodStartDate && // Transactions after PeriodStartDate
                                   t.Date <= selectedPeriod.PeriodEndDate &&  // Transactions before PeriodEndDate
                                   t.CategoryId == categoryBudget.CategoryId)  // Gets the Category from categoryBudget list for current period
                              .Sum(t => (decimal?)t.Amount) ?? 0; // Adds up transactions with same category, if null then 0

                         // Calculates how much budget is left in each category
                         decimal budgetRemaining = budgetedAmount - amountSpent;

                         // Calculates percentage of category budget used
                         string percentUsed;

                         // Prevent division by 0
                         if (budgetedAmount > 0)
                         {
                              percentUsed = (amountSpent / budgetedAmount).ToString("P0"); // Turns to Percentage with no decimals
                         }
                         else percentUsed = "Unbudgeted"; // For categories that weren't given a budget

                         // Adds all the stats to the table
                         dgvCategoryBreakdown.Rows.Add(
                              categoryName,
                              amountSpent.ToString("C"),
                              budgetedAmount.ToString("C"),
                              budgetRemaining.ToString("C"),
                              percentUsed
                              );

                    }

                    // Gets all the transaction categories that weren't assigned a budget
                    var unbudgetedCategories = context.Transactions
                              .Where(t =>
                                   t.Date >= selectedPeriod.PeriodStartDate &&
                                   t.Date <= selectedPeriod.PeriodEndDate &&
                                   t.Category != null &&
                                   t.Category.Type == CategoryType.Expense &&  // Expense transactions only; CategoryBudgets only take expense type already
                                   !budgetedCategoryIds.Contains(t.CategoryId)) // Gets categories not in budgetedCateoryId list
                              .GroupBy(t => t.CategoryId)  // All transactions of same category are grouped
                              .Select(g => new // g represents a single group
                              {
                                   CategoryName = g.First().Category != null  // Takes first transactions category
                                   ? g.First().Category.Name                  // object since they all have same category
                                   : "Unknown Category",
                                   SpentAmount = g.Sum(t => t.Amount) // Adds all transactions in group
                              }
                              ).ToList();

                    // Adds each unbudgeted category to the table
                    foreach (var group in unbudgetedCategories)
                    {
                         decimal budgetedAmount = 0;
                         decimal spentAmount = group.SpentAmount;
                         decimal remainingAmount = budgetedAmount - spentAmount;
                         string percentUsed = "Unbudgeted";

                         dgvCategoryBreakdown.Rows.Add(
                             group.CategoryName,
                             spentAmount.ToString("C"),
                             budgetedAmount.ToString("C"),
                             remainingAmount.ToString("C"),
                             percentUsed
                         );
                    }

               }

          }
     }
}
