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
               // Validates that the total limit is greater than 0
               if (nudTotalLimit.Value <= 0)
               {
                    MessageBox.Show("Total limit must be greater than 0");
                    return;
               }

               // Validates that Start date is before the End date
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

          private void btnEditPB_Click(object sender, EventArgs e)
          {
               // Validate that a Period Budget is selected from the list
               if (lstPeriodBudgets.SelectedItem == null)
               {
                    MessageBox.Show("Must select a Period Budget from the list");
                    return;
               }

               // Validate the the total limit is greater then 0
               if (nudTotalLimit.Value <= 0)
               {
                    MessageBox.Show("Must enter a value that is non-negative or zero.");
                    return;
               }

               // Validates that Start date is before the End date
               if (dtpPeriodEndDate.Value.Date < dtpPeriodStartDate.Value.Date)
               {
                    MessageBox.Show("Start date must be equal to or before End date.");
                    return;
               }

               // Assign selected PeriodBudget from list
               PeriodBudget selectedPB = (PeriodBudget)lstPeriodBudgets.SelectedItem;

               // Assign all the updated values
               decimal updatedLimit = nudTotalLimit.Value;
               DateTime updatedStartDate = dtpPeriodStartDate.Value.Date;
               DateTime updatedEndDate = dtpPeriodEndDate.Value.Date;

               using (var context = new BudgetAppContext())
               {
                    var periodBudgetsToEdit = context.PeriodBudgets.Find(selectedPB.Id);

                    // Validate that selected PeriodBudget exists in the database
                    if (periodBudgetsToEdit == null)
                    {
                         MessageBox.Show("Couldn't find the selected PeriodBudget in the database");
                         return;
                    }
                    // Change values in the Database, if failure, return
                    try
                    {
                         periodBudgetsToEdit.TotalLimit = updatedLimit;
                         periodBudgetsToEdit.PeriodStartDate = updatedStartDate;
                         periodBudgetsToEdit.PeriodEndDate = updatedEndDate;
                         context.SaveChanges();
                    }
                    catch
                    {
                         MessageBox.Show("This edit could not be made at this time");
                         return;
                    }

                    RefreshPeriodBudgetList();
                    ResetPeriodBudgetForm();

               }

          }

          private void lstPeriodBudgets_SelectedIndexChanged(object sender, EventArgs e)
          {
               // Only activates when an Item is selected from the list
               if (lstPeriodBudgets.SelectedItem == null)
               {
                    return;
               }
               // Assigns the selected PB from the list to variable
               PeriodBudget selectedPB = (PeriodBudget)lstPeriodBudgets.SelectedItem;
               // Shows the properties from selectedPB on UI
               nudTotalLimit.Value = selectedPB.TotalLimit;
               dtpPeriodStartDate.Value = selectedPB.PeriodStartDate;
               dtpPeriodEndDate.Value = selectedPB.PeriodEndDate;



          }

          private void btnDeletePB_Click(object sender, EventArgs e)
          {
               // Validates if an item is selected
               if (lstPeriodBudgets.SelectedItem == null)
               {
                    MessageBox.Show("Must select a Period Budget from the list");
                    return;
               }

               // Assigns the selected PeriodBudget from the list to variable
               PeriodBudget selectedPB = (PeriodBudget)lstPeriodBudgets.SelectedItem;

               // Delete confirmation
               DialogResult result = MessageBox.Show($"Delete Period Budget '{selectedPB}'?",
                                                                 "Confirm Delete",
                                                                 MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Warning);
               // Returns if the user pressed no
               if (result != DialogResult.Yes )
               {
                    return;
               }
               
               using (var context = new BudgetAppContext())
               {
                    // Finds selectedPB from database
                    var periodBudgetToDelete = context.PeriodBudgets.Find(selectedPB.Id);


                    if (periodBudgetToDelete == null)
                    {
                         MessageBox.Show("Couldn't find Period Budget");
                         return;
                    }

                    try
                    {
                         context.PeriodBudgets.Remove(periodBudgetToDelete);
                         context.SaveChanges();
                    }
                    catch
                    {
                         MessageBox.Show("Period Budget couldn't be deleted at this time");
                         return;
                    }
               }

          }
     }
}
