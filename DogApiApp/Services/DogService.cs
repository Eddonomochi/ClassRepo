using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DogApiApp.Services
{
    public class DogService : IDogService
    {
        public async Task<DogResponse> GetDog()
        {
            using (var httpClient = new HttpClient { BaseAddress = new Uri("https://swapi.co") })
            {
                var result = await httpClient.GetStringAsync("/api/planets");
                return JsonConvert.DeserializeObject<DogResponse>(result);
            }
        }
    }
}
