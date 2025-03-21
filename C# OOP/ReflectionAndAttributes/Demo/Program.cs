using System.Reflection;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Type classType = typeof(Person);
            var methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}