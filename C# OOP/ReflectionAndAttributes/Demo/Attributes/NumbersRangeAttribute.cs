using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class NumbersRangeAttribute : Attribute
    {
        public NumbersRangeAttribute(int minValue, int maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public int MinValue { get; set; }
        public int MaxValue { get; set; }
    }
}