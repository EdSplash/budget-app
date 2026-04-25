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
               txtCategoryName = new TextBox();
               rbIncome = new RadioButton();
               rbExpense = new RadioButton();
               lblCategoryType = new Label();
               btnAddCategory = new Button();
               lstCategories = new ListBox();
               btnDeleteCategory = new Button();
               btnEditCategory = new Button();
               SuspendLayout();
               // 
               // txtCategoryName
               // 
               txtCategoryName.Location = new Point(313, 119);
               txtCategoryName.Margin = new Padding(3, 4, 3, 4);
               txtCategoryName.Name = "txtCategoryName";
               txtCategoryName.Size = new Size(153, 27);
               txtCategoryName.TabIndex = 0;
               txtCategoryName.Text = "Enter Category";
               txtCategoryName.TextAlign = HorizontalAlignment.Center;
               // 
               // rbIncome
               // 
               rbIncome.AutoSize = true;
               rbIncome.Location = new Point(313, 198);
               rbIncome.Margin = new Padding(3, 4, 3, 4);
               rbIncome.Name = "rbIncome";
               rbIncome.Size = new Size(79, 24);
               rbIncome.TabIndex = 1;
               rbIncome.TabStop = true;
               rbIncome.Text = "Income";
               rbIncome.UseVisualStyleBackColor = true;
               // 
               // rbExpense
               // 
               rbExpense.AutoSize = true;
               rbExpense.Location = new Point(391, 198);
               rbExpense.Margin = new Padding(3, 4, 3, 4);
               rbExpense.Name = "rbExpense";
               rbExpense.Size = new Size(84, 24);
               rbExpense.TabIndex = 2;
               rbExpense.TabStop = true;
               rbExpense.Text = "Expense";
               rbExpense.UseVisualStyleBackColor = true;
               // 
               // lblCategoryType
               // 
               lblCategoryType.AutoSize = true;
               lblCategoryType.Location = new Point(338, 174);
               lblCategoryType.Name = "lblCategoryType";
               lblCategoryType.Size = new Size(104, 20);
               lblCategoryType.TabIndex = 3;
               lblCategoryType.Text = "Category Type";
               // 
               // btnAddCategory
               // 
               btnAddCategory.Location = new Point(323, 230);
               btnAddCategory.Margin = new Padding(3, 4, 3, 4);
               btnAddCategory.Name = "btnAddCategory";
               btnAddCategory.Size = new Size(125, 38);
               btnAddCategory.TabIndex = 4;
               btnAddCategory.Text = "Add Category";
               btnAddCategory.UseVisualStyleBackColor = true;
               btnAddCategory.Click += btnAddCategory_Click;
               // 
               // lstCategories
               // 
               lstCategories.FormattingEnabled = true;
               lstCategories.Location = new Point(242, 319);
               lstCategories.Margin = new Padding(3, 4, 3, 4);
               lstCategories.Name = "lstCategories";
               lstCategories.Size = new Size(280, 164);
               lstCategories.TabIndex = 5;
               lstCategories.SelectedIndexChanged += lstCategories_SelectedIndexChanged;
               // 
               // btnDeleteCategory
               // 
               btnDeleteCategory.Location = new Point(252, 274);
               btnDeleteCategory.Margin = new Padding(3, 4, 3, 4);
               btnDeleteCategory.Name = "btnDeleteCategory";
               btnDeleteCategory.Size = new Size(125, 38);
               btnDeleteCategory.TabIndex = 6;
               btnDeleteCategory.Text = "Delete Category";
               btnDeleteCategory.UseVisualStyleBackColor = true;
               btnDeleteCategory.Click += btnDeleteCategory_Click;
               // 
               // btnEditCategory
               // 
               btnEditCategory.Location = new Point(379, 274);
               btnEditCategory.Margin = new Padding(3, 4, 3, 4);
               btnEditCategory.Name = "btnEditCategory";
               btnEditCategory.Size = new Size(125, 38);
               btnEditCategory.TabIndex = 7;
               btnEditCategory.Text = "Edit Category";
               btnEditCategory.UseVisualStyleBackColor = true;
               btnEditCategory.Click += btnEditCategory_Click;
               // 
               // CategoriesForm
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               BackColor = Color.Lavender;
               ClientSize = new Size(800, 562);
               Controls.Add(btnEditCategory);
               Controls.Add(btnDeleteCategory);
               Controls.Add(lstCategories);
               Controls.Add(btnAddCategory);
               Controls.Add(lblCategoryType);
               Controls.Add(rbExpense);
               Controls.Add(rbIncome);
               Controls.Add(txtCategoryName);
               Margin = new Padding(3, 4, 3, 4);
               Name = "CategoriesForm";
               Text = "Categories";
               Load += CategoriesForm_Load;
               ResumeLayout(false);
               PerformLayout();

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
     }
}

