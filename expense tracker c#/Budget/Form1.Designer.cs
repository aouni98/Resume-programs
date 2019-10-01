namespace Budget
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
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryBudget = new System.Windows.Forms.TextBox();
            this.categoryTypeChoiceBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddNewCategoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(571, 78);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.categoryNameTextBox.TabIndex = 0;
            // 
            // categoryBudget
            // 
            this.categoryBudget.Location = new System.Drawing.Point(571, 131);
            this.categoryBudget.Name = "categoryBudget";
            this.categoryBudget.Size = new System.Drawing.Size(167, 20);
            this.categoryBudget.TabIndex = 0;
            // 
            // categoryTypeChoiceBox
            // 
            this.categoryTypeChoiceBox.FormattingEnabled = true;
            this.categoryTypeChoiceBox.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.categoryTypeChoiceBox.Location = new System.Drawing.Point(571, 104);
            this.categoryTypeChoiceBox.Name = "categoryTypeChoiceBox";
            this.categoryTypeChoiceBox.Size = new System.Drawing.Size(167, 21);
            this.categoryTypeChoiceBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category Name:\r\n\r\nCategory Type:\r\n\r\nCategory Budget:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add new category:";
            // 
            // AddNewCategoryButton
            // 
            this.AddNewCategoryButton.Location = new System.Drawing.Point(571, 157);
            this.AddNewCategoryButton.Name = "AddNewCategoryButton";
            this.AddNewCategoryButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddNewCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewCategoryButton.TabIndex = 4;
            this.AddNewCategoryButton.Text = "Submit";
            this.AddNewCategoryButton.UseVisualStyleBackColor = true;
            this.AddNewCategoryButton.Click += new System.EventHandler(this.AddNewCategoryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 487);
            this.Controls.Add(this.AddNewCategoryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryTypeChoiceBox);
            this.Controls.Add(this.categoryBudget);
            this.Controls.Add(this.categoryNameTextBox);
            this.Name = "Form1";
            this.Text = "Budget Boi Remastered - Redux Steamed Hams Edition XD Legacy of Darkness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.TextBox categoryBudget;
        private System.Windows.Forms.ComboBox categoryTypeChoiceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddNewCategoryButton;
    }
}

