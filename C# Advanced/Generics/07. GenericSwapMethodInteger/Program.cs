namespace GenericSwapMethodInteger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
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