using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Car
    {
        private int _id;
        private string _model;
        private string _colour;
        private string _registrationNumber;

        public void SetCar(int id, string model, string  colour, string registrationNumber)
        {
            _id = id;
            _model = model;
            _colour = colour;
            _registrationNumber = registrationNumber;
        }
        public void GetCar()
        {
            Console.WriteLine("The Car is " + _colour + " " + _model + " " + " Registration : " + _registrationNumber);
        }
    }
}
