using System.Security.AccessControl;

namespace EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int start = 1;
            int end = 12;
            int counter = 0;
            while (counter < 10)
            {
                counter++;
                try
                {
                    int number = ReadNumber(start, end);
                    numbers.Add(number);
                    start = number;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    counter--;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static int ReadNumber(int start, int end)
        {
            string number = Console.ReadLine();

            if (number.All(d => char.IsLetter(d)))
            {
                throw new ArgumentException("Invalid Number!");
            }

            if (int.Parse(number) <= start || int.Parse(number) > 100)
            {
                throw new ArgumentException($"Your number is not in range {start} - 100!");
            }

            return int.Parse(number);
        }
    }
}