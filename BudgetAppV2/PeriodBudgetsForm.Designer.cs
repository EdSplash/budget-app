namespace BudgetAppV2
{
     partial class PeriodBudgetsForm
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.btnAddPeriodBudget = new System.Windows.Forms.Button();
               this.nudTotalLimit = new System.Windows.Forms.NumericUpDown();
               this.dtpPeriodStartDate = new System.Windows.Forms.DateTimePicker();
               this.dtpPeriodEndDate = new System.Windows.Forms.DateTimePicker();
               this.lstPeriodBudgets = new System.Windows.Forms.ListBox();
               this.btnManageTransactions = new System.Windows.Forms.Button();
               this.btnOpenCategories = new System.Windows.Forms.Button();
               this.lblStartDate = new System.Windows.Forms.Label();
               this.lblEndDate = new System.Windows.Forms.Label();
               this.lblTotalLimit = new System.Windows.Forms.Label();
               this.btnCategoryBudgets = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.nudTotalLimit)).BeginInit();
               this.SuspendLayout();
               // 
               // btnAddPeriodBudget
               // 
               this.btnAddPeriodBudget.Location = new System.Drawing.Point(510, 280);
               this.btnAddPeriodBudget.Name = "btnAddPeriodBudget";
               this.btnAddPeriodBudget.Size = new System.Drawing.Size(136, 29);
               this.btnAddPeriodBudget.TabIndex = 0;
               this.btnAddPeriodBudget.Text = "Add Period Budget";
               this.btnAddPeriodBudget.UseVisualStyleBackColor = true;
               this.btnAddPeriodBudget.Click += new System.EventHandler(this.btnAddPeriodBudget_Click);
               // 
               // nudTotalLimit
               // 
               this.nudTotalLimit.DecimalPlaces = 2;
               this.nudTotalLimit.Location = new System.Drawing.Point(510, 150);
               this.nudTotalLimit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
               this.nudTotalLimit.Name = "nudTotalLimit";
               this.nudTotalLimit.Size = new System.Drawing.Size(120, 22);
               this.nudTotalLimit.TabIndex = 2;
               // 
               // dtpPeriodStartDate
               // 
               this.dtpPeriodStartDate.Location = new System.Drawing.Point(207, 152);
               this.dtpPeriodStartDate.Name = "dtpPeriodStartDate";
               this.dtpPeriodStartDate.Size = new System.Drawing.Size(200, 22);
               this.dtpPeriodStartDate.TabIndex = 3;
               // 
               // dtpPeriodEndDate
               // 
               this.dtpPeriodEndDate.Location = new System.Drawing.Point(207, 220);
               this.dtpPeriodEndDate.Name = "dtpPeriodEndDate";
               this.dtpPeriodEndDate.Size = new System.Drawing.Size(200, 22);
               this.dtpPeriodEndDate.TabIndex = 4;
               // 
               // lstPeriodBudgets
               // 
               this.lstPeriodBudgets.FormattingEnabled = true;
               this.lstPeriodBudgets.ItemHeight = 16;
               this.lstPeriodBudgets.Location = new System.Drawing.Point(207, 280);
               this.lstPeriodBudgets.Name = "lstPeriodBudgets";
               this.lstPeriodBudgets.Size = new System.Drawing.Size(267, 148);
               this.lstPeriodBudgets.TabIndex = 5;
               // 
               // btnManageTransactions
               // 
               this.btnManageTransactions.Location = new System.Drawing.Point(19, 21);
               this.btnManageTransactions.Name = "btnManageTransactions";
               this.btnManageTransactions.Size = new System.Drawing.Size(125, 30);
               this.btnManageTransactions.TabIndex = 9;
               this.btnManageTransactions.Text = "Transactions";
               this.btnManageTransactions.UseVisualStyleBackColor = true;
               this.btnManageTransactions.Click += new System.EventHandler(this.btnManageTransactions_Click);
               // 
               // btnOpenCategories
               // 
               this.btnOpenCategories.Location = new System.Drawing.Point(19, 57);
               this.btnOpenCategories.Name = "btnOpenCategories";
               this.btnOpenCategories.Size = new System.Drawing.Size(125, 30);
               this.btnOpenCategories.TabIndex = 10;
               this.btnOpenCategories.Text = "Categories";
               this.btnOpenCategories.UseVisualStyleBackColor = true;
               this.btnOpenCategories.Click += new System.EventHandler(this.btnOpenCategories_Click);
               // 
               // lblStartDate
               // 
               this.lblStartDate.AutoSize = true;
               this.lblStartDate.Location = new System.Drawing.Point(138, 152);
               this.lblStartDate.Name = "lblStartDate";
               this.lblStartDate.Size = new System.Drawing.Size(66, 16);
               this.lblStartDate.TabIndex = 11;
               this.lblStartDate.Text = "Start Date";
               // 
               // lblEndDate
               // 
               this.lblEndDate.AutoSize = true;
               this.lblEndDate.Location = new System.Drawing.Point(138, 220);
               this.lblEndDate.Name = "lblEndDate";
               this.lblEndDate.Size = new System.Drawing.Size(63, 16);
               this.lblEndDate.TabIndex = 12;
               this.lblEndDate.Text = "End Date";
               // 
               // lblTotalLimit
               // 
               this.lblTotalLimit.AutoSize = true;
               this.lblTotalLimit.Location = new System.Drawing.Point(507, 121);
               this.lblTotalLimit.Name = "lblTotalLimit";
               this.lblTotalLimit.Size = new System.Drawing.Size(68, 16);
               this.lblTotalLimit.TabIndex = 13;
               this.lblTotalLimit.Text = "Total Limit";
               // 
               // btnCategoryBudgets
               // 
               this.btnCategoryBudgets.Location = new System.Drawing.Point(19, 93);
               this.btnCategoryBudgets.Name = "btnCategoryBudgets";
               this.btnCategoryBudgets.Size = new System.Drawing.Size(125, 30);
               this.btnCategoryBudgets.TabIndex = 14;
               this.btnCategoryBudgets.Text = "Category Budgets";
               this.btnCategoryBudgets.UseVisualStyleBackColor = true;
               this.btnCategoryBudgets.Click += new System.EventHandler(this.btnCategoryBudgets_Click);
               // 
               // PeriodBudgetsForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.btnCategoryBudgets);
               this.Controls.Add(this.lblTotalLimit);
               this.Controls.Add(this.lblEndDate);
               this.Controls.Add(this.lblStartDate);
               this.Controls.Add(this.btnOpenCategories);
               this.Controls.Add(this.btnManageTransactions);
               this.Controls.Add(this.lstPeriodBudgets);
               this.Controls.Add(this.dtpPeriodEndDate);
               this.Controls.Add(this.dtpPeriodStartDate);
               this.Controls.Add(this.nudTotalLimit);
               this.Controls.Add(this.btnAddPeriodBudget);
               this.Name = "PeriodBudgetsForm";
               this.Text = "Period Budgets";
               ((System.ComponentModel.ISupportInitialize)(this.nudTotalLimit)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button btnAddPeriodBudget;
          private System.Windows.Forms.NumericUpDown nudTotalLimit;
          private System.Windows.Forms.DateTimePicker dtpPeriodStartDate;
          private System.Windows.Forms.DateTimePicker dtpPeriodEndDate;
          private System.Windows.Forms.ListBox lstPeriodBudgets;
          private System.Windows.Forms.Button btnManageTransactions;
          private System.Windows.Forms.Button btnOpenCategories;
          private System.Windows.Forms.Label lblStartDate;
          private System.Windows.Forms.Label lblEndDate;
          private System.Windows.Forms.Label lblTotalLimit;
          private System.Windows.Forms.Button btnCategoryBudgets;
     }
}