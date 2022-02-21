using System;
using System.Collections.Generic;
using System.Text;

namespace BAServices.ViewModels.Operators
{
   public class OperatorVM
    {
        public int? ID { get; set; }
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
