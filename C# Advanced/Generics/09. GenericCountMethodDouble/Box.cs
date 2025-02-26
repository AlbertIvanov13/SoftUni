using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodDouble
{
    public class Box<T> where T : IComparable<T>
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

        public int CompareTo(List<T> list, T element)
        {
            int counter = 0;

            foreach (var item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}