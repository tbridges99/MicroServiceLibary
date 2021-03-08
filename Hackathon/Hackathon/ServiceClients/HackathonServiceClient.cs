using Hackathon.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.ServiceClients
{
    public class HackathonServiceClient : IHackathonServiceClient
    {
        private HttpClient client = new HttpClient();
        const string baseURL = "http://localhost:57020";

        public async Task<List<ServiceDTO>> GetServicesAsync(string keywords)
        {
            var url = $"{baseURL}/ServiceDirectory/Get";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Content = new StringContent(keywords, Encoding.UTF8, "application/json");
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var results = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ServiceDTO>>(results);
            }
            return new List<ServiceDTO>();
        }
    }
}
