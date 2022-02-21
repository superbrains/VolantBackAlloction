using Microsoft.AspNetCore.Mvc;

namespace VolantBackAlloction.Controllers
{
    public class DailyWellReadingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
