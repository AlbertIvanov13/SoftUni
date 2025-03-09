using Demo.Core;
using Demo.Core.Interfaces;
using Demo.IO;
using Demo.IO.Interfaces;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new FileWriter();

            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}