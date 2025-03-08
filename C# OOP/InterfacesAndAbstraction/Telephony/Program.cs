namespace Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (string phoneNumber in phoneNumbers)
            {
                if (phoneNumber.Length == 10)
                {
                    Smartphone smartphone = new Smartphone();
                    Console.WriteLine(smartphone.Calling(phoneNumber));
                }

                if (phoneNumber.Length == 7)
                {
                    StationaryPhone stationaryPhone = new StationaryPhone();
                    Console.WriteLine(stationaryPhone.Calling(phoneNumber));
                }
            }

            foreach (string url in urls)
            {
                Smartphone smartphone = new Smartphone();
                Console.WriteLine(smartphone.Browsing(url));
            }
        }
    }
}