using Demo.Attributes;
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

        [AgeRange(1, 90)]
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

        public void GettingPaid(decimal salary, string day)
        {
            if (day == "Tuesday")
            {
                salary *= 1.15m;
            }
            Console.WriteLine($"Person is getting paid {salary:f2} on {day}");
        }

        public string BuyingFood(decimal price)
        {
            return $"Person spent {price:f2} leva on food";
        }
    }
}