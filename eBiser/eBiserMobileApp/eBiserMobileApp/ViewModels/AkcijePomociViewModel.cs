using eBiser.Data;
using eBiser.Data.Requests;
using eBiserMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBiserMobileApp.ViewModels
{
    class AkcijePomociViewModel : BaseViewModel
    {
        private readonly APIService _apiService = new APIService("AkcijePomoci");

        public AkcijePomociViewModel()
        {
            InitCommand = new Command(async () => await Init());
            ContactCommand = new Command(async () => await Contact());
            InitCommand.Execute(null);
        }
        public ObservableCollection<eBiser.Data.AkcijePomoci> AkcijePomoci { get; set; } = new ObservableCollection<eBiser.Data.AkcijePomoci>(); 
        

        public ICommand InitCommand { get; set; }
        public ICommand ContactCommand { get; set; }
        public async Task Init()
        {

            var list = await _apiService.Get<List<eBiser.Data.AkcijePomoci>>(null);
            AkcijePomoci.Clear();
            foreach (var i in list)
            {
                AkcijePomoci.Add(i);
            }

        }
        async Task Contact()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Doniraj());


        }
    }
}
