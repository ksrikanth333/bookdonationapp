using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Data;
using Books.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Allguides.Pages.Books
{
    public class EditBookModel : PageModel
    {
        private readonly IBooks books;
        private readonly IHtmlHelper htmlHelper;
        public IEnumerable<SelectListItem> Categories { get; set; }
        [BindProperty]
        public Book Book { get; set; }
        public EditBookModel(IBooks books, IHtmlHelper htmlHelper)
        {
            this.books = books;
            this.htmlHelper = htmlHelper;
        }
        public void OnGet(int bookId)
        {
            Categories = htmlHelper.GetEnumSelectList<BookCategory>();
            Book = books.GetById(bookId);
        }
        public IActionResult OnPost()
        {
            Categories = htmlHelper.GetEnumSelectList<BookCategory>();
            Book = books.UpdateBookDetails(Book);
            TempData["UpdateMessage"] = "Book Details Updated Successfully";
            return RedirectToPage("./Books");
        }
    }
}
