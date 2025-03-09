using Demo.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.IO
{
    public class FileWriter : IWriter
    {
        public void WriteLine(string str)
        {
            using StreamWriter writer = new StreamWriter("../../../test.txt", true);
            writer.WriteLine(str);
        }
    }
}