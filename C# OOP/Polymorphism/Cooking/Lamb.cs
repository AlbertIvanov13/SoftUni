using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Lamb : IRecipe
    {
        public void GetIngredients()
        {
            Console.WriteLine("Get salt and pepper");
            Console.WriteLine("Buy lamb lang");
            Console.WriteLine("Buy oil");
            Console.WriteLine("---------------------");
        }

        public void Mix()
        {
            Console.WriteLine("Put together the salt, the pepper and the oil");
            Console.WriteLine("Rub the meat");
            Console.WriteLine("----------------------");
        }

        public void Prepare()
        {
            Console.WriteLine("Put in the oven for 4 hours on 180 degrees");
        }
    }
}   