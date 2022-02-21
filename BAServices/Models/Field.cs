using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VolantBackAlloction.Models
{
    public class Field
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public string BlockNumber { get; set; }
        public string BlockType { get; set; }
        public string BA { get; set; }
        public int NumberofWells { get; set; }
        public double FieldPointNumber { get; set; }
        public double FieldLatitude { get; set; }
        public double FieldLongitude { get; set; }
        public string FieldHydrocarbonType { get; set; }
        public string FieldStatus { get; set; }
        public DateTime FieldDiscoveryDate { get; set; }
        public double FieldMinimumWaterDepth { get; set; }
        public double FieldMaximumWaterDepth { get; set; }
        public double FieldNumberofGasReservoir { get; set; }
        public double FieldNumberOfOil_CondensateReservoir { get; set; }
        public double FieldFirstOilDateForDevelopedField { get; set; }
        public string Terrain { get; set; }
         public double STOIIP { get; set; }
         public double GIIP { get; set; }
        public double EUR { get; set; }
        public double RF { get; set; }
        public double Produced_Oil_bbl { get; set; }
        public double Produced_Condensate_bbl { get; set; }
        public double Produced_Gas_bbl { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string ApproveStatus { get; set; }
        public virtual Tenants Tenants { get; set; }
    }
}
