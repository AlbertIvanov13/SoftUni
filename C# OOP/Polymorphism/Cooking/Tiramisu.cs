using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Tiramisu : IRecipe
    {
        public void GetIngredients()
        {
            Console.WriteLine("Get coffee, biscuits and eggs");
            Console.WriteLine("---------------");
        }

        public void Mix()
        {
            Console.WriteLine("Mix them all together");
            Console.WriteLine("---------------");
        }

        public void Prepare()
        {
            Console.WriteLine("Put in form and after that in the fridge for 2 hours");
            Console.WriteLine("---------------");
        }
    }
}
