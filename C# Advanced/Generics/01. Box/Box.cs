using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private const int InitialSize = 5;
        private T element;
        private T[] items;

        public Box()
        {
            items = new T[InitialSize];
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

        private void IndexOutOfRangeException(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
        }

        public void Add(T element)
        {
            if (this.items.Length == this.Count)
            {
                Resize();
            }

            this.items[this.Count] = element;
            this.Count++;
        }

        public T Remove()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Box is empty!");
            }

            var lastIndex = this.Count - 1;
            T last = this.items[lastIndex];
            this.Count--;
            return last;
        }

        private void Resize()
        {
            T[] copyArray = new T[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copyArray[i] = this.items[i];
            }
            this.items = copyArray;
        }
    }
}