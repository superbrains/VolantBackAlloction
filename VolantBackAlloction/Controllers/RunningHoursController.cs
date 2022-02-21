using Microsoft.AspNetCore.Mvc;

namespace VolantBackAlloction.Controllers
{
    public class RunningHoursController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
