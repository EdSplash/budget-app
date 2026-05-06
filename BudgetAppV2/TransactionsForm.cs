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
          private void LoadCategories()
          {
               cboCategories.Items.Clear();

               using (var context = new BudgetAppContext())
               {
                    // Create a list of categories from db
                    var categories = context.Categories.ToList();

                    // Insert each category object into cbo
                    foreach (var category in categories)
                    {
                         cboCategories.Items.Add(category);
                    }
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

          private void lblAmount_Click(object sender, EventArgs e)
          {

          }
     }
}
