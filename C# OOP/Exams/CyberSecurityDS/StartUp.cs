using CyberSecurityDS.Core.Contracts;
using CyberSecurityDS.Core;

namespace CyberSecurityDS
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}