namespace ListyIterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] createCommand = Console.ReadLine().Split(" ");
            List<string> list = new List<string>(createCommand[1..]);
            ListyIterator<string> strings = new ListyIterator<string>(list);
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "Move")
                {
                    Console.WriteLine(strings.Move());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(strings.HasNext());
                }
                else if (command == "Print")
                {
                    strings.Print();
                }
                else if (command == "PrintAll")
                {
                    strings.PrintAll();
                }
            }
        }
    }
}