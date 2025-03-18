using System.Text;
using System.Xml.Linq;

namespace CocktailBar
{
    public class Menu
    {
        public Menu(int barCapacity)
        {
            BarCapacity = barCapacity;
            Cocktails = new List<Cocktail>(barCapacity);
        }
        public List<Cocktail> Cocktails { get; set; }
        public int BarCapacity { get; set; }

        public void AddCocktail(Cocktail cocktail)
        {
            if (Cocktails.Count < BarCapacity && !Cocktails.Any(c => c.Name == cocktail.Name))
            {
                Cocktails.Add(cocktail);
            }
        }

        public bool RemoveCocktail(string name)
        {
            if (Cocktails.Any(c => c.Name == name))
            {
                Cocktails.Remove(Cocktails.First(c => c.Name == name));
                return true;
            }

            return false;
        }

        public Cocktail GetMostDiverse()
        {
            Cocktail cocktail = Cocktails.MaxBy(c => c.Ingredients.Count);
            return cocktail;
        }

        public string Details(string cocktailName)
        {
            Cocktail cocktail = Cocktails.FirstOrDefault(c => c.Name == cocktailName);
            return cocktail.ToString();
        }

        public string GetAll()
        {
            StringBuilder sb = new StringBuilder();
            Cocktails = Cocktails.OrderBy(c => c.Name).ToList();
            sb.AppendLine($"All Cocktails:");
            foreach (Cocktail cocktail in Cocktails)
            {
                sb.AppendLine($"{cocktail.Name}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}