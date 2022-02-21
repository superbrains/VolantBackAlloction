using BAServices.Interfaces;
using BAServices.ViewModels.Facility;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolantBackAlloction.Controllers
{
    public class FacilityController : Controller
    {
        private readonly IFacility _facilityService;

        public FacilityController(IFacility facilityService)
        {
            _facilityService = facilityService;
        }
        public IActionResult Index()
        {
            FacilityData facility = new FacilityData();
            //Return Info 
            facility.FacilityModel = new FacilityVM();
            facility.FacilityList = _facilityService.GetAll();
            return View(facility);
        }

        public JsonResult Save(FacilityVM model)
        {
            try
            {
                _facilityService.Create(model);
                if (model.ID > 0)
                {
                    return Json("Facility Information has been updated successfully");
                }
                else
                {
                    return Json("A New Facility has been created successfully");
                }

            }
            catch (System.Exception ex)
            {

                return Json("An Error Occured " + ex.Message);
            }


        }

        public JsonResult Delete(int ID)
        {
            try
            {
                _facilityService.Delete(ID);

                return Json("Facility Deleted Successfully");

            }
            catch (System.Exception ex)
            {
                return Json("An Error Occured " + ex.Message);
            }

        }
    }
}
