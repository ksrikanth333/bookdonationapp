using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Data;
using Books.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Allguides.Pages.Books
{
    public class BooksModel : PageModel
    {
        private readonly IBooks books;
        public IEnumerable<Book> BooksList { get; set; }
        public Book Book { get; set; }
        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }
        public BooksModel(IBooks books)
        {
            this.books = books;
        }
        public void OnGet()
        {
            BooksList=books.GetBooksByName(SearchTerm);
        }
    }
}
