using System.Reflection;
using System;
using Demo.Attributes;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string className = Console.ReadLine();

            Type classType = Type.GetType($"Demo.{className}");

            object obj = Activator.CreateInstance(classType);
            Calculator calculator = (Calculator)obj;
            MethodInfo[] methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);

            Console.WriteLine("Methods:");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"{method.Name} ({method.ReturnType.Name})");
            }

            string methodName = Console.ReadLine();

            MethodInfo methodToInvoke = classType.GetMethod(methodName);

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(methodToInvoke.Invoke(obj, new object[] { firstNumber, secondNumber }));

            var newMethod = typeof(Calculator).GetMethod("Add");
            var attribute = (CustomAttribute)Attribute.GetCustomAttribute(newMethod, typeof(CustomAttribute));

            Console.WriteLine(attribute.Description);
        }
    }
}