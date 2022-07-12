using AutoMapper;
using BAServices.Interfaces;
using BAServices.Models;
using BAServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VolantBackAlloction.Models;

namespace BAServices.Services
{
    public class AssetsServices : IAssets
    {
        private readonly DBContext _context;
        private readonly IMapper _mapper;
        public AssetsServices(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;        
        }

        public List<string> CheckRules(List<Nodes> nodes, List<Links> links)
        {
            List<string> validationMessages = new List<string>();

            //Link Cannot be nulll
            if (links == null)
            {
                validationMessages.Add("Your assets are missing relationships, please configure appropriately");
            }

            //Node Cannot be null
            if (nodes == null)
            {
                validationMessages.Add("You cannot have an empty asset");
            }

            //There can't be duplicate Node names...
            var hasDupes = nodes.GroupBy(x => new { x.text })
                    .Where(x => x.Skip(1).Any()).Any();

            if (hasDupes)
            {
                validationMessages.Add("You cannot have duplicate asset names");
            }


            var allNormalMeters = nodes.Where(x => x.category == "Normal Meter");
            var allPipelines = nodes.Where(x => x.category == "HBar");
            var allPDMeters= nodes.Where(x => x.category == "PD Meter");
            var allFacility = nodes.Where(x => x.category == "Facility");
            var allFiscalMeters= nodes.Where(x => x.category == "Fiscal Meter");
            var allPOS = nodes.Where(x => x.category == "POS");
            var allWells = nodes.Where(x => x.category == "OilWell");


            //You can't Link Normal Meter Directly to Pipeline          
            var invalidlinkings = links.Where(x => (allNormalMeters.Any(y => x.from == y.key) && allPipelines.Any(y => x.to == y.key)) || (allNormalMeters.Any(y => x.to == y.key) && allPipelines.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A Normal Meter cannot be linked directly to a pipeline");
            }

            //You can't Link Normal Meter Directly to PD Meter
            invalidlinkings = links.Where(x => (allNormalMeters.Any(y => x.from == y.key) && allPDMeters.Any(y => x.to == y.key)) || (allNormalMeters.Any(y => x.to == y.key) && allPDMeters.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A Normal Meter cannot be linked directly to a PD Meter");
            }


            //You can't Link PD Meter to well
            invalidlinkings = links.Where(x => (allWells.Any(y => x.from == y.key) && allPDMeters.Any(y => x.to == y.key)) || (allWells.Any(y => x.to == y.key) && allPDMeters.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A PD Meter cannot be directly linked to a well");
            }

            //You can't Link Well to Pipeline
            invalidlinkings = links.Where(x => (allWells.Any(y => x.from == y.key) && allPipelines.Any(y => x.to == y.key)) || (allWells.Any(y => x.to == y.key) && allPipelines.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A well cannot be directly linked to a Pipeline");
            }

            //You can't Link PD Meter to Fiscal Meter
            invalidlinkings = links.Where(x => (allPDMeters.Any(y => x.from == y.key) && allFiscalMeters.Any(y => x.to == y.key)) || (allPDMeters.Any(y => x.to == y.key) && allFiscalMeters.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A PD Meter cannot be linked to a Fiscal Meter");
            }

            //You cant link Facility to Fiscal Meter
            invalidlinkings = links.Where(x => (allFacility.Any(y => x.from == y.key) && allFiscalMeters.Any(y => x.to == y.key)) || (allFacility.Any(y => x.to == y.key) && allFiscalMeters.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A facility cannot be linked to a Fiscal Meter");
            }

            //You can't Link Normal Meter to Fiscal Meter
            invalidlinkings = links.Where(x => (allNormalMeters.Any(y => x.from == y.key) && allFiscalMeters.Any(y => x.to == y.key)) || (allNormalMeters.Any(y => x.to == y.key) && allFiscalMeters.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A Normal Meter cannot be directly linked to a Fiscal Meter");
            }

            //You can't Link Well to Fiscal Meter
            invalidlinkings = links.Where(x => (allWells.Any(y => x.from == y.key) && allFiscalMeters.Any(y => x.to == y.key)) || (allWells.Any(y => x.to == y.key) && allFiscalMeters.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A well cannot be directly linked to a Fiscal Meter");
            }

            //You can't Link Well to POS
            invalidlinkings = links.Where(x => (allWells.Any(y => x.from == y.key) && allPOS.Any(y => x.to == y.key)) || (allWells.Any(y => x.to == y.key) && allPOS.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A well cannot be directly linked to a POS");
            }

            //You can't Link PD Meter to POS
            invalidlinkings = links.Where(x => (allPDMeters.Any(y => x.from == y.key) && allPOS.Any(y => x.to == y.key)) || (allPDMeters.Any(y => x.to == y.key) && allPOS.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A PD Meter cannot be directly linked to a POS");
            }

            //You can't Link Normal Meter to POS
            invalidlinkings = links.Where(x => (allNormalMeters.Any(y => x.from == y.key) && allPOS.Any(y => x.to == y.key)) || (allNormalMeters.Any(y => x.to == y.key) && allPOS.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A Normal Meter cannot be directly linked to a POS");
            }
            //You can't Link Facility to POS
            invalidlinkings = links.Where(x => (allFacility.Any(y => x.from == y.key) && allPOS.Any(y => x.to == y.key)) || (allFacility.Any(y => x.to == y.key) && allPOS.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A facility cannot be directly linked to a POS");
            }

            //You can't Link Pipeline to POS
            invalidlinkings = links.Where(x => (allPipelines.Any(y => x.from == y.key) && allPOS.Any(y => x.to == y.key)) || (allPipelines.Any(y => x.to == y.key) && allPOS.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A Pipeline cannot be directly linked to a POS");
            }

            //You can't Link Well to Well
            invalidlinkings = links.Where(x => (allWells.Any(y => x.from == y.key) && allWells.Any(y => x.to == y.key)) || (allWells.Any(y => x.to == y.key) && allWells.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A well cannot be directly linked to another well");
            }

            //You can't Link Facility to Facility
            invalidlinkings = links.Where(x => (allFacility.Any(y => x.from == y.key) && allFacility.Any(y => x.to == y.key)) || (allFacility.Any(y => x.to == y.key) && allFacility.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A facility cannot be directly linked to another facility");
            }

            //You can't Link Normal Meter to Normal Meter
            invalidlinkings = links.Where(x => (allNormalMeters.Any(y => x.from == y.key) && allNormalMeters.Any(y => x.to == y.key)) || (allNormalMeters.Any(y => x.to == y.key) && allNormalMeters.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A Normal Meter cannot be directly linked to another Normal meter");
            }
            //You can't Link PD Meter to PD Meter
            invalidlinkings = links.Where(x => (allPDMeters.Any(y => x.from == y.key) && allPDMeters.Any(y => x.to == y.key)) || (allPDMeters.Any(y => x.to == y.key) && allPDMeters.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A PD Meter cannot be directly linked to another PD Meter");
            }

            //You can't Link POS Meter to POS
            invalidlinkings = links.Where(x => (allPOS.Any(y => x.from == y.key) && allPOS.Any(y => x.to == y.key)) || (allPOS.Any(y => x.to == y.key) && allPOS.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A POS cannot be linked to another POS");
            }

            //You can't Link Pipeline Meter to Pipeline
            invalidlinkings = links.Where(x => (allPipelines.Any(y => x.from == y.key) && allPipelines.Any(y => x.to == y.key)) || (allPipelines.Any(y => x.to == y.key) && allPipelines.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A Pipeline cannot be directly linked to another Pipeline");
            }

            //You can't Link Fiscal Meter to Fiscal Meter
            invalidlinkings = links.Where(x => (allFiscalMeters.Any(y => x.from == y.key) && allFiscalMeters.Any(y => x.to == y.key)) || (allFiscalMeters.Any(y => x.to == y.key) && allFiscalMeters.Any(y => x.from == y.key))).ToList();
            if (invalidlinkings.Count > 0)
            {
                validationMessages.Add("A fiscal Meter cannot be directly linked to another Fiscal Meter");
            }

            return validationMessages;
        }      

        public int CreateAsset(List<Nodes> nodes, List<Links> links)
        {

            List<Links> existingLinks = new List<Links>();

            if (links != null)
            {
                existingLinks = _context.Links.Where(x => x.TenantID == links.First().TenantID).ToList();
                if (existingLinks != null)
                {
                    _context.Links.RemoveRange(existingLinks);
                }

                _context.Links.AddRange(links);

                _context.SaveChanges();

             
            }
            List<Nodes> existingNodes = new List<Nodes>();

            if (nodes != null)
            {
                existingNodes = _context.Nodes.Where(x => x.TenantID == nodes.First().TenantID).ToList();
                if (existingNodes != null)
                {
                    _context.Nodes.RemoveRange(existingNodes);
                }

                _context.Nodes.AddRange(nodes);

                //Create Assets
                var allNormalMeters = nodes.Where(x => x.category == "Normal Meter");
                var allPipelines = nodes.Where(x => x.category == "HBar");
                var allPDMeters = nodes.Where(x => x.category == "PD Meter");
                var allFacility = nodes.Where(x => x.category == "Facility");
                var allFiscalMeters = nodes.Where(x => x.category == "Fiscal Meter");
                var allPOS = nodes.Where(x => x.category == "POS");
                var allWells = nodes.Where(x => x.category == "OilWell");

                List<Nodes> allMeters = new List<Nodes>();
                allMeters.AddRange(allNormalMeters);
                allMeters.AddRange(allPDMeters);
                allMeters.AddRange(allFiscalMeters);

                //Save All Wells
                List<Well> wells = new List<Well>();
                var field = _context.Field.First();
                var tenant = _context.Tenants.First();
                foreach (var item in allWells)
                {                 
                    wells.Add(new Well { ActualCompletionDays = 0, ActualMeasuredDepth = 0, ActualTotalVerticalDepth = 0, ActualWellCostDollar = 0, Approvedby = "Admin", BlockNumber = "", BlockType = "OML", BottomCoordinateLatitude = "", BottomCoordinateLongitude = "", BottomHoleAge = "", CompletionDate = DateTime.Now, ConventionalCore = "", Createdby = "Admin", DateApproved = DateTime.Now, DateCreated = DateTime.Now, Depth = 0, DepthRef = "", DepthRefElevation = 0, DrillPermitNo = "", EstimatedWellCostDollar = 0, EstimatedWellCostNaira = 0, ExchangeRate = 0, Field = field, FieldName = "", GroundLevel = "", Latitude = "", LocationName = "", Longitude = "", MeasureDepth = 0, OperatorID = "", ProductionDate = DateTime.Now, ProposedCompletionDays = 0, ProposedTotalDepth = 0, ProposedTotalVerticalDepth = 0, RigOwner = "", RigType = "", SidewallCore = "", SpudDate = DateTime.Now, Status = "Active", SurfaceCoordinateLatitude = "", SurfaceCoordinateLongitude = "", TargetedFormation = "", Tenants = tenant, Terrain = "", TypeOfCompletion = "", UWI = "", WaterDepth = 0, WellAlias = item.text, WellBoreType = "", WellClassification = "", WellContent = "", WellName = item.text, WellPurpose = "", WellStatus = "", WellStatusDate = DateTime.Now, WellType = "" });
                }
                _context.Well.AddRange(wells);

                //Save All Facilities
                List<Facilities> facilities = new List<Facilities>();
                foreach (var item in allFacility)
                {
                    facilities.Add(new Facilities { Capacity_per_day = 0, Comment = "", CommissionDate = DateTime.Now, Createdby = "Admin", DateCreated = DateTime.Now, Description = "", DesignLife = 0, DPRPermitNumber = "", FacilityName = item.text, FacilityStatus = "", FacilityType = "", FluidType = "", Latitude = "", LocationName = "", Longitude = "", Operating_Capacity_gas = 0, Operating_Capacity_water = 0, OperatorID = 1, StartupDate = DateTime.Now, StorageCapacity = 0, Tenants = tenant, Terrain = "", Waterdepth = 0 });
                }
                _context.Facilities.AddRange(facilities);

                //Save All Pipleines
                List<Pipelines> pipelines = new List<Pipelines>();
                foreach (var item in allPipelines)
                {
                    pipelines.Add(new Pipelines { PipelineName = item.text, TenantID = item.TenantID });
                }
                _context.Pipelines.AddRange(pipelines);

                //Save All POS
                List<POS> pOs = new List<POS>();
                foreach (var item in allPOS)
                {
                    pOs.Add(new POS { Pipelines = pipelines.First(), POSName = item.text, TenantID=item.TenantID });
                }
                _context.POS.AddRange(pOs);

                //Save All Metters
                List<Meters> meters = new List<Meters>();
                foreach (var item in allMeters)
                {
                    meters.Add(new Meters { MeterType = item.category, MeterFactor = 1, Name=item.text , TenantID=item.TenantID});
                }
                _context.Meters.AddRange(meters);

                _context.SaveChanges();                               
            }

            return 1;
        }           

        public AssetDiagramModel GetAssets(int tenantID)
        {
            AssetDiagramModel asset = new AssetDiagramModel();
            List<LinkDataArray> linkData = new List<LinkDataArray>();
            List<NodeDataArray> nodeData = new List<NodeDataArray>();

            var nodes = _context.Nodes.Where(x => x.TenantID == tenantID);

            var links = _context.Links.Where(x => x.TenantID == tenantID);

            foreach (var item in nodes)
            {
                nodeData.Add(new NodeDataArray { category = item.category, key = item.key, location = item.location, size = item.size, text = item.text });
            }

            foreach (var item in links)
            {
                linkData.Add(new LinkDataArray { from = item.from, to = item.to });
            }

            asset.linkDataArray = linkData;
            asset.nodeDataArray = nodeData;
            asset.@class = "GraphLinksModel";

            return asset;
        }
    }
}
