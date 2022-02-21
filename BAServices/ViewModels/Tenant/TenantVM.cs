using System.ComponentModel;

namespace VolantBackAlloction.ViewModels.Tenant
{
    public class TenantVM
    {
        [DisplayName("ID")]
        public int? ID { get; set; }

        [DisplayName("Business Name")]
        public string BusinessName { get; set; }
        [DisplayName("Contact Name")]
        public string ContactName { get; set; }
        [DisplayName("Phone Number")]
        public string ContactMobile { get; set; }
        [DisplayName("Email")]
        public string ContactEmail { get; set; }
        [DisplayName("RCC Number")]
        public string RCCNumber { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("Logo URL")]
        public string Logo { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }
    }
}
