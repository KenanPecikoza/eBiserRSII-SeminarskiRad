using eBiser.Data;
using eBiserMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBiserMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DonacijeDetails : ContentPage
    {
        private DonacijaDetailsViewModel model = null;

        public DonacijeDetails(eBiser.Data.Donacije donacije)
        {
            InitializeComponent();
            BindingContext = model = new DonacijaDetailsViewModel()
            {
                Donacije = donacije
            };
        }
    }
}