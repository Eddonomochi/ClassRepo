using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogApiApp.Models;

namespace DogApiApp.Services
{
    public interface IDogFacade
    {
        Task<DogViewModel> GetDogViewModel();
    }
}
