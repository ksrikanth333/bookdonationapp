using Books.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Data
{
    public interface IBooks
    {
         IEnumerable<Book> GetBooksByName(string name);
        Book AddBook(Book newBook);
        Book GetById(int bookId);
        Book UpdateBookDetails(Book book);
        Book DeleteBook(int bookId);
    }

}
