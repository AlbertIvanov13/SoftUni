using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Person
    {
        private string secondName;
        private string lastName;

        public string Name { get; set; }
        public int Age { get; set; }
        public void Eat(string food)
        {
            Console.WriteLine($"Person is eating {food}");
        }

        public void Sleep(string place)
        {
            Console.WriteLine($"Person is sleeping at {place}");
        }

        public void Work(string workplace)
        {
            Console.WriteLine($"Person is working at {workplace}");
        }
    }
}