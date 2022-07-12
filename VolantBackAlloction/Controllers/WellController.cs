using BAServices.Interfaces;
using BAServices.ViewModels.Well;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolantBackAlloction.Controllers
{
    public class WellController : Controller
    {
        private readonly iWell _wellService;

        public WellController(iWell wellService)
        {
            _wellService = wellService;
        }
        public IActionResult Index()
        {
            WellData well = new WellData();
            //Return Info 
            well.WellModel = new WellVM();
            well.WellList = _wellService.GetAll();
            return View(well);
        }

        public JsonResult Save(WellVM model)
        {
            try
            {
                _wellService.Create(model);
                if (model.ID > 0)
                {
                    return Json("Well Information has been updated successfully");
                }
                else
                {
                    return Json("A New Well has been created successfully");
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
                _wellService.Delete(ID);

                return Json("Well Deleted Successfully");

            }
            catch (System.Exception ex)
            {
                return Json("An Error Occured " + ex.Message);
            }

        }
    }
}
