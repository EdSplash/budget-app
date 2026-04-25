namespace BudgetAppV2
{
     partial class MainMenuForm
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
               btnCategories = new Button();
               btnTransactions = new Button();
               btnPeriodBudgets = new Button();
               btnCategoryBudgets = new Button();
               cboPeriod = new ComboBox();
               lblTotalIncomeValue = new Label();
               lblTotalExpenseValue = new Label();
               lblNetValue = new Label();
               lblPeriodLimitValue = new Label();
               lblTotalRemaining = new Label();
               dgvCategoryBreakdown = new DataGridView();
               label1 = new Label();
               label2 = new Label();
               label3 = new Label();
               label4 = new Label();
               label5 = new Label();
               ((System.ComponentModel.ISupportInitialize)dgvCategoryBreakdown).BeginInit();
               SuspendLayout();
               // 
               // btnCategories
               // 
               btnCategories.BackColor = Color.Lavender;
               btnCategories.Cursor = Cursors.Hand;
               btnCategories.Location = new Point(12, 12);
               btnCategories.Name = "btnCategories";
               btnCategories.Size = new Size(140, 30);
               btnCategories.TabIndex = 0;
               btnCategories.Text = "Categories";
               btnCategories.UseVisualStyleBackColor = false;
               btnCategories.Click += btnCategories_Click;
               // 
               // btnTransactions
               // 
               btnTransactions.BackColor = Color.Lavender;
               btnTransactions.Cursor = Cursors.Hand;
               btnTransactions.Location = new Point(158, 12);
               btnTransactions.Name = "btnTransactions";
               btnTransactions.Size = new Size(140, 30);
               btnTransactions.TabIndex = 1;
               btnTransactions.Text = "Transactions";
               btnTransactions.UseVisualStyleBackColor = false;
               btnTransactions.Click += btnTransactions_Click;
               // 
               // btnPeriodBudgets
               // 
               btnPeriodBudgets.BackColor = Color.Lavender;
               btnPeriodBudgets.Cursor = Cursors.Hand;
               btnPeriodBudgets.Location = new Point(304, 12);
               btnPeriodBudgets.Name = "btnPeriodBudgets";
               btnPeriodBudgets.Size = new Size(140, 30);
               btnPeriodBudgets.TabIndex = 2;
               btnPeriodBudgets.Text = "Period Budgets";
               btnPeriodBudgets.UseVisualStyleBackColor = false;
               btnPeriodBudgets.Click += btnPeriodBudgets_Click;
               // 
               // btnCategoryBudgets
               // 
               btnCategoryBudgets.BackColor = Color.Lavender;
               btnCategoryBudgets.Cursor = Cursors.Hand;
               btnCategoryBudgets.Location = new Point(450, 12);
               btnCategoryBudgets.Name = "btnCategoryBudgets";
               btnCategoryBudgets.Size = new Size(140, 30);
               btnCategoryBudgets.TabIndex = 3;
               btnCategoryBudgets.Text = "Category Budgets";
               btnCategoryBudgets.UseVisualStyleBackColor = false;
               btnCategoryBudgets.Click += btnCategoryBudgets_Click;
               // 
               // cboPeriod
               // 
               cboPeriod.FormattingEnabled = true;
               cboPeriod.Location = new Point(674, 12);
               cboPeriod.Name = "cboPeriod";
               cboPeriod.Size = new Size(262, 28);
               cboPeriod.TabIndex = 4;
               cboPeriod.Text = "Period";
               cboPeriod.SelectedIndexChanged += cboPeriod_SelectedIndexChanged;
               // 
               // lblTotalIncomeValue
               // 
               lblTotalIncomeValue.AutoSize = true;
               lblTotalIncomeValue.Location = new Point(140, 83);
               lblTotalIncomeValue.Name = "lblTotalIncomeValue";
               lblTotalIncomeValue.Size = new Size(95, 20);
               lblTotalIncomeValue.TabIndex = 5;
               lblTotalIncomeValue.Text = "Total Income";
               // 
               // lblTotalExpenseValue
               // 
               lblTotalExpenseValue.AutoSize = true;
               lblTotalExpenseValue.Location = new Point(140, 114);
               lblTotalExpenseValue.Name = "lblTotalExpenseValue";
               lblTotalExpenseValue.Size = new Size(100, 20);
               lblTotalExpenseValue.TabIndex = 6;
               lblTotalExpenseValue.Text = "Total Expense";
               // 
               // lblNetValue
               // 
               lblNetValue.AutoSize = true;
               lblNetValue.Location = new Point(140, 150);
               lblNetValue.Name = "lblNetValue";
               lblNetValue.Size = new Size(73, 20);
               lblNetValue.TabIndex = 7;
               lblNetValue.Text = "Net Value";
               // 
               // lblPeriodLimitValue
               // 
               lblPeriodLimitValue.AutoSize = true;
               lblPeriodLimitValue.Location = new Point(140, 188);
               lblPeriodLimitValue.Name = "lblPeriodLimitValue";
               lblPeriodLimitValue.Size = new Size(88, 20);
               lblPeriodLimitValue.TabIndex = 8;
               lblPeriodLimitValue.Text = "Period Limit";
               // 
               // lblTotalRemaining
               // 
               lblTotalRemaining.AutoSize = true;
               lblTotalRemaining.Location = new Point(140, 239);
               lblTotalRemaining.Name = "lblTotalRemaining";
               lblTotalRemaining.Size = new Size(117, 20);
               lblTotalRemaining.TabIndex = 9;
               lblTotalRemaining.Text = "Total Remaining";
               // 
               // dgvCategoryBreakdown
               // 
               dgvCategoryBreakdown.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               dgvCategoryBreakdown.Location = new Point(636, 114);
               dgvCategoryBreakdown.Name = "dgvCategoryBreakdown";
               dgvCategoryBreakdown.RowHeadersWidth = 51;
               dgvCategoryBreakdown.Size = new Size(300, 188);
               dgvCategoryBreakdown.TabIndex = 10;
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Location = new Point(31, 188);
               label1.Name = "label1";
               label1.Size = new Size(91, 20);
               label1.TabIndex = 11;
               label1.Text = "Period Limit:";
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.Location = new Point(31, 150);
               label2.Name = "label2";
               label2.Size = new Size(76, 20);
               label2.TabIndex = 12;
               label2.Text = "Net Value:";
               // 
               // label3
               // 
               label3.AutoSize = true;
               label3.Location = new Point(31, 114);
               label3.Name = "label3";
               label3.Size = new Size(103, 20);
               label3.TabIndex = 13;
               label3.Text = "Total Expense:";
               // 
               // label4
               // 
               label4.AutoSize = true;
               label4.Location = new Point(31, 83);
               label4.Name = "label4";
               label4.Size = new Size(98, 20);
               label4.TabIndex = 14;
               label4.Text = "Total Income:";
               // 
               // label5
               // 
               label5.AutoSize = true;
               label5.Location = new Point(31, 239);
               label5.Name = "label5";
               label5.Size = new Size(89, 20);
               label5.TabIndex = 15;
               label5.Text = "Budget Left:";
               // 
               // MainMenuForm
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               BackColor = Color.Lavender;
               ClientSize = new Size(1118, 526);
               Controls.Add(label5);
               Controls.Add(label4);
               Controls.Add(label3);
               Controls.Add(label2);
               Controls.Add(label1);
               Controls.Add(dgvCategoryBreakdown);
               Controls.Add(lblTotalRemaining);
               Controls.Add(lblPeriodLimitValue);
               Controls.Add(lblNetValue);
               Controls.Add(lblTotalExpenseValue);
               Controls.Add(lblTotalIncomeValue);
               Controls.Add(cboPeriod);
               Controls.Add(btnCategoryBudgets);
               Controls.Add(btnPeriodBudgets);
               Controls.Add(btnTransactions);
               Controls.Add(btnCategories);
               Name = "MainMenuForm";
               Text = "Main Menu";
               Load += MainMenuForm_Load;
               ((System.ComponentModel.ISupportInitialize)dgvCategoryBreakdown).EndInit();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Button btnCategories;
          private Button btnTransactions;
          private Button btnPeriodBudgets;
          private Button btnCategoryBudgets;
          private ComboBox cboPeriod;
          private Label lblTotalIncomeValue;
          private Label lblTotalExpenseValue;
          private Label lblNetValue;
          private Label lblPeriodLimitValue;
          private Label lblTotalRemaining;
          private DataGridView dgvCategoryBreakdown;
          private Label label1;
          private Label label2;
          private Label label3;
          private Label label4;
          private Label label5;
     }
}