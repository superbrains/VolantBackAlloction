using BAServices.Models;
using System;
using System.Collections.Generic;
using System.Text;
using VolantBackAlloction.Models;

namespace BAServices.ViewModels.Well
{
   public class WellVM
    {
        public int ID { get; set; }
        public string UWI { get; set; }
        public string FieldName { get; set; }
        public virtual Field Field { get; set; }
        public string OperatorID { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ProductionDate { get; set; }
        public double Depth { get; set; }
        public string BlockNumber { get; set; }
        public string BlockType { get; set; }
        public string WellName { get; set; }
        public string WellAlias { get; set; }
        public string LocationName { get; set; }

        public string SurfaceCoordinateLongitude { get; set; }
        public string SurfaceCoordinateLatitude { get; set; }
        public string BottomCoordinateLongitude { get; set; }
        public string BottomCoordinateLatitude { get; set; }
        public string Terrain { get; set; }
        public string DrillPermitNo { get; set; }
        public DateTime SpudDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public string WellClassification { get; set; }
        public string WellPurpose { get; set; }
        public string WellContent { get; set; }
        public string WellBoreType { get; set; }
        public string WellType { get; set; }
        public DateTime WellStatusDate { get; set; }
        public double WaterDepth { get; set; }
        public string RigType { get; set; }
        public string RigOwner { get; set; }
        public string TargetedFormation { get; set; }
        public string BottomHoleAge { get; set; }

        public double ProposedTotalDepth { get; set; }

        public double ActualMeasuredDepth { get; set; }
        public double ProposedTotalVerticalDepth { get; set; }
        public double ActualTotalVerticalDepth { get; set; }
        public double EstimatedWellCostDollar { get; set; }
        public double ActualWellCostDollar { get; set; }
        public double EstimatedWellCostNaira { get; set; }

        public double ExchangeRate { get; set; }
        public string DepthRef { get; set; }
        public double DepthRefElevation { get; set; }
        public string ConventionalCore { get; set; }
        public string SidewallCore { get; set; }
        public string GroundLevel { get; set; }
        public string TypeOfCompletion { get; set; }
        public int ProposedCompletionDays { get; set; }
        public int ActualCompletionDays { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Status { get; set; }
        public string Createdby { get; set; }
        public string Approvedby { get; set; }
        public DateTime DateApproved { get; set; }
        public double MeasureDepth { get; set; }
        public string WellStatus { get; set; }
        public virtual Tenants Tenants { get; set; }
    }
}
