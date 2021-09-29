using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Model
{
    public class Book
    {
       
       public int BookId { get; set; }
       [Required, StringLength(80)]
       public string BookName { get; set; }
       [Required]
       public BookCategory BookCategory { get; set; }
       [Required]
       public string AuthorName { get; set; }
       [Required]
       public string SellerOrDonorName { get; set; }
       [Required,DataType(DataType.Currency)]
       public double Price { get; set; }

    }
}
