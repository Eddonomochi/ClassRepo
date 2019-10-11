using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using StateAHBCJuly2019.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StateAHBCJuly2019.Controllers
{
    public class StateController : Controller
    {
        private readonly ISession _session;
        private IResponseCookies _responseCookie;

        public StateController(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
            _responseCookie = httpContextAccessor.HttpContext.Response.Cookies;
        }

        public IActionResult StateBoy()
        {
            ViewData["Name"] = "Shaun";

            ViewData["session-boy"] = _session.GetString("session-boy");

            TempData["SuperName"] = "Larry";

            return View();
        }

        public IActionResult SuperStateBoy()
        {
            var currentData = TempData["SuperName"];

            ViewData["session-boy"] = _session.GetString("session-boy");

            var transferBoy = currentData;

            return View("StateBoy");
        }

        public IActionResult SessionBoy()
        {
            _session.SetString("session-boy", "baby boy");

            ViewData["session-boy"] = _session.GetString("session-boy");

            ViewBag.SessionBoy = _session.GetString("session-boy");

            return View();
        }

        public IActionResult CookieBoy()
        {


            var options = new CookieOptions()
            {
                Expires = DateTime.Now.AddSeconds(45)
            };
            _responseCookie.Append("cookie-boy", "baby cookie boy", options);

            return View();
        }

    }
}
