using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class BookSummary
    {
        [Key]
        public int SummaryId { get; set; }
        public string SummaryName { get; set; }
        public string SummaryDescription { get; set; }
        public DateTime SummaryDate { get; set; }
        public bool SummaryStatus { get; set; }


        //ilişkiler
        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
