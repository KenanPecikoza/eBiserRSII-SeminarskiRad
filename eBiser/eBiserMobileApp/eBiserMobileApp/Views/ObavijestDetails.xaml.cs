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
    public partial class ObavijestDetails : ContentPage
    {
        private ObavijestiDetailViewModel model = null;
        public ObavijestDetails(Obavijest obavijest )
        {
            InitializeComponent();
            BindingContext = model = new ObavijestiDetailViewModel(obavijest.Id)
            {
                obavijest = obavijest
            };
            model.initCommand.Execute(null);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Obavijest Obavijest = ((Button)sender).BindingContext as Obavijest;
            Navigation.PushAsync(new ObavijestDetails(Obavijest));
        }
    }
}