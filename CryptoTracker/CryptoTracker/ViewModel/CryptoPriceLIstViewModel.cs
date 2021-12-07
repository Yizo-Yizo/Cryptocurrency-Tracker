using CryptoTracker.Models;
using CryptoTracker.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.ViewModel
{
    public class CryptoPriceLIstViewModel
    {
        public IList<CryptoCoinInfo> CryptoCoinInfo { get; set; }
        private IList<PriceApi> _priceList;
        public IList<PriceApi> PriceList
        {
            get
            {
                if (_priceList == null)
                    _priceList = new ObservableCollection<PriceApi>();
                return _priceList;
            }
            set
            {
                _priceList = value;
            }
        }
        public async Task APIAsync()
        {
            var price = await PriceDataService.GetPriceApiAsync();
            PriceList.Add(price);

            
            CryptoCoinInfo.Add(new CryptoCoinInfo { Name = "Ethereum", Price = price.ethereum.zar, MarketCap = price.ethereum.zar_market_cap, Volume24hours = price.ethereum.zar_24h_vol });
            CryptoCoinInfo.Add(new CryptoCoinInfo { Name = "Polkadot", Price = price.polkadot.zar, MarketCap = price.polkadot.zar_market_cap, Volume24hours = price.polkadot.zar_24h_vol });
            CryptoCoinInfo.Add(new CryptoCoinInfo { Name = "Tether", Price = price.tether.zar, MarketCap = price.tether.zar_market_cap, Volume24hours = price.tether.zar_24h_vol });
            CryptoCoinInfo.Add(new CryptoCoinInfo { Name = "Loopring", Price = price.loopring.zar, MarketCap = price.loopring.zar_market_cap, Volume24hours = price.loopring.zar_24h_vol });
            CryptoCoinInfo.Add(new CryptoCoinInfo { Name = "Solana", Price = price.solana.zar, MarketCap = price.solana.zar_market_cap, Volume24hours = price.solana.zar_24h_vol });
            CryptoCoinInfo.Add(new CryptoCoinInfo { Name = "Bitcoin", Price = price.bitcoin.zar, MarketCap = price.bitcoin.zar_market_cap, Volume24hours = price.bitcoin.zar_24h_vol });
            CryptoCoinInfo.Add(new CryptoCoinInfo { Name = "Dogecoin", Price = price.dogecoin.zar, MarketCap = price.dogecoin.zar_market_cap, Volume24hours = price.dogecoin.zar_24h_vol });
            CryptoCoinInfo.Add(new CryptoCoinInfo { Name = "Cardano", Price = price.cardano.zar, MarketCap = price.cardano.zar_market_cap, Volume24hours = price.cardano.zar_24h_vol });
            CryptoCoinInfo.Add(new CryptoCoinInfo { Name = "Polkastarter", Price = price.polkastarter.zar, MarketCap = price.polkastarter.zar_market_cap, Volume24hours = price.polkastarter.zar_24h_vol });
            CryptoCoinInfo.Add(new CryptoCoinInfo { Name = "Aelf", Price = price.aelf.zar, MarketCap = price.aelf.zar_market_cap, Volume24hours = price.aelf.zar_24h_vol });
            CryptoCoinInfo.Add(new CryptoCoinInfo { Name = "Gas", Price = price.gas.zar, MarketCap = price.gas.zar_market_cap, Volume24hours = price.gas.zar_24h_vol });

        }
        public CryptoPriceLIstViewModel()
        {
            Task.Run(APIAsync);
            CryptoCoinInfo = new ObservableCollection<CryptoCoinInfo>();
        }
    }
}
