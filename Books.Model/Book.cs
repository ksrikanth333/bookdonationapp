using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Model
{
    public class Book
    {
       public int BookId { get; set; }
       public string BookName { get; set; }
       public BookCategory BookCategory { get; set; }
       public string AuthorName { get; set; }
       public string SellerOrDonorName { get; set; }
       public double Price { get; set; }

    }
}
