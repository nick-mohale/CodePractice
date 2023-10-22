using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Nick";
            int age = 10;

            var person = new Person();
            person.Name = name;
            person.Age = age;

            Console.WriteLine("My name is {0} and I am {1} years old.",person.Name,person.Age);
            Console.ReadKey();

        }
    }
}
