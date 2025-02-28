using System.Collections;
using System.Threading.Channels;

namespace CustomStack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] createCommand = Console.ReadLine().Split(new string[] { " ", ", "},StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(createCommand[1..]);
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] inputs = command.Split();
                if (inputs[0] == "Pop")
                {
                    stack.Pop();
                }
                else if (inputs[0] == "Push")
                {
                    stack.Push(inputs[1]);
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}