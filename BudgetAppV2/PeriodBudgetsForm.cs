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

namespace BudgetAppV2
{
     public partial class PeriodBudgetsForm : Form
     {
          public PeriodBudgetsForm()
          {
               InitializeComponent();
          }

          private void btnAddPeriodBudget_Click(object sender, EventArgs e)
          {
               if (nudTotalLimit.Value <= 0)
               {
                    MessageBox.Show("Total limit must be greater than 0");
                    return;
               }

               if (dtpPeriodEndDate.Value.Date < dtpPeriodStartDate.Value.Date)
               {
                    MessageBox.Show("Start date must be equal to or before End date.");
                    return;
               }

               using (var context = new BudgetAppContext())
               {
                    var periodBudget = new PeriodBudget
                    {
                         TotalLimit = nudTotalLimit.Value,
                         PeriodStartDate = dtpPeriodStartDate.Value.Date,
                         PeriodEndDate = dtpPeriodEndDate.Value.Date,
                    };

                    context.PeriodBudgets.Add(periodBudget);
                    context.SaveChanges();

               }

               RefreshPeriodBudgetList();
               ResetPeriodBudgetForm();
          }

          private void RefreshPeriodBudgetList()
          {
               lstPeriodBudgets.Items.Clear();

               using (var context = new BudgetAppContext())
               {
                    // Create a list of PeriodBudgets from db
                    var periodBudgets = context.PeriodBudgets.ToList();

                    // Insert each PeriodBudget object into listbox
                    foreach (var periodBudget in periodBudgets)
                    {
                         lstPeriodBudgets.Items.Add(periodBudget);
                    }
               }

          }

          private void ResetPeriodBudgetForm()
          {
               nudTotalLimit.Value = 0;
               dtpPeriodStartDate.Value = DateTime.Today;
               dtpPeriodEndDate.Value = DateTime.Today;
               nudTotalLimit.Focus();
               nudTotalLimit.Select(0, nudTotalLimit.Text.Length);
          }

          private void btnManageTransactions_Click(object sender, EventArgs e)
          {
               TransactionsForm form = new TransactionsForm();
               form.Show();
               this.Hide();
          }

          private void btnOpenCategories_Click(object sender, EventArgs e)
          {
               CategoriesForm form = new CategoriesForm();
               form.Show();
               this.Hide();
          }

          private void btnCategoryBudgets_Click(object sender, EventArgs e)
          {
               CategoryBudgetsForm form = new CategoryBudgetsForm();
               form.Show();
               this.Hide();
          }


          private void PeriodBudgetForm_Load(object sender, EventArgs e)
          {
               RefreshPeriodBudgetList();
               ResetPeriodBudgetForm();
               
               
          }
     }
}
