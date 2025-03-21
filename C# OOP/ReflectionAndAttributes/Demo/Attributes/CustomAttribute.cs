using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CustomAttribute : Attribute
    {
        public CustomAttribute(string description)
        {
            Description = description;
        }

        public string Description { get; set; }

    }
}