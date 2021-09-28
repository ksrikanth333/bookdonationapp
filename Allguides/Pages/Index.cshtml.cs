using Books.Data;
using Books.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allguides.Pages
{
    public class IndexModel : PageModel
    {
       
        private readonly IBooks books;
        private readonly IHtmlHelper htmlHelper;
        public IEnumerable<SelectListItem> Categories { get; set; }
        public Book Book { get; set; }
        public IndexModel(IBooks books,IHtmlHelper htmlHelper)
        {
            this.books = books;
            this.htmlHelper = htmlHelper;
           
        }

        public void OnGet()
        {
            Categories = htmlHelper.GetEnumSelectList<BookCategory>();
            
        }
        public IActionResult OnPost(Book book)
        {
            Book = book;
            Categories = htmlHelper.GetEnumSelectList<BookCategory>();
            books.AddBook(Book);
            TempData["AddMessage"]="Transaction Completed Successfully";
            return Page();
        }
    }
}
