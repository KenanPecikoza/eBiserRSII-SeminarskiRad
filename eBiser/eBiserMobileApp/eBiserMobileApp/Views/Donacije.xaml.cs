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
    public partial class Donacije : ContentPage
    {
        public Donacije()
        {
            InitializeComponent();
        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as eBiser.Data.Donacije;
            await Navigation.PushAsync(new DonacijeDetails(item));
        }
    }
}