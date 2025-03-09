using Demo.Core.Interfaces;
using Demo.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            writer.WriteLine("Start");
            writer.WriteLine("sfjkk");
            writer.WriteLine("oiwoio");
            writer.WriteLine("jmc");
        }
    }
}