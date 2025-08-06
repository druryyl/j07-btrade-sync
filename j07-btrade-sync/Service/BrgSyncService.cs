using RestSharp;
using System.Collections.Generic;
using System.Configuration;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace j07_btrade_sync
{
    public class BrgSyncService
    {
        //  SYNC BRG
        public async Task<(bool, string)> SyncBrg(IEnumerable<BrgType> listBrg)
        {
            //  BUILD
            var baseUrl = ConfigurationManager.AppSettings["btrade-cloud-base-url"];
            var endpoint = $"{baseUrl}/api/Brg";
            var client = new RestClient(endpoint);

            //  serialize object cmd to json using System.Text.Json
            var requestBody = JsonSerializer.Serialize(new BrgSyncCommand(listBrg));

            var req = new RestRequest()
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

    public class BrgSyncCommand
    {
        public BrgSyncCommand(IEnumerable<BrgType> listBrg)
        {
            ListBrg = new List<BrgType>(listBrg);
        }
        public List<BrgType> ListBrg { get; set; }
    }
}
