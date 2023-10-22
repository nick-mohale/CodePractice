using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_MethodOverload
{
    internal class Calculator
    {
        public int Number1;
        public int Number2;

        public Calculator()
        {

        }
        public Calculator(int number1, int number2)
        {
            this.Number1 = number1;
            this.Number2 = number2;
        }
        public int Sum(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum;
        }
        public int Sub(int num1, int num2)
        {
            var diff = 0;

            if (num1 > num2)
            {
                diff = num1 - num2;
            }
            else
            {
                diff = num2 - num1;
            }



            return diff;
        }

        public double prod(int num1, int num2)
        {
            var prod = num1 * num2;
            return prod;
        }
    }
}

