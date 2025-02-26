namespace GenericCountMethodString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> items= new List<string>();
            for (int i = 0; i < n; i++)
            {
                string element = Console.ReadLine();
                items.Add(element);
            }

            string itemToCompare = Console.ReadLine();
            Box<string> box = new Box<string>(itemToCompare);

            Console.WriteLine(box.CompareTo(items, itemToCompare));
        }
    }
}