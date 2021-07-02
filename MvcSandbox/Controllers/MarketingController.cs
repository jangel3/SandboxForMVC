using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSandbox.Controllers
{
    public class MarketingController : Controller
    {
        [MobileRedirectActionFilter(Action = "NewSplash", Controller = "Marketing")]
        public IActionResult Splash()
        {
            return Content("The old splash page.");
        }

        public IActionResult NewSplash()
        {
            return Content("The new splash page.");
        }
    }
}
