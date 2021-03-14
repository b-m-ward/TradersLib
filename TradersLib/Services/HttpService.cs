using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TradersLib.Configuration;
using TradersLib.Models;

namespace TradersLib.Services
{
    public class HttpService
    {
        IApplicationConfiguration _config;
        public HttpService(IApplicationConfiguration config)
        {
            _config = config;
        }


        public async Task<T> Get<T>(string url, string token = null) where T: BaseClass
        {
            try
            {
                HttpClient client = new HttpClient();
                if(!string.IsNullOrEmpty(token)) client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage respo = await client.GetAsync(_config.UrlRoot + url);
                respo.EnsureSuccessStatusCode();

                string responseBody = await respo.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(responseBody);

            }
            catch (Exception ex)
            {
                //log
                throw;
            }
            
        } 

        public async Task<T> Post<T>(string url, BaseClass body, string token = null) where T: BaseClass
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpContent content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
                if (!string.IsNullOrEmpty(token)) content.Headers.Add("Authorization", token);

                HttpResponseMessage respo = await client.PostAsync(_config.UrlRoot + url, content);
                respo.EnsureSuccessStatusCode();

                string responseBody = await respo.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(responseBody);

            }
            catch (Exception ex)
            {
                //log
                throw;
            }
        }
    }
}
