using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Calculating
{
    internal class Calc
    {
        private int num1, num2;
        private string operation;

        public Calc()
        {
            num1 = 0;
            num2 = 0;
            operation = string.Empty;
        }

        public Calc(string Num1, string Num2, string Operation)
        {
            num1 = int.Parse(Num1);
            num2 = int.Parse(Num2);
            operation = Operation;
        }

        public float calculate()
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "/":
                    return num1 / num2;
                case "x":
                    return num1 * num2;
                default:
                    return 0;
            }
        }
    }
}
