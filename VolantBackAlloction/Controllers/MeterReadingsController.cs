using Microsoft.AspNetCore.Mvc;

namespace VolantBackAlloction.Controllers
{
    public class MeterReadingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
