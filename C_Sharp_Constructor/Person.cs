using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Constructor
{
    internal class Person
    {
        public int Id;
        public string Name;
        public int Age;

        public Person()
        {

        }
        public Person( int id)
        {
            this.Id = id;
        }
        public Person( string name )
        {
            this.Name = name;
        }
        public Person(int age, string name )
        {
            this.Age=age;
            this.Name=name;
        }
    }
}
