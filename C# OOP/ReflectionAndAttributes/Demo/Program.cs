using System.Reflection;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Type classType = typeof(Person);
            Person person = (Person)Activator.CreateInstance(classType);

            var methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly);
            var properties = classType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly);
            var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            person.Name = "Ivan";
            person.Age = 10;

            foreach (var method in methods)
            {
                Console.WriteLine($"Method: {method.Name}");
            }

            foreach (var property in properties)
            {
                Console.WriteLine($"Property: {property.Name}");
            }

            foreach (var field in fields)
            {
                Console.WriteLine($"Field: {field.Name}");
            }


            Console.WriteLine($"Person {person.Name} is {person.Age} years old");
        }
    }
}