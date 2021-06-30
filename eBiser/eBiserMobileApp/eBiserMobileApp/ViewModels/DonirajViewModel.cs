using eBiser.Data;
using eBiser.Data.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBiserMobileApp.ViewModels
{
    public class DonirajViewModel :BaseViewModel
    {
        private readonly APIService _apiService = new APIService("Donacije");

        public DonirajViewModel()
        {
            DonirajCommand = new Command(async () => await Doniraj());

        }
        public ICommand DonirajCommand { get; set; }

        string _naslov = string.Empty;
        public string Naslov
        {
            get { return _naslov; }
            set { SetProperty(ref _naslov, value); }
        }
        string _opis = string.Empty;
        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }
        DonacijeUpsertRequest request = new DonacijeUpsertRequest();

        async Task Doniraj()
        {
            request.Naziv = Naslov;
            request.OpisDonacije = Opis;
            request.KorisniciSistemaId = APIService.Id;
            request.DatumPrijave = DateTime.Now;
            request.NaCekanju = true;
            try
            {
                var donacija = await _apiService.Insert<eBiser.Data.Donacije>(request);
                await Application.Current.MainPage.Navigation.PushAsync(new Views.Donacije());
                await Application.Current.MainPage.DisplayAlert("Uspješno", "Uspješno ste dodali prijedlog donacije očekujte odgovor uskoro", "OK");
            }
            catch (Exception )
            {
            }
        }
    }
}
