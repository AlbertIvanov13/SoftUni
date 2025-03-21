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
        [NumbersRange(1, int.MaxValue)]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}