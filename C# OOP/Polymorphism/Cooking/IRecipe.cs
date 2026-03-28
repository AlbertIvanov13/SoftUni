using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public interface IRecipe
    {
        void GetIngredients();
        void Mix();
        void Prepare();
    }
}