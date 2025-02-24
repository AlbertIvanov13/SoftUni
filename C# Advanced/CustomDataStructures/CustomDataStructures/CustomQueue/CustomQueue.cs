using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    public class CustomQueue<T>
    {
        private const int InitialCapacity = 4;
        private const int FirstElementIndex = 0;
        private T[] items;

        public CustomQueue()
        {
            items = new T[InitialCapacity];
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

        public void Enqueue(T element)
        {
            if (this.items.Length == this.Count)
            {
                Resize();
            }
            items[Count] = element;
            Count++;
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("CustomQueue is empty!");
            }

            this.Count--;
            var firstElement = this.items[FirstElementIndex];
            this.items[FirstElementIndex] = default;
            Shift();
            this.items[Count] = default;
            return firstElement;
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("CustomQueue is empty!");
            }

            T firstElement = this.items[FirstElementIndex];
            return firstElement;
        }

        public T[] Clear()
        {
            this.items = new T[items.Length];

            return this.items;
        }

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.items[i]);
            }
        }

        private void IndexOutOfRangeException(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
        }

        private void Shift()
        {
            for (int i = 0; i < this.Count; i++)
            {
                this.items[i] = this.items[i + 1];
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
    }
}