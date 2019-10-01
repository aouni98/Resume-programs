namespace Test
{
    partial class Form1
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
            this.AddNewCategoryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryTypeChoiceBox = new System.Windows.Forms.ComboBox();
            this.categoryBudget = new System.Windows.Forms.TextBox();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.addSubmit = new System.Windows.Forms.Button();
            this.addLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.addNewAccount = new System.Windows.Forms.Button();
            this.addAccountLabel = new System.Windows.Forms.Label();
            this.addAccountInputLabel = new System.Windows.Forms.Label();
            this.startingAmountText = new System.Windows.Forms.TextBox();
            this.accountNameText = new System.Windows.Forms.TextBox();
            this.ListOfBudgets = new System.Windows.Forms.Label();
            this.BudgetSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Budgetinput = new System.Windows.Forms.TextBox();
            this.budgetprogressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.budgetcatgorycomboBox = new System.Windows.Forms.ComboBox();
            this.budgetComboBox = new System.Windows.Forms.ComboBox();
            this.accountvisualcomboBox = new System.Windows.Forms.ComboBox();
            this.AddInputLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewCategoryButton
            // 
            this.AddNewCategoryButton.Location = new System.Drawing.Point(1141, 201);
            this.AddNewCategoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddNewCategoryButton.Name = "AddNewCategoryButton";
            this.AddNewCategoryButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddNewCategoryButton.Size = new System.Drawing.Size(100, 28);
            this.AddNewCategoryButton.TabIndex = 10;
            this.AddNewCategoryButton.Text = "Submit";
            this.AddNewCategoryButton.UseVisualStyleBackColor = true;
            this.AddNewCategoryButton.Click += new System.EventHandler(this.AddNewCategoryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1139, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Add new category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1009, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 85);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category Name:\r\n\r\nCategory Type:\r\n\r\nCategory Budget:\r\n";
            // 
            // categoryTypeChoiceBox
            // 
            this.categoryTypeChoiceBox.FormattingEnabled = true;
            this.categoryTypeChoiceBox.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.categoryTypeChoiceBox.Location = new System.Drawing.Point(1141, 135);
            this.categoryTypeChoiceBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoryTypeChoiceBox.Name = "categoryTypeChoiceBox";
            this.categoryTypeChoiceBox.Size = new System.Drawing.Size(221, 24);
            this.categoryTypeChoiceBox.TabIndex = 7;
            // 
            // categoryBudget
            // 
            this.categoryBudget.Location = new System.Drawing.Point(1141, 169);
            this.categoryBudget.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoryBudget.Name = "categoryBudget";
            this.categoryBudget.Size = new System.Drawing.Size(221, 22);
            this.categoryBudget.TabIndex = 5;
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(1141, 103);
            this.categoryNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(221, 22);
            this.categoryNameTextBox.TabIndex = 6;
            // 
            // addSubmit
            // 
            this.addSubmit.Location = new System.Drawing.Point(160, 266);
            this.addSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addSubmit.Name = "addSubmit";
            this.addSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addSubmit.Size = new System.Drawing.Size(100, 28);
            this.addSubmit.TabIndex = 16;
            this.addSubmit.Text = "Submit";
            this.addSubmit.UseVisualStyleBackColor = true;
            this.addSubmit.Click += new System.EventHandler(this.addSubmit_Click);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Location = new System.Drawing.Point(156, 69);
            this.addLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(132, 17);
            this.addLabel.TabIndex = 15;
            this.addLabel.Text = "Add Expese/Income\r\n";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(159, 102);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(223, 22);
            this.amountTextBox.TabIndex = 17;
            // 
            // memoTextBox
            // 
            this.memoTextBox.Location = new System.Drawing.Point(159, 169);
            this.memoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(221, 22);
            this.memoTextBox.TabIndex = 18;
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.accountComboBox.Location = new System.Drawing.Point(159, 203);
            this.accountComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(221, 24);
            this.accountComboBox.TabIndex = 19;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(161, 235);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(220, 22);
            this.datePicker.TabIndex = 20;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(159, 137);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(221, 24);
            this.categoryComboBox.TabIndex = 21;
            // 
            // addNewAccount
            // 
            this.addNewAccount.Location = new System.Drawing.Point(560, 169);
            this.addNewAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addNewAccount.Name = "addNewAccount";
            this.addNewAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addNewAccount.Size = new System.Drawing.Size(100, 28);
            this.addNewAccount.TabIndex = 27;
            this.addNewAccount.Text = "Submit";
            this.addNewAccount.UseVisualStyleBackColor = true;
            this.addNewAccount.Click += new System.EventHandler(this.addNewAccount_Click);
            // 
            // addAccountLabel
            // 
            this.addAccountLabel.AutoSize = true;
            this.addAccountLabel.Location = new System.Drawing.Point(557, 68);
            this.addAccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addAccountLabel.Name = "addAccountLabel";
            this.addAccountLabel.Size = new System.Drawing.Size(119, 17);
            this.addAccountLabel.TabIndex = 26;
            this.addAccountLabel.Text = "Add New Account";
            // 
            // addAccountInputLabel
            // 
            this.addAccountInputLabel.AutoSize = true;
            this.addAccountInputLabel.Location = new System.Drawing.Point(427, 107);
            this.addAccountInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addAccountInputLabel.Name = "addAccountInputLabel";
            this.addAccountInputLabel.Size = new System.Drawing.Size(113, 51);
            this.addAccountInputLabel.TabIndex = 25;
            this.addAccountInputLabel.Text = "Account Name:\r\n\r\nStarting Amount:\r\n";
            // 
            // startingAmountText
            // 
            this.startingAmountText.Location = new System.Drawing.Point(560, 137);
            this.startingAmountText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startingAmountText.Name = "startingAmountText";
            this.startingAmountText.Size = new System.Drawing.Size(221, 22);
            this.startingAmountText.TabIndex = 22;
            // 
            // accountNameText
            // 
            this.accountNameText.Location = new System.Drawing.Point(560, 103);
            this.accountNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountNameText.Name = "accountNameText";
            this.accountNameText.Size = new System.Drawing.Size(221, 22);
            this.accountNameText.TabIndex = 23;
            // 
            // ListOfBudgets
            // 
            this.ListOfBudgets.AutoSize = true;
            this.ListOfBudgets.Location = new System.Drawing.Point(959, 306);
            this.ListOfBudgets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ListOfBudgets.Name = "ListOfBudgets";
            this.ListOfBudgets.Size = new System.Drawing.Size(118, 51);
            this.ListOfBudgets.TabIndex = 28;
            this.ListOfBudgets.Text = "Account:\r\n\r\nAccount Balance:";
            // 
            // BudgetSubmit
            // 
            this.BudgetSubmit.Location = new System.Drawing.Point(160, 459);
            this.BudgetSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BudgetSubmit.Name = "BudgetSubmit";
            this.BudgetSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BudgetSubmit.Size = new System.Drawing.Size(100, 28);
            this.BudgetSubmit.TabIndex = 33;
            this.BudgetSubmit.Text = "Submit";
            this.BudgetSubmit.UseVisualStyleBackColor = true;
            this.BudgetSubmit.Click += new System.EventHandler(this.BudgetSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 358);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Set Budget";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 398);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 51);
            this.label5.TabIndex = 31;
            this.label5.Text = "Category:\r\n\r\nBudget Limit:\r\n";
            // 
            // Budgetinput
            // 
            this.Budgetinput.Location = new System.Drawing.Point(160, 427);
            this.Budgetinput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Budgetinput.Name = "Budgetinput";
            this.Budgetinput.Size = new System.Drawing.Size(221, 22);
            this.Budgetinput.TabIndex = 29;
            // 
            // budgetprogressBar
            // 
            this.budgetprogressBar.Location = new System.Drawing.Point(504, 425);
            this.budgetprogressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.budgetprogressBar.Name = "budgetprogressBar";
            this.budgetprogressBar.Size = new System.Drawing.Size(395, 23);
            this.budgetprogressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.budgetprogressBar.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 51);
            this.label3.TabIndex = 36;
            this.label3.Text = "Budget:\r\n\r\nBudget Limit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(630, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(630, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1099, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "label9";
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.colorBox.Location = new System.Drawing.Point(504, 425);
            this.colorBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(393, 22);
            this.colorBox.TabIndex = 45;
            this.colorBox.Visible = false;
            // 
            // budgetcatgorycomboBox
            // 
            this.budgetcatgorycomboBox.FormattingEnabled = true;
            this.budgetcatgorycomboBox.Location = new System.Drawing.Point(633, 306);
            this.budgetcatgorycomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.budgetcatgorycomboBox.Name = "budgetcatgorycomboBox";
            this.budgetcatgorycomboBox.Size = new System.Drawing.Size(219, 24);
            this.budgetcatgorycomboBox.TabIndex = 46;
            this.budgetcatgorycomboBox.SelectedIndexChanged += new System.EventHandler(this.budgetcatgorycomboBox_SelectedIndexChanged);
            // 
            // budgetComboBox
            // 
            this.budgetComboBox.FormattingEnabled = true;
            this.budgetComboBox.Location = new System.Drawing.Point(161, 394);
            this.budgetComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.budgetComboBox.Name = "budgetComboBox";
            this.budgetComboBox.Size = new System.Drawing.Size(220, 24);
            this.budgetComboBox.TabIndex = 47;
            // 
            // accountvisualcomboBox
            // 
            this.accountvisualcomboBox.FormattingEnabled = true;
            this.accountvisualcomboBox.Location = new System.Drawing.Point(1103, 303);
            this.accountvisualcomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountvisualcomboBox.Name = "accountvisualcomboBox";
            this.accountvisualcomboBox.Size = new System.Drawing.Size(199, 24);
            this.accountvisualcomboBox.TabIndex = 48;
            this.accountvisualcomboBox.SelectedIndexChanged += new System.EventHandler(this.accountvisualcomboBox_SelectedIndexChanged);
            // 
            // AddInputLabel
            // 
            this.AddInputLabel.AutoSize = true;
            this.AddInputLabel.Location = new System.Drawing.Point(84, 107);
            this.AddInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddInputLabel.Name = "AddInputLabel";
            this.AddInputLabel.Size = new System.Drawing.Size(69, 153);
            this.AddInputLabel.TabIndex = 14;
            this.AddInputLabel.Text = "Amount:\r\n\r\nCategory:\r\n\r\nMemo:\r\n\r\nAccount:\r\n\r\nDate:\r\n";
            this.AddInputLabel.Click += new System.EventHandler(this.AddInputLabel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 375);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Amount Left:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 687);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.accountvisualcomboBox);
            this.Controls.Add(this.budgetComboBox);
            this.Controls.Add(this.budgetcatgorycomboBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.budgetprogressBar);
            this.Controls.Add(this.BudgetSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Budgetinput);
            this.Controls.Add(this.ListOfBudgets);
            this.Controls.Add(this.addNewAccount);
            this.Controls.Add(this.addAccountLabel);
            this.Controls.Add(this.addAccountInputLabel);
            this.Controls.Add(this.startingAmountText);
            this.Controls.Add(this.accountNameText);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.memoTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.addSubmit);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.AddInputLabel);
            this.Controls.Add(this.AddNewCategoryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryTypeChoiceBox);
            this.Controls.Add(this.categoryBudget);
            this.Controls.Add(this.categoryNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewCategoryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryTypeChoiceBox;
        private System.Windows.Forms.TextBox categoryBudget;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Button addSubmit;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox memoTextBox;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button addNewAccount;
        private System.Windows.Forms.Label addAccountLabel;
        private System.Windows.Forms.Label addAccountInputLabel;
        private System.Windows.Forms.TextBox startingAmountText;
        private System.Windows.Forms.TextBox accountNameText;
        private System.Windows.Forms.Label ListOfBudgets;
        private System.Windows.Forms.Button BudgetSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Budgetinput;
        private System.Windows.Forms.ProgressBar budgetprogressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.ComboBox budgetcatgorycomboBox;
        private System.Windows.Forms.ComboBox budgetComboBox;
        private System.Windows.Forms.ComboBox accountvisualcomboBox;
        private System.Windows.Forms.Label AddInputLabel;
        private System.Windows.Forms.Label label6;
    }
}

