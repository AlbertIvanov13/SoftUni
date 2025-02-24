using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private const int InitialCapacity = 2;
        private T[] items;

        public CustomList()
        {
            items = new T[InitialCapacity];
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

        public void Add(T item)
        {
            if (this.items.Length == this.Count)
            {
                Resize();
            }

            this.items[this.Count] = item;
            this.Count++;
        }

        public T RemoveAt(int index)
        {
            IndexOutOfRangeException(index);

            var item = this.items[index];
            this.items[index] = default(T);
            this.Shift(index);

            this.Count--;
            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return item;
        }

        public void Insert(int index, T element)
        {
            if (index > this.Count || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }

            if (this.items.Length == this.Count)
            {
                Resize();
            }
            this.ShiftRight(index);
            this.items[index] = element;
            this.Count++;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (items[i].Equals(element))
                {
                    return true;
                }
            }

            return default;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            IndexOutOfRangeException(firstIndex);
            IndexOutOfRangeException(secondIndex);

            var firstIndexElement = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = firstIndexElement;
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
            T[] copyArray = new T[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copyArray[i] = this.items[i];
            }
            this.items = copyArray;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        private void ShiftRight(int index)
        {
            for (int i = this.Count - 1; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
        }

        private void Shrink()
        {
            T[] copy = new T[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
    }
}