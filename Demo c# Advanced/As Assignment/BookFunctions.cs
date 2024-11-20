using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As_Assignment
{
    public delegate bool BookFunctionDelegate(int book);
    internal  class BookFunctions
    {
        public void ProcessBooks(List<int> books, BookFunctionDelegate bookFunction)
        {
            foreach (int book in books)
            {
                bookFunction(book);
            }
        }
        public void PrintBookTitle(Book book)
        {
            Console.WriteLine(book.Title);
        }

        public void PrintBookAuthor(Book book)
        {
            Console.WriteLine(book.Author);
        }

        internal BookFunctionDelegate ProcessBooks(List<Book> books, Func<int, bool> bookFunction)
        {
            throw new NotImplementedException();
        }
    }
}
