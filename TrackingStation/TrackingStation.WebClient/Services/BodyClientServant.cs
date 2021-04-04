using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TrackingStation.WebClient.Models;

namespace TrackingStation.WebClient.Services
{
    public class BodyClientServant : IBodyClientServant
    {
        private HttpClient HttpClient { get; }

        public BodyClientServant(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<IEnumerable<BodyModel>> GetAllBodies()
        {
            using HttpResponseMessage response = await HttpClient.GetAsync("api/bodies");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<IEnumerable<BodyModel>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
