using System.Collections;

namespace Froggy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            Lake lake = new Lake(list);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}