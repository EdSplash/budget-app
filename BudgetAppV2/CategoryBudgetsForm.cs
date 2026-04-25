using BudgetAppV2.Data;
using BudgetAppV2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetAppV2
{
     public partial class CategoryBudgetsForm : Form
     {
          public CategoryBudgetsForm()
          {
               InitializeComponent();
          }

          private void btnAddCategoryBudget_Click(object sender, EventArgs e)
          {
               if (nudLimitAmount.Value <= 0)
               {
                    MessageBox.Show("Total limit must be greater than 0");
                    return;
               }

               if (cboCategories.SelectedItem == null)
               {
                    MessageBox.Show("Must select a category from the list");
                    return;
               }

               if (cboPeriodBudgets.SelectedItem == null)
               {
                    MessageBox.Show("Must select a Period Budget from the list");
                    return;
               }
               

               // Cast objects
               Category selectedCategory = (Category)cboCategories.SelectedItem;
               PeriodBudget selectedPeriodBudget = (PeriodBudget)cboPeriodBudgets.SelectedItem;
               
               using (var context = new BudgetAppContext())
               {
                    var periodBudgetDb = context.PeriodBudgets
                         .First(pb => pb.Id == selectedPeriodBudget.Id);

                    // Look for all CategoryBudgets in DB that match
                    // selected PeriodBudget and add their limit values up
                    // If there are none then use 0
                    decimal categorySum = context.CategoryBudgets
                         .Where(cb => cb.PeriodBudgetId == periodBudgetDb.Id)
                         .Sum(cb => (decimal?)cb.Limit) ?? 0; // Treat cb.Limit as nullable decimal; ?? means assign 0 instead of null

                    decimal newCategorySum = categorySum + nudLimitAmount.Value;

                    if (newCategorySum > periodBudgetDb.TotalLimit)
                    {
                         MessageBox.Show("Sum of category limits for current period exceed Period Budget limit. Enter a smaller value");
                         return;
                    }

                    bool duplicateExists = context.CategoryBudgets.Any(cb =>
                    cb.CategoryId == selectedCategory.Id &&
                    cb.PeriodBudgetId == periodBudgetDb.Id);

                    if (duplicateExists)
                    {
                         MessageBox.Show("This category already has a budget for the selected period.");
                         return;
                    }

                    var newCategoryBudget = new CategoryBudget
                    {
                         PeriodBudgetId = periodBudgetDb.Id,
                         CategoryId = selectedCategory.Id,
                         Limit = nudLimitAmount.Value
                    };

                    context.CategoryBudgets.Add(newCategoryBudget);
                    context.SaveChanges();

               }

               RefreshCategoryBudgetList();
               ResetCategoryBudgetForm();
          }
          private void LoadCategories()
          {
               cboCategories.Items.Clear();

               using (var context = new BudgetAppContext())
               {
                    var categories = context.Categories
                         .Where(c => c.Type == CategoryType.Expense)
                         .ToList();
                    foreach (var category in categories)
                    {
                         cboCategories.Items.Add(category);
                    }
               }
               
          }

          private void LoadPeriodBudgets()
          {
               cboPeriodBudgets.Items.Clear();

               using (var context = new BudgetAppContext())
               {
                    var periodBudgets = context.PeriodBudgets.ToList();

                    foreach (var periodBudget in periodBudgets)
                    {
                         cboPeriodBudgets.Items.Add(periodBudget);
                    }
               }
               
          }

          private void RefreshCategoryBudgetList()
          {
               lstCategoryBudget.Items.Clear();

               using (var context = new BudgetAppContext())
               {
                    // Retrieves CategoryBudgets from database and inserts them in a list
                    var categoryBudgets = context.CategoryBudgets
                         .Include(cb => cb.PeriodBudget) // For each CategoryBudget, also load its related PeriodBudget object
                         .Include(cb => cb.Category) // Load Related category object
                         .ToList();

                    // Insert each CategoryBudget object into the ListBox
                    foreach (var categoryBudget in categoryBudgets)
                    {
                         lstCategoryBudget.Items.Add(categoryBudget);
                    }
               }

          }

          private void ResetCategoryBudgetForm()
          {
               nudLimitAmount.Value = 0;
               cboCategories.SelectedIndex = -1;
               cboPeriodBudgets.SelectedIndex = -1;
               nudLimitAmount.Focus();
          }

          private void CategoryBudgetsForm_Load(object sender, EventArgs e)
          {
               LoadCategories();
               LoadPeriodBudgets();
               RefreshCategoryBudgetList();
               ResetCategoryBudgetForm();

          }
          /*
          private void btnCategories_Click(object sender, EventArgs e)
          {
               CategoriesForm form = new CategoriesForm();
               form.Show();
               this.Hide();
          }

          private void btnTransactions_Click(object sender, EventArgs e)
          {
               TransactionsForm form = new TransactionsForm();
               form.Show();
               this.Hide();
          }

          private void btnPeriodBudgets_Click(object sender, EventArgs e)
          {
               PeriodBudgetsForm form = new PeriodBudgetsForm();
               form.Show();
               this.Hide();
          }
          */
     }
}
