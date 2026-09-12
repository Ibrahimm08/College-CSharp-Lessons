using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Calculating
{
    public partial class Calculator : Form
    {
        Calc clac;
        bool numberFlag = false;
        string operation, num1, num2;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            // Gets the text of the button containing a number
            string number = (sender as Button).Text;

            // Checks if it should enter 1st or 2nd number
            if (numberFlag)
            {
                num2 += number;
            }
            else
            {
                num1 += number;
            }
            updateDisplay();
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            // Gets symbol as string and assigns it
            string symbol = (sender as Button).Text;
            operation = symbol;

            // Allows the entery of the seccond number
            numberFlag = true;
            updateDisplay();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
            clac = new Calc(num1, num2, operation);
            float result = clac.calculate();
            txtDisplay.Text = result.ToString();
            }
            catch
            {
                txtDisplay.Text = "ERROR";
            }

            resetCalculator();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetCalculator();
            updateDisplay();
        }


        public void updateDisplay()
        {
            txtDisplay.Text = $"{num1} {operation} {num2}";
        }

        // Allow reset for new calculations
        public void resetCalculator()
        {
            num1 = string.Empty;
            num2 = string.Empty;
            operation = string.Empty;
            numberFlag = false;
        }
    }
}
