using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class Stack<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 4;
        private T[] items;

        public Stack(params T[] items)
        {
            this.items = items;
            this.Count = items.Length;
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

        public void Push(T element)
        {
            if (this.items.Length == this.Count)
            {
                Resize();
            }

            this.items[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            int index = this.Count - 1;
            try
            {
                var lastIndex = this.Count - 1;
                T last = this.items[lastIndex];
                this.Count--;
                return last;
            }
            catch (Exception ex)
            {
                Console.WriteLine("No elements");
            }

            return default;
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty!");
            }

            var lastIndex = this.Count - 1;
            T last = this.items[lastIndex];
            return last;
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

        private void Resize()
        {
            T[] copyArray = new T[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copyArray[i] = this.items[i];
            }
            this.items = copyArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}