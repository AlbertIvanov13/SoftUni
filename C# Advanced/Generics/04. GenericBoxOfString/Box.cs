using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private T item;

        public T Item
        {
            get { return item; }
            set { item = value; }
        }

        public Box(T item)
        {
            this.item = item;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {this.item}";
        }

    }
}