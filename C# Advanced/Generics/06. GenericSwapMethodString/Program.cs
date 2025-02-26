namespace GenericSwapMethodString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }

            int[] indices = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Swap(indices[0], indices[1], list);

            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }

            static void Swap<T>(int index1, int index2, List<T> items)
            {
                (items[index1], items[index2]) = (items[index2], items[index1]);
            }
        }
    }
}