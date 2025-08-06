using j07_btrade_sync.Model;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace j07_btrade_sync.Service
{
    public class CustomerSyncService
    {
        public async Task<(bool, string)> SyncCustomer(IEnumerable<CustomerType> listCustomer)
        {
            //  BUILD
            var baseUrl = System.Configuration.ConfigurationManager.AppSettings["btrade-cloud-base-url"];
            var endpoint = $"{baseUrl}/api/Customer";
            var client = new RestClient(endpoint);
            //  serialize object cmd to json using System.Text.Json
            var requestBody = System.Text.Json.JsonSerializer.Serialize(new CustomerSyncCommand(listCustomer));
            var req = new RestRequest()
                .AddJsonBody(requestBody);
            //  EXECUTE
            var response = await client.ExecutePostAsync(req);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                return (false, response.ErrorMessage);
            }
            else
            {
                return (true, "");
            }
        }
    }

    public class CustomerSyncCommand 
    {
        public CustomerSyncCommand(IEnumerable<CustomerType> listCustomer)
        {
            ListCustomer = new List<CustomerType>(listCustomer);
        } 

        public List<CustomerType> ListCustomer { get; set; }
    }
}
