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
               cboCategories = new ComboBox();
               cboPeriodBudgets = new ComboBox();
               nudLimitAmount = new NumericUpDown();
               btnAddCategoryBudget = new Button();
               lstCategoryBudget = new ListBox();
               label1 = new Label();
               label2 = new Label();
               lblLimit = new Label();
               btnDeleteCB = new Button();
               btnEditCB = new Button();
               ((System.ComponentModel.ISupportInitialize)nudLimitAmount).BeginInit();
               SuspendLayout();
               // 
               // cboCategories
               // 
               cboCategories.DropDownStyle = ComboBoxStyle.DropDownList;
               cboCategories.FormattingEnabled = true;
               cboCategories.Location = new Point(145, 156);
               cboCategories.Margin = new Padding(3, 4, 3, 4);
               cboCategories.Name = "cboCategories";
               cboCategories.Size = new Size(121, 28);
               cboCategories.TabIndex = 0;
               // 
               // cboPeriodBudgets
               // 
               cboPeriodBudgets.DropDownStyle = ComboBoxStyle.DropDownList;
               cboPeriodBudgets.FormattingEnabled = true;
               cboPeriodBudgets.Location = new Point(145, 224);
               cboPeriodBudgets.Margin = new Padding(3, 4, 3, 4);
               cboPeriodBudgets.Name = "cboPeriodBudgets";
               cboPeriodBudgets.Size = new Size(222, 28);
               cboPeriodBudgets.TabIndex = 1;
               // 
               // nudLimitAmount
               // 
               nudLimitAmount.DecimalPlaces = 2;
               nudLimitAmount.Location = new Point(146, 289);
               nudLimitAmount.Margin = new Padding(3, 4, 3, 4);
               nudLimitAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
               nudLimitAmount.Name = "nudLimitAmount";
               nudLimitAmount.Size = new Size(120, 27);
               nudLimitAmount.TabIndex = 2;
               // 
               // btnAddCategoryBudget
               // 
               btnAddCategoryBudget.Location = new Point(114, 356);
               btnAddCategoryBudget.Margin = new Padding(3, 4, 3, 4);
               btnAddCategoryBudget.Name = "btnAddCategoryBudget";
               btnAddCategoryBudget.Size = new Size(169, 35);
               btnAddCategoryBudget.TabIndex = 3;
               btnAddCategoryBudget.Text = "Add Category Budget";
               btnAddCategoryBudget.UseVisualStyleBackColor = true;
               btnAddCategoryBudget.Click += btnAddCategoryBudget_Click;
               // 
               // lstCategoryBudget
               // 
               lstCategoryBudget.FormattingEnabled = true;
               lstCategoryBudget.Location = new Point(423, 148);
               lstCategoryBudget.Margin = new Padding(3, 4, 3, 4);
               lstCategoryBudget.Name = "lstCategoryBudget";
               lstCategoryBudget.Size = new Size(371, 264);
               lstCategoryBudget.TabIndex = 4;
               lstCategoryBudget.SelectedIndexChanged += lstCategoryBudget_SelectedIndexChanged;
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Location = new Point(53, 156);
               label1.Name = "label1";
               label1.Size = new Size(69, 20);
               label1.TabIndex = 5;
               label1.Text = "Category";
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.Location = new Point(53, 224);
               label2.Name = "label2";
               label2.Size = new Size(51, 20);
               label2.TabIndex = 6;
               label2.Text = "Period";
               // 
               // lblLimit
               // 
               lblLimit.AutoSize = true;
               lblLimit.Location = new Point(53, 289);
               lblLimit.Name = "lblLimit";
               lblLimit.Size = new Size(42, 20);
               lblLimit.TabIndex = 10;
               lblLimit.Text = "Limit";
               // 
               // btnDeleteCB
               // 
               btnDeleteCB.Location = new Point(423, 425);
               btnDeleteCB.Name = "btnDeleteCB";
               btnDeleteCB.Size = new Size(178, 35);
               btnDeleteCB.TabIndex = 11;
               btnDeleteCB.Text = "Delete Category Budget";
               btnDeleteCB.UseVisualStyleBackColor = true;
               btnDeleteCB.Click += btnDeleteCB_Click;
               // 
               // btnEditCB
               // 
               btnEditCB.Location = new Point(607, 425);
               btnEditCB.Name = "btnEditCB";
               btnEditCB.Size = new Size(169, 35);
               btnEditCB.TabIndex = 12;
               btnEditCB.Text = "Edit Category Budget";
               btnEditCB.UseVisualStyleBackColor = true;
               btnEditCB.Click += btnEditCB_Click;
               // 
               // CategoryBudgetsForm
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               BackColor = Color.Lavender;
               ClientSize = new Size(800, 562);
               Controls.Add(btnEditCB);
               Controls.Add(btnDeleteCB);
               Controls.Add(lblLimit);
               Controls.Add(label2);
               Controls.Add(label1);
               Controls.Add(lstCategoryBudget);
               Controls.Add(btnAddCategoryBudget);
               Controls.Add(nudLimitAmount);
               Controls.Add(cboPeriodBudgets);
               Controls.Add(cboCategories);
               Margin = new Padding(3, 4, 3, 4);
               Name = "CategoryBudgetsForm";
               Text = "CategoryBudgets";
               Load += CategoryBudgetsForm_Load;
               ((System.ComponentModel.ISupportInitialize)nudLimitAmount).EndInit();
               ResumeLayout(false);
               PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ComboBox cboCategories;
          private System.Windows.Forms.ComboBox cboPeriodBudgets;
          private System.Windows.Forms.NumericUpDown nudLimitAmount;
          private System.Windows.Forms.Button btnAddCategoryBudget;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label lblLimit;
          private Button btnDeleteCB;
          private Button btnEditCB;
          private ListBox lstCategoryBudget;
     }
}