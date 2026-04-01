using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Chef
    {
        public void Cook(IRecipe recipe)
        {
            recipe.GetIngredients();

            recipe.Mix();

            recipe.Prepare();
        }
    }
}