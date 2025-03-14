namespace SingleResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = ReadNumbers();
            var filteredNumbers = FilterNumbers(numbers);
            var sortedNumbers = SortNumbers(filteredNumbers);
            PrintNumbers(sortedNumbers);
        }

        static int[] ReadNumbers()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            return numbers;
        }

        static int[] FilterNumbers(int[] numbers)
        {
            numbers = numbers.Where(n => n % 2 == 0).ToArray();
            return numbers;
        }

        static int[] SortNumbers(int[] numbers)
        {
            numbers = numbers.OrderByDescending(n => n).ToArray();
            return numbers;
        }

        static void PrintNumbers(int[] numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}