using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BAServices.Models
{
   public class Operators
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string BusinessName { get; set; }
        public string ContactName { get; set; }
        public string ContactMobile { get; set; }
        public string ContactEmail { get; set; }
        public string RCCNumber { get; set; }
        public string Address { get; set; }
        public string Logo { get; set; }
        public string Status { get; set; }
    }
}
