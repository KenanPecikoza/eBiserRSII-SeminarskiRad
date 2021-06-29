using eBiserMobileApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace eBiserMobileApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}