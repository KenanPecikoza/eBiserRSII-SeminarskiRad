using eBiser.Data;
using eBiser.Data.Requests;
using eBiserMobileApp.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBiserMobileApp.ViewModels
{
    public class ObavijestiDetailViewModel : BaseViewModel
    {
        private readonly APIService _apiService = new APIService("ObavijestOcjena");
        private readonly APIService _apiServiceRecommend = new APIService("Recommned");
        ObavijestOcjenaSearchRequest _searchRequest = new ObavijestOcjenaSearchRequest();
        ObavijestOcjenaUpsertRequest _upsertRequest = new ObavijestOcjenaUpsertRequest();


        public ICommand clickCommand { get; set; }
        public ICommand initCommand { get; set; }
        public ObavijestiDetailViewModel()
        {
            clickCommand = new Command(onClicked); // this will execute on the click of Click me button.

        }

        public ObavijestiDetailViewModel(int id)
        {
            clickCommand = new Command(onClicked); // this will execute on the click of Click me button.
            initCommand = new Command(async () => await init(id));
            initCommand.Execute(id);

        }
        List<Obavijest> _obavijesti = null;
        public List<Obavijest> Obavijesti
        {
            get { return _obavijesti; }
            set { SetProperty(ref _obavijesti, value); }
        }
        public Obavijest obavijest { get; set; }

        async Task init(int id)
        {
            try
            {
                Obavijesti = await _apiServiceRecommend.GetById<List<Obavijest>>(id);

            }
            catch (Exception )
            {

            }
            
        }



        async void onClicked(object obj)
        {
            RattingBar b = (RattingBar)obj;
            _upsertRequest.ObavijestId = obavijest.Id;
            _upsertRequest.KorisniciSistemaId = APIService.Id;
            _upsertRequest.Ocjena = b.SelectedStarValue;
            _upsertRequest.DatumOcjene = DateTime.Now;
            try
            {
                _searchRequest.KorisnikId = APIService.Id;
                _searchRequest.ObavijestId = obavijest.Id;
                List<ObavijestOcjena> provjera = await _apiService.Get<List<ObavijestOcjena>>(_searchRequest);
                int idOcjene = 0;
                foreach (var p in provjera)
                {
                    idOcjene = p.Id;
                }
                await _apiService.Update<ObavijestOcjena>(idOcjene,_upsertRequest);
                await App.Current.MainPage.DisplayAlert("Izmjenili ste svoju ocjenu za", b.SelectedStarValue.ToString(), "OK");
            }
            catch (Exception)
            {
                try
                {
                    await _apiService.Insert<ObavijestOcjena>(_upsertRequest);
                    await App.Current.MainPage.DisplayAlert("Ocjenili ste obavijest ocijenom ", b.SelectedStarValue.ToString(), "OK");

                }
                catch (Exception)
                {

                    await Application.Current.MainPage.DisplayAlert("Neuspiješno", "Ocjenjivanje nije uspjelo pokušajte drugi put", "OK");
                }
            }


        }


        private string _selectedStar;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public string SelectedStar
        {
            get { return _selectedStar; }
            set { _selectedStar = value; NotifyPropertyChanged(); }
        }
    }
}

