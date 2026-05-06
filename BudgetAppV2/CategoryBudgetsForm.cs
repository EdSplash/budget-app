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
                         .Where(c => c.Type == CategoryType.Expense) // Gets only 
                         .OrderBy(c => c.Name)
                         .ToList();

                    cboCategories.DataSource = null;
                    cboCategories.DataSource = categories; // Gets from categories database
                    cboCategories.DisplayMember = "Name"; // Displays the Category Name
                    cboCategories.ValueMember = "Id"; // Gets id property from Database
               }

          }

          private void LoadPeriodBudgets()
          {
               cboPeriodBudgets.Items.Clear();

               using (var context = new BudgetAppContext())
               {
                    // Retrieves objects from database into list
                    var periodBudgets = context.PeriodBudgets
                         .OrderByDescending(pb => pb.PeriodStartDate) // Orders by most recent date at top
                         .ToList();

                    cboPeriodBudgets.DataSource = null;
                    cboPeriodBudgets.DataSource = periodBudgets; // Gets or sets data for ComboBox 
                    cboPeriodBudgets.DisplayMember = "DisplayText";
                    cboPeriodBudgets.ValueMember = "Id"; // Gets Id property from Data
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

          private void btnDeleteCB_Click(object sender, EventArgs e)
          {
               // Validate a category is selected
               if (lstCategoryBudget.SelectedItem == null)
               {
                    MessageBox.Show("Need to select a category budget first.");
                    return;
               }

               CategoryBudget selectedCB = (CategoryBudget)lstCategoryBudget.SelectedItem;

               // Null checks the category name
               string selectedCategoryName = selectedCB.Category?.Name ?? "Unknown Category";
               // Ask for user deleted confirmation
               DialogResult result = MessageBox.Show($"Delete category '{selectedCategoryName}'?",
                                                           "Confirm Delete",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Warning);

               if (result != DialogResult.Yes)
               {
                    return;
               }

               using (var context = new BudgetAppContext())
               {
                    // Retrieves the Category Budget from the database
                    var categoryBudgetToDelete = context.CategoryBudgets.Find(selectedCB.Id);

                    // Checks if the Category Budget got retrieved from the database
                    if (categoryBudgetToDelete == null)
                    {
                         MessageBox.Show("Couldn't find Category Budget");
                         return;
                    }

                    // If Category Budget is being used by a transaction, it can't be deleted
                    try
                    {
                         context.CategoryBudgets.Remove(categoryBudgetToDelete);
                         context.SaveChanges();
                    }
                    catch
                    {
                         MessageBox.Show("Cannot delete a category that is being used by transactions.");
                         return;
                    }

               }
          }

          private void btnEditCB_Click(object sender, EventArgs e)
          {
               // Checks if a Category Budget from list is selected
               if (lstCategoryBudget.SelectedItem == null)
               {
                    MessageBox.Show("Please select a category budget to edit.");
                    return;
               }

               // Checks if a category is selected in Category cbo
               if (cboCategories.SelectedItem == null)
               {
                    MessageBox.Show("Must asign a category.");
                    return;
               }

               // Validation that period is selected
               if (cboPeriodBudgets.SelectedItem == null)
               {
                    MessageBox.Show("Must assign a period.");
                    return;
               }

               // Validation for a poitivve number
               if (nudLimitAmount.Value <= 0)
               {
                    MessageBox.Show("Must enter a value that is non-negative and greater than 0.");
                    return;
               }

               // Assign selected CategoryBudget from list
               CategoryBudget selectedCategoryBudget = (CategoryBudget)lstCategoryBudget.SelectedItem;

               // Assign updated values
               Category updatedCategory = (Category)cboCategories.SelectedItem;
               PeriodBudget updatedPeriod = (PeriodBudget)cboPeriodBudgets.SelectedItem;
               decimal updatedLimit = nudLimitAmount.Value;

               using (var context = new BudgetAppContext())
               {
                    var categoryBudgetToEdit = context.CategoryBudgets.Find(selectedCategoryBudget.Id);

                    // Validation to see if the selected CategoryBudget exists in database
                    if (categoryBudgetToEdit == null)
                    {
                         MessageBox.Show("Could not finde selected CategoryBudget in Database.");
                         return;
                    }

                    // Duplicate check
                    bool duplicateExists = context.CategoryBudgets.Any(cb =>
                        cb.Id != selectedCategoryBudget.Id &&  // Compares to every CB except the one we are editting
                        cb.PeriodBudgetId == updatedPeriod.Id &&
                        cb.CategoryId == updatedCategory.Id);
                    if (duplicateExists)
                    {
                         MessageBox.Show("This category already exists within this Period Budget. Try again");
                         return;
                    }
                    try
                    {
                         categoryBudgetToEdit.CategoryId = updatedCategory.Id;
                         categoryBudgetToEdit.PeriodBudgetId = updatedPeriod.Id;
                         categoryBudgetToEdit.Limit = updatedLimit;
                         context.SaveChanges();
                    }
                    catch
                    {
                         MessageBox.Show("This edit could not be made at this time.");
                         return;
                    }
               }
               RefreshCategoryBudgetList();
               ResetCategoryBudgetForm();

          }

          private void lstCategoryBudget_SelectedIndexChanged(object sender, EventArgs e)
          {
               // Validates an Item is selected from the list
               if (lstCategoryBudget.SelectedItem == null)
               {
                    return;
               }

               // Display the selected item in the UI
               CategoryBudget selectedCB = (CategoryBudget)lstCategoryBudget.SelectedItem;

               // Display the selected Object in UI
               cboCategories.SelectedValue = selectedCB.CategoryId;
               cboPeriodBudgets.SelectedValue = selectedCB.PeriodBudgetId;
               nudLimitAmount.Value = selectedCB.Limit;
               
          }
     }
}
