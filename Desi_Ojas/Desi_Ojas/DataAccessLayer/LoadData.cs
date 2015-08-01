using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Desi_Ojas.DataAccessLayer
{
    public class LoadData
    {
        /// <summary>
        /// Gets the tops data.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetTopsData()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Desidime-Client", Helpers.Helper.clientId);
            var responseString = await client.GetStringAsync(
            new Uri(Helpers.Helper.baseUri+"/v1/deals/top.json"));
            return responseString;
        }

        /// <summary>
        /// Gets the popular data.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetPopularData()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Desidime-Client", Helpers.Helper.clientId);
            var responseString = await client.GetStringAsync(
            new Uri(Helpers.Helper.baseUri + "/v1/deals/popular.json"));
            return responseString;
        }

    }
}
