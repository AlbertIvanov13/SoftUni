using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AgeRangeAttribute : Attribute
    {
        public AgeRangeAttribute(int minAge, int maxAge)
        {
            MinAge = minAge;
            MaxAge = maxAge;
        }

        public int MinAge { get; private set; }
        public int MaxAge { get; private set; }
    }
}