using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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

        public async Task<BodyModel> GetSpecificBody(string bodyName)
        {
            using HttpResponseMessage response = await HttpClient.GetAsync("api/bodies/" + bodyName);

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<BodyModel>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<BodyModel> AddBody(InputBody newBody)
        {
            string newBodyJson = JsonSerializer.Serialize(newBody);
            HttpContent bodyContent = new StringContent(newBodyJson, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await HttpClient.PutAsync("api/bodies", bodyContent);

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<BodyModel>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<BodyModel> EditBody(InputBody editedBody)
        {
            string editedBodyJson = JsonSerializer.Serialize(editedBody);
            HttpContent bodyContent = new StringContent(editedBodyJson, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await HttpClient.PatchAsync("api/bodies", bodyContent);

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<BodyModel>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<BodyModel> DeleteBody(string bodyName)
        {
            using HttpResponseMessage response = await HttpClient.DeleteAsync("api/bodies/" + bodyName);

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<BodyModel>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
