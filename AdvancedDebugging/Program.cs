using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedDebugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>{10, 20, 30, 40, 50, 60};

            var smallests = GetSmallets(numbers, 3);

            foreach (var s in smallests)
            {
                Console.WriteLine(s);
            }

        }
        public static List<int> GetSmallets(List<int> list, int count)
        {
            var smallet = new List<int>();

            for (int i = 0; i <list.Count; i++)
            {
                var min = list[i];
                var max = list[i+1];    

                if (max > min)
                {
                    max = list[i+1];

                    smallet.Add(min);
                    list.Remove(min);
                }
                  
            }

            return smallet;
        }


    }
}
