using System;
using System.Linq;
using System.Windows.Forms;
using BudgetAppV2.Models;
using BudgetAppV2.Data;

namespace BudgetAppV2
{
     public partial class CategoriesForm : Form
     {
          public CategoriesForm()
          {
               InitializeComponent();
          }

          private void btnAddCategory_Click(object sender, EventArgs e)
          {
               
               
               // First think of what is not allowed
               // Validation
               // Checks if name is empty
               if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
               {
                    MessageBox.Show("Please enter a Category Name");
                    return;
               }

               CategoryType selectedType;
               // Ensures a category type is selected
               if (rbIncome.Checked == true)
               {
                    selectedType = CategoryType.Income;
               }
               else if (rbExpense.Checked == true)
               {
                    selectedType = CategoryType.Expense;
               }
               else
               {
                    MessageBox.Show("Please select a Category Type");
                    return;
               }

               string categoryName = txtCategoryName.Text.Trim();
               string normalizeCategoryName = categoryName.ToLower();

               // Database
               using (var context = new BudgetAppContext())
               {
                    bool duplicateExists = context.Categories
                         .Any(c => c.Name.ToLower().Trim() == normalizeCategoryName
                         && c.Type == selectedType);

                    // Duplicate check
                    if (duplicateExists)
                    {
                         MessageBox.Show("This category already exists. Enter another one");
                         txtCategoryName.Focus();
                         return;
                    }
                    var category = new Category
                    {
                         Name = categoryName,
                         Type = selectedType
                    };

                    context.Categories.Add(category); // adds category to EF's tracking (in memory)

                    context.SaveChanges(); // Writes all the changes to the db
               }

               RefreshCategoryList();

               ResetCategoryForm();

          }

          private void RefreshCategoryList()
          {
               lstCategories.Items.Clear();

               using (var context = new BudgetAppContext())
               {
                    // Creates categories list from categories
                    var categories = context.Categories.ToList();
                    // Adds category objects to listbox
                    foreach (var category in categories)
                    {
                         lstCategories.Items.Add(category);
                    }
               }

          }

          private void ResetCategoryForm()
          {
               lstCategories.ClearSelected();
               txtCategoryName.Clear();
               rbExpense.Checked = false;
               rbIncome.Checked = false;
               txtCategoryName.Focus();
               
          }

          private void btnDeleteCategory_Click(object sender, EventArgs e)
          {
               if (lstCategories.SelectedItem == null)
               {
                    MessageBox.Show("Need to select a category first.");
                    return;
               }

               Category selectedCategory = (Category)lstCategories.SelectedItem;

               DialogResult result = MessageBox.Show($"Delete category '{selectedCategory.Name}'?",
                                                           "Confirm Delete",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Warning);

               if (result != DialogResult.Yes)
               {
                    return;
               }

               using (var context = new BudgetAppContext())
               {
                    var categoryToDelete = context.Categories.Find(selectedCategory.Id);

                    if (categoryToDelete == null)
                    {
                         MessageBox.Show("Couldn't find category");
                         return;
                    }

                    

                    try
                    {
                         context.Categories.Remove(categoryToDelete);
                         context.SaveChanges();
                    }
                    catch
                    {
                         MessageBox.Show("Cannot delete a category that is being used by transactions.");
                         return;
                    }

                    
               }


               RefreshCategoryList();
               ResetCategoryForm();

          }

          private void CategoriesForm_Load(object sender, EventArgs e)
          {
               RefreshCategoryList();
               txtCategoryName.Focus();
          }
          // When selecting item in list
          private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
          {
               if (lstCategories.SelectedItem == null)
               {
                    return;
               }

               Category selectedCategory = (Category)lstCategories.SelectedItem;
               // Fills textboc with selected category name
               txtCategoryName.Text = selectedCategory.Name;
               // Selects correct radio button for the selected item type
               if (selectedCategory.Type == CategoryType.Income)
               {
                    rbIncome.Checked = true;
               }
               else
                    rbExpense.Checked = true;
          }

          private void btnEditCategory_Click(object sender, EventArgs e)
          {
               if (lstCategories.SelectedItem == null)
               {
                    MessageBox.Show("Please select a category to edit.");
                    return;
               }

               if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
               {
                    MessageBox.Show("Please enter a Category Name");
                    return;
               }

               CategoryType selectedType;

               if (rbIncome.Checked)
               {
                    selectedType = CategoryType.Income;
               }
               else if (rbExpense.Checked)
               {
                    selectedType = CategoryType.Expense;
               }
               else
               {
                    MessageBox.Show("Error. Please select a category type.");
                    return;
               }

               Category selectedCategory = (Category)lstCategories.SelectedItem;

               string updatedName = txtCategoryName.Text.Trim();
               string normalizeName = updatedName.ToLower();

               using (var context = new BudgetAppContext())
               {
                    var categoryToEdit = context.Categories.Find(selectedCategory.Id);

                    if (categoryToEdit == null)
                    {
                         MessageBox.Show("Couldn't find category");
                         return;
                    }

                    // Duplicate check
                    bool duplicateExists = context.Categories.Any(c =>
                        c.Id != selectedCategory.Id &&
                        c.Name.ToLower() == normalizeName &&
                        c.Type == selectedType);
                    if (duplicateExists)
                    {
                         MessageBox.Show("This category already exists. Enter another one");
                         return;
                    }
                    try
                    {
                         categoryToEdit.Name = updatedName;
                         categoryToEdit.Type = selectedType;
                         context.SaveChanges();
                    }
                    catch
                    {
                         MessageBox.Show("This edit could not be made at this time.");
                         return;
                    }
               }

               RefreshCategoryList();
               ResetCategoryForm();
          }
          
          private void btnManageTransactions_Click(object sender, EventArgs e)
          {
               TransactionsForm form = new TransactionsForm();
               form.Show();
               this.Hide();
          }
          
          private void btnPeriodBudget_Click(object sender, EventArgs e)
          {
               PeriodBudgetsForm form = new PeriodBudgetsForm();
               form.Show();
               this.Hide();
          }
          
          private void btnCategoryBudgets_Click(object sender, EventArgs e)
          {
               CategoryBudgetsForm form = new CategoryBudgetsForm();
               form.Show();
               this.Hide();
          }
          
     }
}
          