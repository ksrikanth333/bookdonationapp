using Books.Model;
using System.Collections.Generic;
using System.Linq;

namespace Books.Data
{
    public class BooksData : IBooks
    {
        readonly List<Book> books;
        public BooksData()
        {
            books = new List<Book>()
            {
                new Book(){BookId=1,BookName="Dot Net",AuthorName="Steve",BookCategory=BookCategory.ITProgramming,SellerOrDonorName="Srikanth",Price=250.00},
                new Book(){BookId=2,BookName="Digital Electronics",AuthorName="Adams",BookCategory=BookCategory.Education,SellerOrDonorName="Raj",Price=450.00},
                new Book(){BookId=3,BookName="Revolution 2020",AuthorName="Chetan",BookCategory=BookCategory.Literature,SellerOrDonorName="Sudhakar",Price=150.00}
            };
        }

        public Book AddBook(Book newBook)
        {
            newBook.BookId = books.Max(b => b.BookId) + 1;
            books.Add(newBook);
            return newBook;
        }

        public Book DeleteBook(int bookId)
        {
            var deletedBook = books.SingleOrDefault(b => b.BookId == bookId);
            if (deletedBook != null)
            {
                books.Remove(deletedBook);
            }
            return deletedBook;
        }


        public IEnumerable<Book> GetBooksByName(string name)
        {
            return from b in books
                   where string.IsNullOrEmpty(name)||b.BookName.ToLower().Contains(name.ToLower())
                   orderby b.BookId
                   select b;
        }

        public Book GetById(int bookId)
        {
            return books.SingleOrDefault(b => b.BookId == bookId);
        }

        public Book UpdateBookDetails(Book updatebook)
        {
            var book = books.SingleOrDefault(b => b.BookId == updatebook.BookId);
            if (book != null)
            {
                book.BookName = updatebook.BookName;
                book.BookCategory = updatebook.BookCategory;
                book.AuthorName = updatebook.AuthorName;
                book.SellerOrDonorName = updatebook.SellerOrDonorName;
                book.Price = updatebook.Price;
            }
            return book;
        }
    }

}
