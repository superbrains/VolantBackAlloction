using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VolantBackAlloction.Models;

namespace BAServices.Models
{
    public class LACTUnitConfiguration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public virtual Meters Meters { get; set; }
        public virtual Facilities Facilities { get; set; }
        public virtual Pipelines Pipelines { get; set; }
    }
}
