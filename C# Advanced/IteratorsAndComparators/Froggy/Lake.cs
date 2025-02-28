using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> numbers;
        private bool isOver = false;

        public Lake(List<int> numbers)
        {
            this.numbers = numbers;
        }
        public List<int> Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.numbers[i];
                }

                if (i == this.numbers.Count - 1)
                {
                    this.isOver = true;
                }
            }

            if (this.isOver)
            {
                for (int i = this.numbers.Count - 1; i >= 0; i--)
                {
                    if (i % 2 != 0)
                    {
                        yield return this.numbers[i];
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}