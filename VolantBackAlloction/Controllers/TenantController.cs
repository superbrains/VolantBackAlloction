using BAServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using VolantBackAlloction.ViewModels.Tenant;

namespace VolantBackAlloction.Controllers
{
    public class TenantController : Controller
    {
        private readonly ITenantService _tenantService;

        public TenantController(ITenantService tenantService)
        {
            _tenantService = tenantService;
        }
        public IActionResult Index()
        {
            TenantData tenant = new TenantData();
            //Return Info 
            tenant.TenantModel = new TenantVM();
            tenant.TenantList = _tenantService.GetAll();
            return View(tenant);
        }

        public JsonResult Save(TenantVM model)
        {
            try
            {
                _tenantService.Create(model);
                if (model.ID > 0)
                {
                    return Json("A New Tenant has been updated successfully");
                }
                else
                {
                    return Json("A New Tenant has been created successfully");
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
                _tenantService.Delete(ID);                            
               
                    return Json("Tenant Deleted Successfully");              

            }
            catch (System.Exception ex)
            {
                return Json("An Error Occured " + ex.Message);
            }

        }
    }
}
