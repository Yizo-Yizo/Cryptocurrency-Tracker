using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.Services
{
    public class RestClient<T>
    {
        private const string MainWebServiceUrl = "https://localhost:7055/";
        private const string LoginWebServiceUrl = "http://192.168.18.5/api/Users";

        public async Task<bool> Checklogin(string email, string password)
        {
            var httpClient = new HttpClient();
            
            var credentials = new {email = email, password = password};

            var stringContent = JsonConvert.SerializeObject(credentials);

            var content = new StringContent(stringContent, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(LoginWebServiceUrl, content);

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return false;

            if (response.StatusCode == HttpStatusCode.OK)
                return true;

            return false;
        }
    }
}
