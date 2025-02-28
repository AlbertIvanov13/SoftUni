using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> items;
        private int currentIndex = 0;

        public ListyIterator(List<T> items)
        {
            this.items = new List<T>(items);
        }

        public List<T> Items
        {
            get { return items; }
            set { items = value; }
        }

        public bool Move()
        {
            for (int i = this.currentIndex; i < this.items.Count; i++)
            {
                if (i < this.items.Count - 1)
                {
                    this.currentIndex++;
                    return true;
                }
            }

            return false;
        }

        public bool HasNext()
        {
            for (int i = this.currentIndex; i < this.items.Count; i++)
            {
                if (i < this.items.Count - 1)
                {
                    return true;
                }
            }

            return false;
        }

        public void Print()
        {
            try
            {
                Console.WriteLine(this.items[this.currentIndex]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}