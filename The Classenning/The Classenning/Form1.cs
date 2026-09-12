using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace The_Classenning
{
    public partial class Form1 : Form
    {


        // Make a refference for bank account object
        BankAccount account;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string customerName = string.Empty;
            decimal balance = 0m;

            // Input name and balance
            try
            {
                customerName = txtName.Text;
                balance = decimal.Parse(txtInitialBalance.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid entries");
                return;
            }

            // Creat bank account object
            account = new BankAccount(customerName, balance);

        }

        private void btnDisplayBalance_Click(object sender, EventArgs e)
        {
            decimal accountBalance = account.Balance;
            OutputDisplay(txtOutput, "Account Balance: £", accountBalance);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            account.MakeDeposit(decimal.Parse(txtDepositAmount.Text));
            decimal accountBalance = account.Balance;
            OutputDisplay(txtOutput, "Deposit Made - \r\n\t New Balance: £", accountBalance);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            account.MakeWithdraw(decimal.Parse(txtWithdrawAmount.Text));
            decimal accountBalance = account.Balance;
            OutputDisplay(txtOutput, "Withdrawl Made - \r\n\t New Balance: £", accountBalance);
        }

        private void OutputDisplay(TextBox output, string message = "", object value = null)
        {
            output.Text = $"Account Name: {account.AccountName}\r\n{message}{value}";
        }
    }

}
