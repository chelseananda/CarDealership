using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Controllers
{
    public class DealerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
