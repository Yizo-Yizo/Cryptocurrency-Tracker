using CryptoTracker.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.Services
{
    public class ApiServices
    {
        //private const string MainWebServiceUrl = "https://localhost:7055/";
        //private const string LoginWebServiceUrl = "http://localhost/api/Users";
        private const string LoginWebServiceUrl = "https://10.0.2.2:7250/api/AppUsers";

        public async Task<bool> Register(string name, string surname, string email, string contactNumber, string password, string confirmPassword)
        {
            var httpClient = new HttpClient();

            var credentials = new AppUser
            {
                Name = name,
                Surname = surname,
                Email = email,
                ContactNumber = contactNumber,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            var stringContent = JsonConvert.SerializeObject(credentials);

            var content = new StringContent(stringContent, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(LoginWebServiceUrl, content);

            return response.IsSuccessStatusCode;
        }
    }
}
