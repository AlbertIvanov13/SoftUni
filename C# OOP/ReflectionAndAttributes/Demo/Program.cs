using System.Reflection;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Type classType = typeof(Person);
            var methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
            var properties = classType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (var method in methods)
            {
                Console.WriteLine($"Method: {method.Name}");
            }

            foreach (var property in properties)
            {
                Console.WriteLine($"Property: {property.Name}");
            }

            
        }
    }
}