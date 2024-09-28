using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIteration
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books = new List<Book>();

        public void Add(Book book)
        {
            books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < books.Count; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
