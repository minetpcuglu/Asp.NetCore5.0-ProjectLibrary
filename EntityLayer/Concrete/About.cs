using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutName { get; set; }
        public string AboutDetail { get; set; }
        public string AboutImage { get; set; }
        public bool AboutStatus { get; set; }
    }
}
