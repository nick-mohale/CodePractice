using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.SetCar(1, "BMW", "Black", "CA2456WC");
            car.GetCar();
            Console.ReadLine();

        }
    }
}
