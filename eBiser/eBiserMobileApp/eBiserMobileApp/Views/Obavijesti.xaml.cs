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
    public partial class Obavijesti : ContentPage
    {
        private ObavijestiViewModel model = null;
        public Obavijesti()
        {
            InitializeComponent();
            BindingContext = model = new ObavijestiViewModel();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }


        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Obavijest;
            await Navigation.PushAsync(new ObavijestDetails(item));
        }
    }
}