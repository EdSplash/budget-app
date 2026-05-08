using BudgetAppV2.Models;
using BudgetAppV2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace BudgetAppV2
{
     public partial class TransactionsForm : Form
     {
          public TransactionsForm()
          {
               InitializeComponent();
          }

          private void btnAddTransaction_Click(object sender, EventArgs e)
          {
               if (nudAmount.Value <= 0)
               {
                    MessageBox.Show("Must enter a valid dollar amount.");
                    return;
               }

               if (cboCategories.SelectedItem == null)
               {
                    MessageBox.Show("Must select a category from the list");
                    return;
               }

               Category selectedCategory = (Category)cboCategories.SelectedItem;

               using (var context = new BudgetAppContext())
               {
                    var transaction = new Transaction
                    {
                         Amount = nudAmount.Value,
                         Date = dtpTransactionDate.Value.Date,
                         Description = txtDescription.Text.Trim(),
                         CategoryId = selectedCategory.Id
                    };

                    context.Transactions.Add(transaction);
                    context.SaveChanges();
               }

               RefreshTransactionList();
               ResetTransactionForm();
          }
          // Loads categories into cbo
          // Also helps lstTransactions_SelectedIndexChanged method
          // display the category name into cboCategory
          private void LoadCategories()
          {
               cboCategories.Items.Clear();

               using (var context = new BudgetAppContext())
               {
                    var categories = context.Categories
                         .OrderBy(c => c.Name)
                         .ThenBy(c => c.Type)
                         .ToList();

                    cboCategories.DataSource = null;
                    cboCategories.DataSource = categories; // Gets from categories database
                    cboCategories.DisplayMember = "DisplayText"; // Displays the Category Name
                    cboCategories.ValueMember = "Id"; // Gets id property from Database
               }

          }
          // Updates list of Transactions
          private void RefreshTransactionList()
          {
               lstTransactions.Items.Clear();

               using (var context = new BudgetAppContext())
               {
                    // Retrieves transactions from database and inserts them in a list
                    var transactions = context.Transactions
                         .Include(t => t.Category) // For each transaction, also load its related category object
                         .OrderByDescending(t => t.Date) // Most recent transactions at top
                         .ToList();

                    // Insert each transactin object into the ListBox
                    foreach (var transaction in transactions)
                    {
                         lstTransactions.Items.Add(transaction);
                    }
               }

          }

          private void ResetTransactionForm()
          {
               nudAmount.Value = 0;
               cboCategories.SelectedIndex = -1;
               dtpTransactionDate.Value = DateTime.Today;
               txtDescription.Clear();
               nudAmount.Focus();
               nudAmount.Select(0, nudAmount.Text.Length);

          }

          private void TransactionsForm_Load(object sender, EventArgs e)
          {
               LoadCategories();
               RefreshTransactionList();
               ResetTransactionForm();

          }

          private void btnOpenCategories_Click(object sender, EventArgs e)
          {
               CategoriesForm form = new CategoriesForm();
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

          private void btnEditTransaction_Click(object sender, EventArgs e)
          {
               // Validate an item is selected from list
               if (lstTransactions.SelectedItem == null)
               {
                    MessageBox.Show("Please select an item from list to edit");
                    return;
               }

               // Validate a number greater than 0 is in nud
               if (nudAmount.Value <= 0)
               {
                    MessageBox.Show("Amount must be greater than 0");
                    return;
               }

               // Validates a category is selected in Category cbo
               if (cboCategories.SelectedItem == null)
               {
                    MessageBox.Show("Must assign a category.");
                    return;
               }

               Transaction selectedTransaction = (Transaction)lstTransactions.SelectedItem;

               // Update properties
               decimal updatedAmount = nudAmount.Value;
               Category updatedCategory = (Category)cboCategories.SelectedItem;
               DateTime updatedDate = dtpTransactionDate.Value.Date;
               string updatedDescription = txtDescription.Text;

               using (var context = new BudgetAppContext())
               {
                    var transactionToEdit = context.Transactions.Find(selectedTransaction.Id);

                    // Validate selected item is in database
                    if (transactionToEdit == null)
                    {
                         MessageBox.Show("Couldn't find the selected Transaction in database");
                         return;
                    }

                    try
                    {
                         transactionToEdit.Amount = updatedAmount;
                         transactionToEdit.CategoryId = updatedCategory.Id;
                         transactionToEdit.Date = updatedDate;
                         transactionToEdit.Description = updatedDescription;
                         context.SaveChanges();
                    }
                    catch
                    {
                         MessageBox.Show("This edit could not be made at this time.");
                         return;
                    }

                    RefreshTransactionList();
                    ResetTransactionForm();
               }


          }

          private void btnDeleteTransaction_Click(object sender, EventArgs e)
          {
               // Validate a transaction is selected from list
               if (lstTransactions.SelectedItem == null)
               {
                    MessageBox.Show("Must select a transaction from list to edit.");
                    return;
               }

               // Assign selected Transaction
               Transaction selectedTransaction = (Transaction)lstTransactions.SelectedItem;

               // Ask for user confirmation
               DialogResult result = MessageBox.Show($"Delete transaction '{selectedTransaction}?",
                                                            "Confirm Delete",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);
               if (result != DialogResult.Yes)
               {
                    return;
               }

               using (var context = new BudgetAppContext())
               {
                    // Finds selectedTransaction in database and assigns it
                    var transactionToDelete = context.Transactions.Find(selectedTransaction.Id);

                    // Validates if transactionToDelete is in database
                    if (transactionToDelete == null)
                    {
                         MessageBox.Show("Couldn't find the transaction in the database.");
                         return;
                    }

                    try
                    {
                         context.Transactions.Remove(transactionToDelete);
                         context.SaveChanges();
                    }
                    catch
                    {
                         MessageBox.Show("Cannot delete Transaction at this time");
                         return;
                    }


               }
               RefreshTransactionList();
               ResetTransactionForm();


          }

          private void lstTransactions_SelectedIndexChanged(object sender, EventArgs e)
          {
               // Only run when an Item is selected
               if (lstTransactions.SelectedItem == null)
               {
                    return;
               }

               Transaction selectedTransaction = (Transaction)lstTransactions.SelectedItem;

               nudAmount.Value = selectedTransaction.Amount;
               cboCategories.SelectedValue = selectedTransaction.CategoryId;
               dtpTransactionDate.Value = selectedTransaction.Date;
               txtDescription.Text = selectedTransaction.Description;

          }
     }
}
