using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Arrays_SortBySmallNumbers
{
    internal class Program

    {
        static void Main(string[] args)
        {
            //Array 

            int[] numbers = { 10, 20, 30, 40, 50, 60 };
            
            Random random = new Random();

                     numbers = numbers.OrderBy( x => random.Next()).ToArray();

            List<int> smallestNumbers = GetLastThereeSmallestNumbers(numbers);

                      Console.WriteLine("selected Numbers");
            foreach (int number in smallestNumbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();


            
        }

       public static List<int> GetLastThereeSmallestNumbers(int[] numbers)
        {
            if (numbers.Length < 3)
            {
                throw new ArgumentException("The array should contain at least 3 numbers");
            }

            Array.Sort(numbers);

            List <int> smallestNumber = new List<int>();
          
            for (int i = 0; i < 3; i++)
            {
                smallestNumber.Add(numbers[i]);
            }

            return smallestNumber;

        }
    }
}
