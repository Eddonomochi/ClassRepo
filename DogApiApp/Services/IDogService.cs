using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogApiApp.Services
{
    public interface IDogService
    {
        Task<DogResponse> GetDog();
    }
}
