using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookImage { get; set; }
        public string BookDescription { get; set; }
        public string PrintDate { get; set; }
        public string NumberPage { get; set; }
        public bool BookStatus { get; set; }

        //İlişkiler
        public List<Genre> Genres { get; set; }

        public List<BookSummary> BookSummaries { get; set; }

        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
