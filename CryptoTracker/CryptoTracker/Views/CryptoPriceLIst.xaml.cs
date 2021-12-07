using CryptoTracker.Models;
using CryptoTracker.Services;
using CryptoTracker.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CryptoTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CryptoPriceLIst : ContentPage
    {
        public IList<CryptoCoinInfo> CryptoCoinInfo { get; set; }
        public CryptoPriceLIst()
        {
            InitializeComponent();
        }
    }
}