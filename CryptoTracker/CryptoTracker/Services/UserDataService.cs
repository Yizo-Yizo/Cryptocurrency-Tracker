using CryptoTracker.Interfaces;
using CryptoTracker.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.Services
{
    public class UserDataService : IUserDataService
    {
        private HttpClient _client;
        private const string LoginWebServiceUrl = "https://10.0.2.2:7250/api/AppUsers";
        
        public UserDataService(HttpClientHandler handler)
        {
            // Baypass security certificate
            handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            _client = new HttpClient(handler);
        }

        public async Task<bool> Register(string name, string surname, string email, string contactNumber, string password, string confirmPassword)
        {
            // Baypass security certificate
            /*HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            var httpClient = new HttpClient(handler);*/

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

            var content = new StringContent(stringContent);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await _client.PostAsync(LoginWebServiceUrl, content);

            return response.IsSuccessStatusCode;
        }


        public async Task DeleteUser(int userId)
        {
            await _client.DeleteAsync($"https://10.0.2.2:7250/api/AppUsers{userId}");
        }

        public async Task<IEnumerable<AppUser>> GetAllUsers()
        {
            string usersString = await _client.GetStringAsync(LoginWebServiceUrl);
            var users = JsonConvert.DeserializeObject<IEnumerable<AppUser>>(usersString);
            return users;
        }

        public async Task UpdateUser(AppUser user, int id)
        {
            var stringContent = JsonConvert.SerializeObject(user);

            var content = new StringContent(stringContent, Encoding.UTF8, "application/json");

            await _client.PutAsync($"https://10.0.2.2:7250/api/AppUsers{id}", content);
        }
    }
}
