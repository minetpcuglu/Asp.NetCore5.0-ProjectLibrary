using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class RewardPoint
    {
        [Key]
        public int RewardId { get; set; }
        public DateTime date { get; set; }

        public decimal TotelPoint { get; set; }

        /*İlişkiler*/
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
