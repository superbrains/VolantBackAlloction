using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolantBackAlloction.Models
{
    public class Meters
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int TenantID { get; set; }
        public string MeterType { get; set; }

        public string Name { get; set; }
        public double MeterFactor { get; set; }
    }
}
