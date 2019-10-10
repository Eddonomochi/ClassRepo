using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCValidationAHBCJuly2019.Models;
using MVCValidationAHBCJuly2019.Services;

namespace MVCValidationAHBCJuly2019.Controllers
{
    public class TaxCalculatorController : Controller
    {
        private ITaxCalculator _taxCalculator;

        public TaxCalculatorController(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }

        public IActionResult CalculationResult(TaxCalculatorViewModel model)
        {
             if (!ModelState.IsValid)
            {
                return View("Error", new ErrorViewModel()
                {
                    Message = "Please pass in a number range between 1,000 and 2,000... ya dingus!"
                });
            }

            // DO THIS IN A SEPARATE SERVICE
            var newModel = new TaxCalculatorResultViewModel();
            newModel.Total = _taxCalculator.Calculate(model.SubTotal);

            return View(newModel);
        }

        public IActionResult Calculator()
        {
            return View();
        }
    }
}