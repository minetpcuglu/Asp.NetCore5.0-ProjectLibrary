using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Contact
    {

        [Key]
        public int ContactID { get; set; }
        public string UserName { get; set; }
        public string UserSurName { get; set; }
        public string UserMail { get; set; }
        public string Subject { get; set; }
        public DateTime ContactDate { get; set; }
        public string Message { get; set; }
        public bool ContactStatus { get; set; }
    }
}
