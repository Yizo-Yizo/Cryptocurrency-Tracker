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
        private const string LoginWebServiceUrl = "https://192.168.18.5//api/Users";
        
        public UserDataService(HttpClient client)
        {
            _client = client;
        }
        public async Task AddUser(Users newUser)
        {

            var stringContent = JsonConvert.SerializeObject(newUser);

            var content = new StringContent(stringContent, Encoding.UTF8, "application/json");

            await _client.PostAsync(LoginWebServiceUrl, content);
        }

        public async Task DeleteUser(int userId)
        {
            await _client.DeleteAsync($"https://192.168.18.5//api/Users{userId}");
        }

        public async Task<IEnumerable<Users>> GetAllUsers()
        {
            string usersString = await _client.GetStringAsync(LoginWebServiceUrl);
            var users = JsonConvert.DeserializeObject<IEnumerable<Users>>(usersString);
            return users;
        }

        public async Task UpdateUser(Users user, int id)
        {
            var stringContent = JsonConvert.SerializeObject(user);

            var content = new StringContent(stringContent, Encoding.UTF8, "application/json");

            await _client.PutAsync($"https://192.168.18.5//api/Users{id}", content);
        }
    }
}
