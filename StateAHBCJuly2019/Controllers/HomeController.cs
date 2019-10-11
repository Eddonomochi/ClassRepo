using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StateAHBCJuly2019.Models;

namespace StateAHBCJuly2019.Controllers
{
    public class HomeController : Controller
    {
        private ISession _session;
        private string _cookieBoy;

        public HomeController(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
            _cookieBoy = httpContextAccessor.HttpContext.Request.Cookies["cookie-boy"];
        }
        public IActionResult Index()
        {
            ViewData["cookie-boy"] = _cookieBoy;
            ViewData["session-boy"] = _session.GetString("session-boy");
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
