using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StartupExample.Models;

namespace StartupExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFridge _fridgeService;
        private readonly IFoodService _foodService;

        public HomeController(IFridge fridgeService, IFoodService foodService)
        {
            _fridgeService = fridgeService;
            _foodService = foodService;
        }

        public IActionResult Index()
        {
            var isFridgedUpDude = _fridgeService.ChangeTempature(2);

            ViewData["isFridgedUpDude"] = isFridgedUpDude;

            return View();
        }

        public IActionResult Hello()
        {
            var viewModel = new HelloViewModel("Hello world!", new List<string>()
            {
                "Hello",
                "Is",
                "It",
                "Me",
                "You're",
                "Looking",
                "For"
            });

            return View(viewModel);
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
