using Microsoft.AspNetCore.Mvc;

namespace VolantBackAlloction.Controllers
{
    public class AssetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
