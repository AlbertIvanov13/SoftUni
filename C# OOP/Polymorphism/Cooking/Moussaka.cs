using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Moussaka : IRecipe
    {
        public void GetIngredients()
        {
            Console.WriteLine("Get salt and pepper");
            Console.WriteLine("Buy potatoes");
            Console.WriteLine("Buy meat");
            Console.WriteLine("---------------");
        }

        public void Mix()
        {
            Console.WriteLine("Mix the ingredients");
            Console.WriteLine("---------------");
        }

        public void Prepare()
        {
            Console.WriteLine("Fry the vegetables");
            Console.WriteLine("Add meat to them and put in the oven for 2 hours");
        }
    }
}