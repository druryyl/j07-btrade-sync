using RestSharp;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace j07_btrade_sync.Service
{
    public class CustomerClearUpdateFlagService
    {
        public async Task<(bool, string)> Execute()
        {
            //  BUILD
            var baseUrl = ConfigurationManager.AppSettings["btrade-cloud-base-url"];
            var endpoint = $"{baseUrl}/api/Customer/ClearUpdatedFlag";
            var client = new RestClient(endpoint);
            var req = new RestRequest();
            req.AddHeader("Content-Type", "application/json");
            req.AddJsonBody(new { }); 

            //  EXECUTE
            var response = await client.ExecutePatchAsync(req);
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
}
