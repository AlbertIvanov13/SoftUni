namespace GenericCountMethodDouble
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<double> items = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                items.Add(element);
            }

            double itemToCompare = double.Parse(Console.ReadLine());
            Box<double> box = new Box<double>(itemToCompare);

            Console.WriteLine(box.CompareTo(items, itemToCompare));
        }
    }
}