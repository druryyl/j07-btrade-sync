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
    public class KategoriSyncService
    {
        public async Task<(bool Success, string ErrorMessage)> SyncKategori(IEnumerable<KategoriType> listKategori)
        {
            // BUILD
            var baseUrl = ConfigurationManager.AppSettings["btrade-cloud-base-url"];
            var endpoint = $"{baseUrl}/api/Kategori";
            var client = new RestClient(endpoint);

            // Serialize using System.Text.Json
            var requestBody = JsonSerializer.Serialize(new KategoriSyncCommand(listKategori));
            var req = new RestRequest()
                .AddJsonBody(requestBody);

            // EXECUTE
            var response = await client.ExecutePostAsync(req);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                return (false, response.ErrorMessage ?? response.Content);
            }
            else
            {
                return (true, string.Empty);
            }
        }
    }

    public class KategoriSyncCommand
    {
        public KategoriSyncCommand(IEnumerable<KategoriType> listKategori)
        {
            ListKategori = new List<KategoriType>(listKategori);
        }

        public List<KategoriType> ListKategori { get; set; }
    }
}
