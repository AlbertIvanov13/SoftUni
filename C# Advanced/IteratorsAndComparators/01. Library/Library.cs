using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }
        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {

            private List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }
            public List<Book> Books
            {
                get { return books; }
                set { books = value; }
            }

            public int CurrentIndex
            {
                get { return currentIndex; }
                set { currentIndex = value; }
            }


            public Book Current => this.books[currentIndex];

            object IEnumerator.Current => this.Current;
            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                return ++currentIndex < books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}