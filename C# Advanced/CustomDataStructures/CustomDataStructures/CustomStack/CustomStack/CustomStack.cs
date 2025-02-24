using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class CustomStack
    {
        private const int InitialCapacity = 4;
        private int[] items;

        public CustomStack()
        {
            items = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                IndexOutOfRangeException(index);
                return this[index];
            }
            set
            {
                IndexOutOfRangeException(index);
                this[index] = value;
            }
        }

        public void Push(int element)
        {
            if (this.items.Length == this.Count)
            {
                Resize();
            }

            this.items[this.Count] = element;
            this.Count++;
        }

        public int Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty!");
            }

            var lastIndex = this.Count - 1;
            int last = this.items[lastIndex];
            this.Count--;
            return last;
        }

        public int Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty!");
            }

            var lastIndex = this.Count - 1;
            int last = this.items[lastIndex];
            return last;
        }

        private void IndexOutOfRangeException(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
        }

        private void Resize()
        {
            int[] copyArray = new int[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copyArray[i] = this.items[i];
            }
            this.items = copyArray;
        }
    }
}