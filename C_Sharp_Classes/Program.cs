using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Classes
{
    public class Person
    {
        public string Name;
        public int Age;

        public void Introduce(string name, int age)
        {
            Console.WriteLine("My name is "+ name + ". I am " + age + " Old.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Introduce("Nick", 10);
            person.Introduce("Bokamoso", 33);

            Console.ReadKey();


        }
    }
}
