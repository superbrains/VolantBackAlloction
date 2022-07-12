using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VolantBackAlloction.Models;

namespace BAServices.Models
{
    public class POS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int TenantID { get; set; }
        public virtual Pipelines Pipelines { get; set; }
        public string POSName { get; set; }
    }
}
