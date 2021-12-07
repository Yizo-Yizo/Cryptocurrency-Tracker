using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoTracker.Models
{
    public class CryptoCoinInfo
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double MarketCap { get; set; }  
        public double Volume24hours { get; set; }  

    }
}
