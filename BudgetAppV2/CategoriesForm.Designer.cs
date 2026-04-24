namespace BudgetAppV2
{
     partial class CategoriesForm
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
               this.txtCategoryName = new System.Windows.Forms.TextBox();
               this.rbIncome = new System.Windows.Forms.RadioButton();
               this.rbExpense = new System.Windows.Forms.RadioButton();
               this.lblCategoryType = new System.Windows.Forms.Label();
               this.btnAddCategory = new System.Windows.Forms.Button();
               this.lstCategories = new System.Windows.Forms.ListBox();
               this.btnDeleteCategory = new System.Windows.Forms.Button();
               this.btnEditCategory = new System.Windows.Forms.Button();
               this.btnManageTransactions = new System.Windows.Forms.Button();
               this.btnPeriodBudget = new System.Windows.Forms.Button();
               this.btnCategoryBudgets = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // txtCategoryName
               // 
               this.txtCategoryName.Location = new System.Drawing.Point(313, 95);
               this.txtCategoryName.Name = "txtCategoryName";
               this.txtCategoryName.Size = new System.Drawing.Size(153, 22);
               this.txtCategoryName.TabIndex = 0;
               this.txtCategoryName.Text = "Enter Category";
               this.txtCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // rbIncome
               // 
               this.rbIncome.AutoSize = true;
               this.rbIncome.Location = new System.Drawing.Point(313, 158);
               this.rbIncome.Name = "rbIncome";
               this.rbIncome.Size = new System.Drawing.Size(72, 20);
               this.rbIncome.TabIndex = 1;
               this.rbIncome.TabStop = true;
               this.rbIncome.Text = "Income";
               this.rbIncome.UseVisualStyleBackColor = true;
               // 
               // rbExpense
               // 
               this.rbExpense.AutoSize = true;
               this.rbExpense.Location = new System.Drawing.Point(391, 158);
               this.rbExpense.Name = "rbExpense";
               this.rbExpense.Size = new System.Drawing.Size(81, 20);
               this.rbExpense.TabIndex = 2;
               this.rbExpense.TabStop = true;
               this.rbExpense.Text = "Expense";
               this.rbExpense.UseVisualStyleBackColor = true;
               // 
               // lblCategoryType
               // 
               this.lblCategoryType.AutoSize = true;
               this.lblCategoryType.Location = new System.Drawing.Point(338, 139);
               this.lblCategoryType.Name = "lblCategoryType";
               this.lblCategoryType.Size = new System.Drawing.Size(97, 16);
               this.lblCategoryType.TabIndex = 3;
               this.lblCategoryType.Text = "Category Type";
               // 
               // btnAddCategory
               // 
               this.btnAddCategory.Location = new System.Drawing.Point(323, 184);
               this.btnAddCategory.Name = "btnAddCategory";
               this.btnAddCategory.Size = new System.Drawing.Size(125, 30);
               this.btnAddCategory.TabIndex = 4;
               this.btnAddCategory.Text = "Add Category";
               this.btnAddCategory.UseVisualStyleBackColor = true;
               this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
               // 
               // lstCategories
               // 
               this.lstCategories.FormattingEnabled = true;
               this.lstCategories.ItemHeight = 16;
               this.lstCategories.Location = new System.Drawing.Point(242, 255);
               this.lstCategories.Name = "lstCategories";
               this.lstCategories.Size = new System.Drawing.Size(280, 132);
               this.lstCategories.TabIndex = 5;
               this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
               // 
               // btnDeleteCategory
               // 
               this.btnDeleteCategory.Location = new System.Drawing.Point(252, 219);
               this.btnDeleteCategory.Name = "btnDeleteCategory";
               this.btnDeleteCategory.Size = new System.Drawing.Size(125, 30);
               this.btnDeleteCategory.TabIndex = 6;
               this.btnDeleteCategory.Text = "Delete Category";
               this.btnDeleteCategory.UseVisualStyleBackColor = true;
               this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
               // 
               // btnEditCategory
               // 
               this.btnEditCategory.Location = new System.Drawing.Point(379, 219);
               this.btnEditCategory.Name = "btnEditCategory";
               this.btnEditCategory.Size = new System.Drawing.Size(125, 30);
               this.btnEditCategory.TabIndex = 7;
               this.btnEditCategory.Text = "Edit Category";
               this.btnEditCategory.UseVisualStyleBackColor = true;
               this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
               // 
               // btnManageTransactions
               // 
               
               this.btnManageTransactions.Location = new System.Drawing.Point(44, 30);
               this.btnManageTransactions.Name = "btnManageTransactions";
               this.btnManageTransactions.Size = new System.Drawing.Size(125, 30);
               this.btnManageTransactions.TabIndex = 8;
               this.btnManageTransactions.Text = "Transactions";
               this.btnManageTransactions.UseVisualStyleBackColor = true;
               this.btnManageTransactions.Click += new System.EventHandler(this.btnManageTransactions_Click);
               // 
               
               // btnPeriodBudget
               // 
               this.btnPeriodBudget.Location = new System.Drawing.Point(44, 71);
               this.btnPeriodBudget.Name = "btnPeriodBudget";
               this.btnPeriodBudget.Size = new System.Drawing.Size(125, 30);
               this.btnPeriodBudget.TabIndex = 11;
               this.btnPeriodBudget.Text = "PeriodBudget";
               this.btnPeriodBudget.UseVisualStyleBackColor = true;
               this.btnPeriodBudget.Click += new System.EventHandler(this.btnPeriodBudget_Click);
               // 
               
               // btnCategoryBudgets
               // 
               this.btnCategoryBudgets.Location = new System.Drawing.Point(44, 112);
               this.btnCategoryBudgets.Name = "btnCategoryBudgets";
               this.btnCategoryBudgets.Size = new System.Drawing.Size(125, 30);
               this.btnCategoryBudgets.TabIndex = 15;
               this.btnCategoryBudgets.Text = "Category Budgets";
               this.btnCategoryBudgets.UseVisualStyleBackColor = true;
               this.btnCategoryBudgets.Click += new System.EventHandler(this.btnCategoryBudgets_Click);
               
               // 
               // CategoriesForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.btnCategoryBudgets);
               this.Controls.Add(this.btnPeriodBudget);
               this.Controls.Add(this.btnManageTransactions);
               this.Controls.Add(this.btnEditCategory);
               this.Controls.Add(this.btnDeleteCategory);
               this.Controls.Add(this.lstCategories);
               this.Controls.Add(this.btnAddCategory);
               this.Controls.Add(this.lblCategoryType);
               this.Controls.Add(this.rbExpense);
               this.Controls.Add(this.rbIncome);
               this.Controls.Add(this.txtCategoryName);
               this.Name = "CategoriesForm";
               this.Text = "Categories";
               this.Load += new System.EventHandler(this.CategoriesForm_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox txtCategoryName;
          private System.Windows.Forms.RadioButton rbIncome;
          private System.Windows.Forms.RadioButton rbExpense;
          private System.Windows.Forms.Label lblCategoryType;
          private System.Windows.Forms.Button btnAddCategory;
          private System.Windows.Forms.ListBox lstCategories;
          private System.Windows.Forms.Button btnDeleteCategory;
          private System.Windows.Forms.Button btnEditCategory;
          private System.Windows.Forms.Button btnManageTransactions;
          private System.Windows.Forms.Button btnPeriodBudget;
          private System.Windows.Forms.Button btnCategoryBudgets;
     }
}

