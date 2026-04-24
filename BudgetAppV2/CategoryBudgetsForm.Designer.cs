namespace BudgetAppV2
{
     partial class CategoryBudgetsForm
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
               this.cboCategories = new System.Windows.Forms.ComboBox();
               this.cboPeriodBudgets = new System.Windows.Forms.ComboBox();
               this.nudLimitAmount = new System.Windows.Forms.NumericUpDown();
               this.btnAddCategoryBudget = new System.Windows.Forms.Button();
               this.lstCategoryBudget = new System.Windows.Forms.ListBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.btnCategories = new System.Windows.Forms.Button();
               this.btnTransactions = new System.Windows.Forms.Button();
               this.btnPeriodBudgets = new System.Windows.Forms.Button();
               this.lblLimit = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.nudLimitAmount)).BeginInit();
               this.SuspendLayout();
               // 
               // cboCategories
               // 
               this.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.cboCategories.FormattingEnabled = true;
               this.cboCategories.Location = new System.Drawing.Point(230, 118);
               this.cboCategories.Name = "cboCategories";
               this.cboCategories.Size = new System.Drawing.Size(121, 24);
               this.cboCategories.TabIndex = 0;
               // 
               // cboPeriodBudgets
               // 
               this.cboPeriodBudgets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.cboPeriodBudgets.FormattingEnabled = true;
               this.cboPeriodBudgets.Location = new System.Drawing.Point(230, 173);
               this.cboPeriodBudgets.Name = "cboPeriodBudgets";
               this.cboPeriodBudgets.Size = new System.Drawing.Size(121, 24);
               this.cboPeriodBudgets.TabIndex = 1;
               // 
               // nudLimitAmount
               // 
               this.nudLimitAmount.DecimalPlaces = 2;
               this.nudLimitAmount.Location = new System.Drawing.Point(231, 231);
               this.nudLimitAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
               this.nudLimitAmount.Name = "nudLimitAmount";
               this.nudLimitAmount.Size = new System.Drawing.Size(120, 22);
               this.nudLimitAmount.TabIndex = 2;
               // 
               // btnAddCategoryBudget
               // 
               this.btnAddCategoryBudget.Location = new System.Drawing.Point(220, 269);
               this.btnAddCategoryBudget.Name = "btnAddCategoryBudget";
               this.btnAddCategoryBudget.Size = new System.Drawing.Size(152, 28);
               this.btnAddCategoryBudget.TabIndex = 3;
               this.btnAddCategoryBudget.Text = "Add Category Budget";
               this.btnAddCategoryBudget.UseVisualStyleBackColor = true;
               this.btnAddCategoryBudget.Click += new System.EventHandler(this.btnAddCategoryBudget_Click);
               // 
               // lstCategoryBudget
               // 
               this.lstCategoryBudget.FormattingEnabled = true;
               this.lstCategoryBudget.ItemHeight = 16;
               this.lstCategoryBudget.Location = new System.Drawing.Point(447, 118);
               this.lstCategoryBudget.Name = "lstCategoryBudget";
               this.lstCategoryBudget.Size = new System.Drawing.Size(270, 212);
               this.lstCategoryBudget.TabIndex = 4;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(164, 118);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(62, 16);
               this.label1.TabIndex = 5;
               this.label1.Text = "Category";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(164, 176);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(47, 16);
               this.label2.TabIndex = 6;
               this.label2.Text = "Period";
               // 
               // btnCategories
               // 
               this.btnCategories.Location = new System.Drawing.Point(12, 35);
               this.btnCategories.Name = "btnCategories";
               this.btnCategories.Size = new System.Drawing.Size(125, 30);
               this.btnCategories.TabIndex = 7;
               this.btnCategories.Text = "Categories";
               this.btnCategories.UseVisualStyleBackColor = true;
               this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
               // 
               // btnTransactions
               // 
               this.btnTransactions.Location = new System.Drawing.Point(12, 71);
               this.btnTransactions.Name = "btnTransactions";
               this.btnTransactions.Size = new System.Drawing.Size(125, 30);
               this.btnTransactions.TabIndex = 8;
               this.btnTransactions.Text = "Transactions";
               this.btnTransactions.UseVisualStyleBackColor = true;
               this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
               // 
               // btnPeriodBudgets
               // 
               this.btnPeriodBudgets.Location = new System.Drawing.Point(12, 102);
               this.btnPeriodBudgets.Name = "btnPeriodBudgets";
               this.btnPeriodBudgets.Size = new System.Drawing.Size(125, 30);
               this.btnPeriodBudgets.TabIndex = 9;
               this.btnPeriodBudgets.Text = "Period Budgets";
               this.btnPeriodBudgets.UseVisualStyleBackColor = true;
               this.btnPeriodBudgets.Click += new System.EventHandler(this.btnPeriodBudgets_Click);
               // 
               // lblLimit
               // 
               this.lblLimit.AutoSize = true;
               this.lblLimit.Location = new System.Drawing.Point(167, 231);
               this.lblLimit.Name = "lblLimit";
               this.lblLimit.Size = new System.Drawing.Size(34, 16);
               this.lblLimit.TabIndex = 10;
               this.lblLimit.Text = "Limit";
               // 
               // CategoryBudgetsForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.lblLimit);
               this.Controls.Add(this.btnPeriodBudgets);
               this.Controls.Add(this.btnTransactions);
               this.Controls.Add(this.btnCategories);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.lstCategoryBudget);
               this.Controls.Add(this.btnAddCategoryBudget);
               this.Controls.Add(this.nudLimitAmount);
               this.Controls.Add(this.cboPeriodBudgets);
               this.Controls.Add(this.cboCategories);
               this.Name = "CategoryBudgetsForm";
               this.Text = "CategoryBudgets";
               this.Load += new System.EventHandler(this.CategoryBudgetsForm_Load);
               ((System.ComponentModel.ISupportInitialize)(this.nudLimitAmount)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ComboBox cboCategories;
          private System.Windows.Forms.ComboBox cboPeriodBudgets;
          private System.Windows.Forms.NumericUpDown nudLimitAmount;
          private System.Windows.Forms.Button btnAddCategoryBudget;
          private System.Windows.Forms.ListBox lstCategoryBudget;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Button btnCategories;
          private System.Windows.Forms.Button btnTransactions;
          private System.Windows.Forms.Button btnPeriodBudgets;
          private System.Windows.Forms.Label lblLimit;
     }
}