using CryptoTracker.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.Services
{
    public class PriceDataService
    {
        public const string BASE_URL = "https://api.coingecko.com/api/v3/simple/price?ids=bitcoin%2Csolana%2Cethereum%2Ccardano%2Caelf%2Cpolkastarter%2Cloopring%2Csagepal%2Cpancakeswap%2Cgas%2Cchromia%2Ctether%2Cxrp%2Cpolkadot%2Cdogecoin%2Cavalanche%2Cpolygon&vs_currencies=zar&include_market_cap=true&include_24hr_vol=true&include_24hr_change=true&include_last_updated_at=true";
        
        public static async Task<PriceApi> GetPriceApiAsync()
        {
            PriceApi priceApi = new PriceApi();
            var url = BASE_URL;
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var posts = JsonConvert.DeserializeObject<PriceApi>(content);
                priceApi = posts;
            }
            return priceApi;
        }
    }
}
