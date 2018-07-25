using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace RestAssesment
{
    public class RestService
    {
        public async Task<Response> RestServiceGet()
        {
            string path = @"http://services.groupkt.com/state/get/USA/all";
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(path);
            var reposeString = await response.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<Response>(reposeString);
            return obj;
        }

        public async Task<List<string>> Getdetails(string stateName)
        {
            var details = new List<string>();
            var resposne = await RestServiceGet();
            var states = resposne.RestResponse.Result;
            var state = states.Find(x => x.Name == stateName || x.Abbr == stateName);
            details.Add(state.Largest_City);
            details.Add(state.Capital);
            return details;
        }

    }
}
