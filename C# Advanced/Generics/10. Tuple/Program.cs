namespace Tuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] nameAndAddress = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] nameAndBeerAmount = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            int integer = (int)numbers[0];
            double doubleNumber = numbers[1];

            CustomTuple<string, string> nameAddress = new CustomTuple<string, string>(string.Join(" ", nameAndAddress[0..2]), string.Join(" ", nameAndAddress[2..]));
            CustomTuple<string, int> nameBeerAmount = new CustomTuple<string, int>(string.Join(" ", nameAndBeerAmount[0]), int.Parse(nameAndBeerAmount[1]));
            CustomTuple<int, double> numbersTuple = new CustomTuple<int, double>((int)numbers[0], numbers[1]);

            Console.WriteLine($"{nameAddress.Item1} -> {nameAddress.Item2}");
            Console.WriteLine($"{nameBeerAmount.Item1} -> {nameBeerAmount.Item2}");
            Console.WriteLine($"{numbersTuple.Item1} -> {numbersTuple.Item2}");
        }
    }
}