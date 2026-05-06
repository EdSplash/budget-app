namespace BudgetAppV2
{
     partial class TransactionsForm
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
               nudAmount = new NumericUpDown();
               dtpTransactionDate = new DateTimePicker();
               lstTransactions = new ListBox();
               cboCategories = new ComboBox();
               btnAddTransaction = new Button();
               txtDescription = new TextBox();
               lblAmount = new Label();
               lblDate = new Label();
               lblCategory = new Label();
               ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
               SuspendLayout();
               // 
               // nudAmount
               // 
               nudAmount.DecimalPlaces = 2;
               nudAmount.Location = new Point(107, 68);
               nudAmount.Margin = new Padding(3, 4, 3, 4);
               nudAmount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
               nudAmount.Name = "nudAmount";
               nudAmount.Size = new Size(120, 27);
               nudAmount.TabIndex = 0;
               // 
               // dtpTransactionDate
               // 
               dtpTransactionDate.Location = new Point(515, 68);
               dtpTransactionDate.Margin = new Padding(3, 4, 3, 4);
               dtpTransactionDate.Name = "dtpTransactionDate";
               dtpTransactionDate.Size = new Size(262, 27);
               dtpTransactionDate.TabIndex = 1;
               // 
               // lstTransactions
               // 
               lstTransactions.FormattingEnabled = true;
               lstTransactions.Location = new Point(59, 258);
               lstTransactions.Margin = new Padding(3, 4, 3, 4);
               lstTransactions.Name = "lstTransactions";
               lstTransactions.Size = new Size(695, 244);
               lstTransactions.TabIndex = 2;
               // 
               // cboCategories
               // 
               cboCategories.DropDownStyle = ComboBoxStyle.DropDownList;
               cboCategories.FormattingEnabled = true;
               cboCategories.Location = new Point(322, 67);
               cboCategories.Margin = new Padding(3, 4, 3, 4);
               cboCategories.Name = "cboCategories";
               cboCategories.Size = new Size(138, 28);
               cboCategories.TabIndex = 3;
               // 
               // btnAddTransaction
               // 
               btnAddTransaction.Location = new Point(135, 211);
               btnAddTransaction.Margin = new Padding(3, 4, 3, 4);
               btnAddTransaction.Name = "btnAddTransaction";
               btnAddTransaction.Size = new Size(137, 39);
               btnAddTransaction.TabIndex = 4;
               btnAddTransaction.Text = "Add Transaction";
               btnAddTransaction.UseVisualStyleBackColor = true;
               btnAddTransaction.Click += btnAddTransaction_Click;
               // 
               // txtDescription
               // 
               txtDescription.Location = new Point(205, 103);
               txtDescription.Margin = new Padding(3, 4, 3, 4);
               txtDescription.Multiline = true;
               txtDescription.Name = "txtDescription";
               txtDescription.Size = new Size(372, 54);
               txtDescription.TabIndex = 5;
               txtDescription.Text = "Enter Description";
               // 
               // lblAmount
               // 
               lblAmount.AutoSize = true;
               lblAmount.Location = new Point(36, 68);
               lblAmount.Name = "lblAmount";
               lblAmount.Size = new Size(65, 20);
               lblAmount.TabIndex = 6;
               lblAmount.Text = "Amount:";
               lblAmount.Click += lblAmount_Click;
               // 
               // lblDate
               // 
               lblDate.AutoSize = true;
               lblDate.Location = new Point(466, 70);
               lblDate.Name = "lblDate";
               lblDate.Size = new Size(44, 20);
               lblDate.TabIndex = 7;
               lblDate.Text = "Date:";
               // 
               // lblCategory
               // 
               lblCategory.AutoSize = true;
               lblCategory.Location = new Point(244, 70);
               lblCategory.Name = "lblCategory";
               lblCategory.Size = new Size(72, 20);
               lblCategory.TabIndex = 8;
               lblCategory.Text = "Category:";
               // 
               // TransactionsForm
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               BackColor = Color.Lavender;
               ClientSize = new Size(800, 562);
               Controls.Add(lblCategory);
               Controls.Add(lblDate);
               Controls.Add(lblAmount);
               Controls.Add(txtDescription);
               Controls.Add(btnAddTransaction);
               Controls.Add(cboCategories);
               Controls.Add(lstTransactions);
               Controls.Add(dtpTransactionDate);
               Controls.Add(nudAmount);
               Margin = new Padding(3, 4, 3, 4);
               Name = "TransactionsForm";
               Text = "Transactions";
               Load += TransactionsForm_Load;
               ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
               ResumeLayout(false);
               PerformLayout();

          }

          #endregion

          private System.Windows.Forms.NumericUpDown nudAmount;
          private System.Windows.Forms.DateTimePicker dtpTransactionDate;
          private System.Windows.Forms.ListBox lstTransactions;
          private System.Windows.Forms.ComboBox cboCategories;
          private System.Windows.Forms.Button btnAddTransaction;
          private System.Windows.Forms.TextBox txtDescription;
          private System.Windows.Forms.Label lblAmount;
          private System.Windows.Forms.Label lblDate;
          private System.Windows.Forms.Label lblCategory;
     }
}