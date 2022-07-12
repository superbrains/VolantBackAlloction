using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolantBackAlloction.Controllers
{
    public class PipeLineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
