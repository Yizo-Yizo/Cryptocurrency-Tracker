using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace CryptoTracker.Droid
{
    public class Http
    {
        //private HttpClient _httpClient;
        
        //Bypass the certificate security check
        public HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert.Issuer.Equals("CN=localhost"))
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
            return handler;
        }

        /*public HttpClient HttplicentAccount
        {
            get
            {
                _httpClient = _httpClient ?? new HttpClient
                (
                    new HttpClientHandler()
                    {
                        ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
                        {
                    //bypass
                    return true;
                        },
                    }
                    , false
                )
                {
                    BaseAddress = new Uri("https://10.0.2.2:7250/api/AppUsers"),
                };

                // In case you need to send an auth token...
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Authorization", "YOUR_TOKEN");
                return _httpClient;
            }
        }*/
    }

}