using eBiser.Data;
using eBiser.Data.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBiserMobileApp.ViewModels
{
    public class DonacijeViewModel :BaseViewModel
    {
        private readonly APIService _apiService = new APIService("Donacije");

        public DonacijeViewModel()
        {
            InitCommand = new Command(async () => await Init());
            InitCommand.Execute(null);

        }
        public ICommand InitCommand { get; set; }

        public ObservableCollection<Donacije> Donacije { get; set; } = new ObservableCollection<Donacije>();
        public async Task Init()
        {

            DonacijeSearchRequest searchRequest = new DonacijeSearchRequest {
             KorisnikSistemaId = APIService.Id
            };
            var list = await _apiService.Get<List<Donacije>>(searchRequest);
            Donacije.Clear();
            foreach (var i in list)
            {
                Donacije.Add(i);
            }

        }
    }
}
