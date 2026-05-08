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
               btnAddPeriodBudget = new Button();
               nudTotalLimit = new NumericUpDown();
               dtpPeriodStartDate = new DateTimePicker();
               dtpPeriodEndDate = new DateTimePicker();
               lstPeriodBudgets = new ListBox();
               lblStartDate = new Label();
               lblEndDate = new Label();
               lblTotalLimit = new Label();
               btnEditPB = new Button();
               btnDeletePB = new Button();
               ((System.ComponentModel.ISupportInitialize)nudTotalLimit).BeginInit();
               SuspendLayout();
               // 
               // btnAddPeriodBudget
               // 
               btnAddPeriodBudget.Location = new Point(56, 208);
               btnAddPeriodBudget.Margin = new Padding(3, 4, 3, 4);
               btnAddPeriodBudget.Name = "btnAddPeriodBudget";
               btnAddPeriodBudget.Size = new Size(179, 32);
               btnAddPeriodBudget.TabIndex = 0;
               btnAddPeriodBudget.Text = "Add Period Budget";
               btnAddPeriodBudget.UseVisualStyleBackColor = true;
               btnAddPeriodBudget.Click += btnAddPeriodBudget_Click;
               // 
               // nudTotalLimit
               // 
               nudTotalLimit.DecimalPlaces = 2;
               nudTotalLimit.Location = new Point(97, 38);
               nudTotalLimit.Margin = new Padding(3, 4, 3, 4);
               nudTotalLimit.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
               nudTotalLimit.Name = "nudTotalLimit";
               nudTotalLimit.Size = new Size(120, 27);
               nudTotalLimit.TabIndex = 2;
               // 
               // dtpPeriodStartDate
               // 
               dtpPeriodStartDate.Location = new Point(337, 38);
               dtpPeriodStartDate.Margin = new Padding(3, 4, 3, 4);
               dtpPeriodStartDate.Name = "dtpPeriodStartDate";
               dtpPeriodStartDate.Size = new Size(260, 27);
               dtpPeriodStartDate.TabIndex = 3;
               // 
               // dtpPeriodEndDate
               // 
               dtpPeriodEndDate.Location = new Point(337, 88);
               dtpPeriodEndDate.Margin = new Padding(3, 4, 3, 4);
               dtpPeriodEndDate.Name = "dtpPeriodEndDate";
               dtpPeriodEndDate.Size = new Size(260, 27);
               dtpPeriodEndDate.TabIndex = 4;
               // 
               // lstPeriodBudgets
               // 
               lstPeriodBudgets.FormattingEnabled = true;
               lstPeriodBudgets.Location = new Point(24, 248);
               lstPeriodBudgets.Margin = new Padding(3, 4, 3, 4);
               lstPeriodBudgets.Name = "lstPeriodBudgets";
               lstPeriodBudgets.Size = new Size(774, 244);
               lstPeriodBudgets.TabIndex = 5;
               lstPeriodBudgets.SelectedIndexChanged += lstPeriodBudgets_SelectedIndexChanged;
               // 
               // lblStartDate
               // 
               lblStartDate.AutoSize = true;
               lblStartDate.Location = new Point(255, 40);
               lblStartDate.Name = "lblStartDate";
               lblStartDate.Size = new Size(76, 20);
               lblStartDate.TabIndex = 11;
               lblStartDate.Text = "Start Date";
               // 
               // lblEndDate
               // 
               lblEndDate.AutoSize = true;
               lblEndDate.Location = new Point(261, 88);
               lblEndDate.Name = "lblEndDate";
               lblEndDate.Size = new Size(70, 20);
               lblEndDate.TabIndex = 12;
               lblEndDate.Text = "End Date";
               // 
               // lblTotalLimit
               // 
               lblTotalLimit.AutoSize = true;
               lblTotalLimit.Location = new Point(12, 38);
               lblTotalLimit.Name = "lblTotalLimit";
               lblTotalLimit.Size = new Size(79, 20);
               lblTotalLimit.TabIndex = 13;
               lblTotalLimit.Text = "Total Limit";
               // 
               // btnEditPB
               // 
               btnEditPB.Location = new Point(303, 208);
               btnEditPB.Name = "btnEditPB";
               btnEditPB.Size = new Size(179, 32);
               btnEditPB.TabIndex = 14;
               btnEditPB.Text = "Edit Period Budget";
               btnEditPB.UseVisualStyleBackColor = true;
               btnEditPB.Click += btnEditPB_Click;
               // 
               // btnDeletePB
               // 
               btnDeletePB.Location = new Point(548, 208);
               btnDeletePB.Name = "btnDeletePB";
               btnDeletePB.Size = new Size(179, 32);
               btnDeletePB.TabIndex = 15;
               btnDeletePB.Text = "Delete Period Budget";
               btnDeletePB.UseVisualStyleBackColor = true;
               btnDeletePB.Click += btnDeletePB_Click;
               // 
               // PeriodBudgetsForm
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               BackColor = Color.Lavender;
               ClientSize = new Size(800, 562);
               Controls.Add(btnDeletePB);
               Controls.Add(btnEditPB);
               Controls.Add(lblTotalLimit);
               Controls.Add(lblEndDate);
               Controls.Add(lblStartDate);
               Controls.Add(lstPeriodBudgets);
               Controls.Add(dtpPeriodEndDate);
               Controls.Add(dtpPeriodStartDate);
               Controls.Add(nudTotalLimit);
               Controls.Add(btnAddPeriodBudget);
               Margin = new Padding(3, 4, 3, 4);
               Name = "PeriodBudgetsForm";
               Text = "Period Budgets";
               Load += PeriodBudgetForm_Load;
               ((System.ComponentModel.ISupportInitialize)nudTotalLimit).EndInit();
               ResumeLayout(false);
               PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button btnAddPeriodBudget;
          private System.Windows.Forms.NumericUpDown nudTotalLimit;
          private System.Windows.Forms.DateTimePicker dtpPeriodStartDate;
          private System.Windows.Forms.DateTimePicker dtpPeriodEndDate;
          private System.Windows.Forms.ListBox lstPeriodBudgets;
          private System.Windows.Forms.Label lblStartDate;
          private System.Windows.Forms.Label lblEndDate;
          private System.Windows.Forms.Label lblTotalLimit;
          private Button btnEditPB;
          private Button btnDeletePB;
     }
}