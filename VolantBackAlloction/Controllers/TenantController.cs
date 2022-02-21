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

            return View(tenant);
        }

        public IActionResult Save(TenantVM model)
        {
            _tenantService.Create(model);

            return RedirectToAction("Index");
        }
    }
}
