using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstWebAppAHBCJULY2019.Models;

namespace FirstWebAppAHBCJULY2019.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Hello()
        {
            var people = new List<string>();
            people.Add("James");
            people.Add("Edward");
            people.Add("Ed");
            people.Add("Victoria");
            people.Add("Rob");

            var isABabyBoy = true;

            var helloModel = new HelloModel();
            helloModel.IsABabyBoy = isABabyBoy;
            helloModel.People = people;

            return View(helloModel);
        }

        public IActionResult Index()
        {
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
