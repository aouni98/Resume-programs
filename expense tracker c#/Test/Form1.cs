using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        Model1 database;
        public Form1()
        {
            InitializeComponent();
            database = new Model1();
            
        }
        public void UpdateCategories()
        {
            categoryComboBox.DataSource = null;
            categoryComboBox.DataSource = database.Categories.Local;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.Refresh();
            budgetComboBox.DataSource = null;
            budgetComboBox.DataSource = database.Categories.Local;
            budgetComboBox.DisplayMember = "Name";
            budgetComboBox.ValueMember = "Id";
            budgetComboBox.Refresh();
            budgetcatgorycomboBox.DataSource = null;
            budgetcatgorycomboBox.DataSource = database.Categories.Local;
            budgetcatgorycomboBox.DisplayMember = "Name";
            budgetcatgorycomboBox.ValueMember = "Id";
            budgetcatgorycomboBox.Refresh();

        }
        public void UpdateAccounts()
        {
            accountComboBox.DataSource = null;
            accountComboBox.DataSource = database.Accounts.Local;
            accountComboBox.DisplayMember = "Name";
            accountComboBox.ValueMember = "Id";
            accountComboBox.Refresh();
            accountvisualcomboBox.DataSource = null;
            accountvisualcomboBox.DataSource = database.Accounts.Local;
            accountvisualcomboBox.DisplayMember = "Name";
            accountvisualcomboBox.ValueMember = "Id";
            accountvisualcomboBox.Refresh();
        }
        private void AddNewCategoryButton_Click(object sender, EventArgs e)
        {
            Category categoryToAdd = new Category()
            {
                Name = categoryNameTextBox.Text,
                Amount = 0,
                Type = categoryTypeChoiceBox.Text,
                Budget = Int32.Parse(categoryBudget.Text)
            };
            if(categoryTypeChoiceBox.Text == "Expense")
            {
                categoryToAdd.Amount = categoryToAdd.Budget;
            }
            database.Categories.Add(categoryToAdd);
           
            database.SaveChanges();
            
            
            
           
            UpdateCategories();


        }

        private void addNewAccount_Click(object sender, EventArgs e)
        {
            Account AccountToAdd = new Account()
            {
                Name = accountNameText.Text,
                Amount = Int32.Parse(startingAmountText.Text)
            };

            database.Accounts.Add(AccountToAdd);

            database.SaveChanges();




            UpdateAccounts();
        }

        private void addSubmit_Click(object sender, EventArgs e)
        {
            var cat = categoryComboBox.SelectedItem as Category;
            if (cat.Type == "Income")
            {
                var accountSelected = accountComboBox.SelectedItem as Account;
                int location = accountSelected.Id - 1;
                database.Accounts.Local[location].Amount += Int32.Parse(amountTextBox.Text);
                location = cat.ID - 1;
                database.Categories.Local[location].Amount += Int32.Parse(amountTextBox.Text);

            }
            if (cat.Type == "Expense")
            {
                var accountSelected = accountComboBox.SelectedItem as Account;
                int location = accountSelected.Id - 1;
                database.Accounts.Local[location].Amount -= Int32.Parse(amountTextBox.Text);
                location = cat.ID - 1;
                database.Categories.Local[location].Amount -= Int32.Parse(amountTextBox.Text);
                
            }
        }

        private void budgetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BudgetSubmit_Click(object sender, EventArgs e)
        {
            var cat = budgetComboBox.SelectedItem as Category;
            int location = cat.ID - 1;
            if(database.Categories.Local[location].Budget <= Int32.Parse(Budgetinput.Text) && database.Categories.Local[location].Type == "Expense")
            {
                database.Categories.Local[location].Amount += Int32.Parse(Budgetinput.Text) - database.Categories.Local[location].Budget;
                database.Categories.Local[location].Budget = Int32.Parse(Budgetinput.Text);
            }
            else if(database.Categories.Local[location].Type == "Expense")
            {
                database.Categories.Local[location].Amount -= database.Categories.Local[location].Budget - Int32.Parse(Budgetinput.Text);
                database.Categories.Local[location].Budget = Int32.Parse(Budgetinput.Text);
            }
            else if (database.Categories.Local[location]. Budget <= Int32.Parse(Budgetinput.Text) && database.Categories.Local[location].Type == "Income")
            {
                database.Categories.Local[location].Budget = Int32.Parse(Budgetinput.Text);
            }
            else
            { 
                database.Categories.Local[location].Budget = Int32.Parse(Budgetinput.Text);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void budgetcatgorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cat = budgetcatgorycomboBox.SelectedItem as Category;
            if(cat != null && cat.Type == "Income")
            {
                label6.Text = "Amount Earned:";
                label7.Text = cat.Budget.ToString();
                label8.Text = cat.Amount.ToString();
                budgetprogressBar.Maximum = cat.Budget;
                if (cat.Amount >= cat.Budget)
                {
                    budgetprogressBar.Value = cat.Budget;
                    colorBox.BackColor = Color.Blue;
                    colorBox.Visible = true;
                }
                else 
                {
                    budgetprogressBar.Value = cat.Amount;
                    colorBox.Visible = false;
                }
            }
            else if( cat != null)
            {
                label6.Text = "Amount Left";
                label7.Text = cat.Budget.ToString();
                label8.Text = cat.Amount.ToString();
                budgetprogressBar.Maximum = cat.Budget;
                if (cat.Amount <= 0)
                {
                    budgetprogressBar.Value = cat.Budget;
                    colorBox.BackColor = Color.Red;
                    colorBox.Visible = true;
                }
                else
                {
                    budgetprogressBar.Value = cat.Budget -  cat.Amount;
                    colorBox.Visible = false;
                }

            }
            //var cat = budgetcatgorycomboBox.SelectedItem as Category;
            //int location = cat.ID - 1;
            //label7.Text = cat.Budget.ToString();
            //label8.Text = (cat.Amount).ToString();
            //budgetprogressBar.Maximum = cat.Budget;
            //budgetprogressBar.Value = cat.Budget - cat.Amount;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void accountvisualcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var account = accountvisualcomboBox.SelectedItem as Account;
            if (account != null)
            {
                label9.Text = account.Amount.ToString();
            }
        }

        private void AddInputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
