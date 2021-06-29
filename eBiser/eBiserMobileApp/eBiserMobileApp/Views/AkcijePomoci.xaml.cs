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
    public partial class AkcijePomoci : ContentPage
    {
        public AkcijePomoci()
        {
            InitializeComponent();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}