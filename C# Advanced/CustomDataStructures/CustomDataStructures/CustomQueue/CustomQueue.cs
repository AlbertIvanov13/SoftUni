using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    public class CustomQueue
    {
        private const int InitialCapacity = 4;
        private const int FirstElementIndex = 0;
        private int[] items;

        public CustomQueue()
        {
            items = new int[InitialCapacity];
        }
        public int Count { get; set; }

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

        public void Enqueue(int element)
        {
            if (this.items.Length == this.Count)
            {
                Resize();
            }
            items[Count] = element;
            Count++;
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