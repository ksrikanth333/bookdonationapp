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
    public class DeleteBookModel : PageModel
    {
        private readonly IBooks books;
        [BindProperty]
        public Book Book { get; set; }
        public DeleteBookModel(IBooks books)
        {
            this.books = books;
        }
        public void OnGet(int bookId)
        {
            Book=books.GetById(bookId);
           
        }
        public IActionResult OnPost()
        {
            books.DeleteBook(Book.BookId);
            TempData["DeleteMessage"] = Book.BookName + "Item Deleted Successfully";
            return RedirectToPage("./Books");
        }
    }
}
