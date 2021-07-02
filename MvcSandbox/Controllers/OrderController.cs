using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSandbox.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Create(List<Order> orders)
        {
            return Content("Binding successful!");
        }
    }

    public class Order
    {
        public string ProductName { get; set; }
        public string Count { get; set; }
        public string Description { get; set; }
    }
}
