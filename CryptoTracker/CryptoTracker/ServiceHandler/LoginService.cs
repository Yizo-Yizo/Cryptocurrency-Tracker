using CryptoTracker.Models;
using CryptoTracker.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.ServiceHandler
{
    public class LoginService
    {
        readonly RestClient<Users> _restClient = new RestClient<Users>();

        public async Task<bool> CheckLoginifExists(string email, string password)
        {
            var check = await _restClient.Checklogin(email, password);
            return check;
        }
    }
}
