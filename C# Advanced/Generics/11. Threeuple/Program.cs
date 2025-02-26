using System.Security.Cryptography;

namespace Threeuple
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
            string[] bankBalance = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            CustomThreeuple<string, string, string> nameAddress = new CustomThreeuple<string, string, string>(string.Join(" ", nameAndAddress[0..2]), string.Join(" ", nameAndAddress[2..3]), string.Join(" ", nameAndAddress[3..]));
            CustomThreeuple<string, int, bool> nameBeerAmount = new CustomThreeuple<string, int, bool>(nameAndBeerAmount[0], int.Parse(nameAndBeerAmount[1]), nameAndBeerAmount[2] == "drunk");
            CustomThreeuple<string, double, string> balance = new CustomThreeuple<string, double, string>(bankBalance[0], double.Parse(bankBalance[1]), bankBalance[2]);

            Console.WriteLine($"{nameAddress.Item1} -> {nameAddress.Item2} -> {nameAddress.Item3}");
            Console.WriteLine($"{nameBeerAmount.Item1} -> {nameBeerAmount.Item2} -> {nameBeerAmount.Item3}");
            Console.WriteLine($"{balance.Item1} -> {balance.Item2} -> {balance.Item3}");
        }
    }
}