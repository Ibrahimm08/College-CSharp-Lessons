using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Classenning
{
    internal class BankAccount
    {
        // Attributes
        public string AccountName { get; private set; }
        public decimal Balance { get; private set; }

        // Constructor
        public BankAccount(string accountName, decimal balance)
        {
            AccountName = accountName;
            Balance = balance;
        }

        // Methods
        public void MakeDeposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Cannot deposit a negative amount");
            }
            else
            {
                Balance += amount;
            }
        }

        public void MakeWithdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new Exception("Cannot withdraw more than balance");
            }
            else
            {
                Balance -= amount;
            }
        }

        public decimal getBalance()
        {
            return Balance;
        }

        public string getName()
        {
            return AccountName;
        }
    }
}
