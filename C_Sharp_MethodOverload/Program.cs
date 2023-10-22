using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_MethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number1");
            var num1 = Console.ReadLine();

            Console.WriteLine("Enter Number2");
            var num2 = Console.ReadLine();

            var calculator = new Calculator();
            calculator.Number1 = int.Parse(num1);
            calculator.Number2 = int.Parse(num2);

            int sum = calculator.Sum(calculator.Number1, calculator.Number2);
            int diff = calculator.Sub(calculator.Number1, calculator.Number2);
            double prod = calculator.prod(calculator.Number1, calculator.Number2);

            Console.WriteLine (calculator.Number1 + " + " + calculator.Number2 + " = " + sum);
            Console.WriteLine(calculator.Number1 + " - " + calculator.Number2 + " = " + diff);
            Console.WriteLine(calculator.Number1 + " * " + calculator.Number2 + " = " + prod);
            Console.ReadKey();

        }
    }
}
