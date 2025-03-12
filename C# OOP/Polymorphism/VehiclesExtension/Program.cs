using VehiclesExtension.Core;
using VehiclesExtension.Core.Interfaces;
using VehiclesExtension.IO;
using VehiclesExtension.IO.Interfaces;

namespace VehiclesExtension
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}