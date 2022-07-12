using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolantBackAlloction.Models
{
    public class Pipelines
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int TenantID { get; set; }
        public string PipelineName { get; set; }
    }
}
