using CryptoTracker.Interfaces;
using CryptoTracker.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.Services
{
    public class UserDataService : IUserDataService
    {
        private HttpClient _client;
        private const string LoginWebServiceUrl = "https://localhost:7055/api/Users";
        public UserDataService(HttpClient client)
        {
            _client = client;
        }
        public async Task AddUser(Users newUser)
        {

            var stringContent = JsonConvert.SerializeObject(newUser);

            var content = new StringContent(stringContent, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(LoginWebServiceUrl, content);
        }

        public Task DeleteUser(int userId)
        {
            var stringContent = JsonConvert.SerializeObject(newUser);

            var content = new StringContent(stringContent, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(LoginWebServiceUrl, content);
        }

        public async Task<IEnumerable<Users>> GetAllUsers()
        {
            throw new NotImplementedException();
            //return await _client.GetAsync<Users[]>("api/Users");
        }

        public Task UpdateUser(Users user, int id)
        {
            throw new NotImplementedException();
        }

        Task<Users> IUserDataService.GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
