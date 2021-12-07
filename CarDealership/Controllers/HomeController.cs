using CarDealership.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRepository memoRepository;

        public HomeController(ILogger<HomeController> logger, IRepository repository)
        {
            _logger = logger;
            memoRepository = repository;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View(memoRepository.Memos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult AddMemo (Memo memo)
        {
            memoRepository.AddMemo(memo);
            return RedirectToAction("Index");
        }

        
    }
}
