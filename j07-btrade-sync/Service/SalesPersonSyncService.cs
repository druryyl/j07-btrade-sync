using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace j07_btrade_sync.Service
{
    public class SalesPersonSyncService
    {
        public async Task<(bool, string)> SyncSalesPerson(IEnumerable<Model.SalesPersonType> listSalesPerson)
        {
            //  BUILD
            var baseUrl = System.Configuration.ConfigurationManager.AppSettings["btrade-cloud-base-url"];
            var endpoint = $"{baseUrl}/api/SalesPerson";
            RestClient client = new RestSharp.RestClient(endpoint);
            
            //  serialize object cmd to json using System.Text.Json
            var requestBody = System.Text.Json.JsonSerializer.Serialize(new SalesPersonSyncCommand(listSalesPerson));
            
            var req = new RestSharp.RestRequest()
                .AddJsonBody(requestBody);
            
            //  EXECUTE
            var response = await client.ExecutePostAsync(req);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return (false, response.ErrorMessage);
            }
            else
            {
                return (true, "");
            }
        }
    }

    public class SalesPersonSyncCommand
    {
        public SalesPersonSyncCommand(IEnumerable<Model.SalesPersonType> listSalesPerson)
        {
            ListSalesPerson = new List<Model.SalesPersonType>(listSalesPerson);
        }
        public List<Model.SalesPersonType> ListSalesPerson { get; set; }
    }
}
