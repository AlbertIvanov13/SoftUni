using Demo.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Calculator
    {
        [Custom("Adding two numbers")]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}