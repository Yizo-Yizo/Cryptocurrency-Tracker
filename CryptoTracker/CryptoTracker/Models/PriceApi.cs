using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoTracker.Models
{
    public class Ethereum
    {
        public int zar { get; set; }
        public double zar_market_cap { get; set; }
        public double zar_24h_vol { get; set; }
        public double zar_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Polkadot
    {
        public double zar { get; set; }
        public double zar_market_cap { get; set; }
        public double zar_24h_vol { get; set; }
        public double zar_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Tether
    {
        public double zar { get; set; }
        public double zar_market_cap { get; set; }
        public double zar_24h_vol { get; set; }
        public double zar_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Loopring
    {
        public double zar { get; set; }
        public double zar_market_cap { get; set; }
        public double zar_24h_vol { get; set; }
        public double zar_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Solana
    {
        public double zar { get; set; }
        public double zar_market_cap { get; set; }
        public double zar_24h_vol { get; set; }
        public double zar_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Bitcoin
    {
        public int zar { get; set; }
        public double zar_market_cap { get; set; }
        public double zar_24h_vol { get; set; }
        public double zar_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Dogecoin
    {
        public double zar { get; set; }
        public double zar_market_cap { get; set; }
        public double zar_24h_vol { get; set; }
        public double zar_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Cardano
    {
        public double zar { get; set; }
        public double zar_market_cap { get; set; }
        public double zar_24h_vol { get; set; }
        public double zar_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Polkastarter
    {
        public double zar { get; set; }
        public double zar_market_cap { get; set; }
        public double zar_24h_vol { get; set; }
        public double zar_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Aelf
    {
        public double zar { get; set; }
        public double zar_market_cap { get; set; }
        public double zar_24h_vol { get; set; }
        public double zar_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class Gas
    {
        public double zar { get; set; }
        public double zar_market_cap { get; set; }
        public double zar_24h_vol { get; set; }
        public double zar_24h_change { get; set; }
        public int last_updated_at { get; set; }
    }

    public class PriceApi
    {
        public Ethereum ethereum { get; set; }
        public Polkadot polkadot { get; set; }
        public Tether tether { get; set; }
        public Loopring loopring { get; set; }
        public Solana solana { get; set; }
        public Bitcoin bitcoin { get; set; }
        public Dogecoin dogecoin { get; set; }
        public Cardano cardano { get; set; }
        public Polkastarter polkastarter { get; set; }
        public Aelf aelf { get; set; }
        public Gas gas { get; set; }
    }
}
