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
    public class VesselClientServant : IVesselClientServant
    {
        private HttpClient HttpClient { get; }

        public VesselClientServant(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<IEnumerable<VesselModel>> GetAllVessels()
        {
            using HttpResponseMessage response = await HttpClient.GetAsync("api/vessels");

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<IEnumerable<VesselModel>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<VesselModel> GetSpecificVessel(string vesselName)
        {
            using HttpResponseMessage response = await HttpClient.GetAsync("api/vessels/" + vesselName);

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<VesselModel>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<VesselModel> AddVessel(InputVessel newVessel)
        {
            string newVesselJson = JsonSerializer.Serialize(newVessel);
            HttpContent vesselContent = new StringContent(newVesselJson, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await HttpClient.PutAsync("api/vessels", vesselContent);

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<VesselModel>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<VesselModel> EditVessel(InputVessel editedVessel)
        {
            string editedVesselJson = JsonSerializer.Serialize(editedVessel);
            HttpContent vesselContent = new StringContent(editedVesselJson, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await HttpClient.PatchAsync("api/vessels", vesselContent);

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            return JsonSerializer.Deserialize<VesselModel>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<VesselModel> DeleteVessel(string vesselName)
        {
            using HttpResponseMessage response = await HttpClient.DeleteAsync("api/vessels/" + vesselName);

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<VesselModel>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
