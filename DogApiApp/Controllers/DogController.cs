using System.Threading.Tasks;
using DogApiApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DogApiApp.Controllers
{
    public class DogController : Controller
    {
        private readonly IDogFacade _dogFacade;

        public DogController(IDogFacade dogFacade)
        {
            _dogFacade = dogFacade;
        }

        public async Task<IActionResult> Dog()
        {
            var result = await _dogFacade.GetDogViewModel();
            return View(result);




         
        } 
    }
}