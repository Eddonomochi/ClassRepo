using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCValidationAHBCJuly2019.Models;
using MVCValidationAHBCJuly2019.Services;

namespace MVCValidationAHBCJuly2019.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaxCalculator _taxCalculator;

        public HomeController(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }

        public IActionResult Index()
        {
            var result = _taxCalculator.Calculate(100);
            return View();
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
    }
}
