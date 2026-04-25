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

               LoadPeriodBudgets();
               LoadDashboardData();
          }

          private void btnCategories_Click(object sender, EventArgs e)
          {
               CategoriesForm form = new CategoriesForm();
               form.ShowDialog();

               LoadPeriodBudgets();
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

               LoadPeriodBudgets();
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
                         .OrderBy(pb => pb.PeriodStartDate)
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
               }
                
                
               


          }
     }
}
