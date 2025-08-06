using j07_btrade_sync.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace j07_btrade_sync.Service
{
    public class WilayahSyncService
    {
        public async Task<(bool Success, string ErrorMessage)> SyncWilayah(IEnumerable<WilayahType> listWilayah)
        {
            // BUILD
            var baseUrl = ConfigurationManager.AppSettings["btrade-cloud-base-url"];
            var endpoint = $"{baseUrl}/api/Wilayah";  
            var client = new RestClient(endpoint);

            // Serialize using System.Text.Json
            var requestBody = JsonSerializer.Serialize(new WilayahSyncCommand(listWilayah));
            var req = new RestRequest()
                .AddJsonBody(requestBody);

            // EXECUTE
            var response = await client.ExecutePostAsync(req);

            return response.StatusCode == HttpStatusCode.OK
                ? (true, string.Empty)
                : (false, response.ErrorMessage ?? response.Content);
        }
    }

    public class WilayahSyncCommand
    {
        public WilayahSyncCommand(IEnumerable<WilayahType> listWilayah)
        {
            ListWilayah = new List<WilayahType>(listWilayah);
        }

        public List<WilayahType> ListWilayah { get; set; }
    }
}
