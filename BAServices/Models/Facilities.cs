using BAServices.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolantBackAlloction.Models
{
    public class Facilities
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FacilityName { get; set; }
        public string Description { get; set; }
        public string FacilityType { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public DateTime StartupDate { get; set; }
        public string FacilityStatus { get; set; }
        public string LocationName { get; set; }
        public string Terrain { get; set; }

        public double Capacity_per_day { get; set; }
        public double Operating_Capacity_gas { get; set; }
        public double Operating_Capacity_water { get; set; }
        public double StorageCapacity { get; set; }
        public string FluidType { get; set; }
        public DateTime CommissionDate { get; set; }
        public string DPRPermitNumber { get; set; }
        public double DesignLife { get; set; }
        public double Waterdepth { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public string Createdby { get; set; }
        public int OperatorID { get; set; }
        public virtual Tenants Tenants { get; set; }
    }
}
