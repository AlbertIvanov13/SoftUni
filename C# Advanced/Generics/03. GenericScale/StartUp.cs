using System.Linq.Expressions;

namespace GenericScale
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            EqualityScale<int> equalityScale = new EqualityScale<int>(5, 2);

            Console.WriteLine(equalityScale.AreEqual());
        }
    }
}