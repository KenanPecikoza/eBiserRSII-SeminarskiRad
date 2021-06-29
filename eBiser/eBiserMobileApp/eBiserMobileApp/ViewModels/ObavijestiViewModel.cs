using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eBiser.Data;
using eBiser.Data.Requests;
using Xamarin.Forms;

namespace eBiserMobileApp.ViewModels
{
    public class ObavijestiViewModel : BaseViewModel
    {
        private readonly APIService _apiService = new APIService("Obavijest");
        private readonly APIService _apiServiceKategorija = new APIService("ObavijestKategorija");

        public ObavijestiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Obavijest> Obavijesti { get; set; } = new ObservableCollection<Obavijest>();
        public ObservableCollection<ObavijestKategorija> ObavijestiKategorije { get; set; } = new ObservableCollection<ObavijestKategorija>();

        ObavijestKategorija _selectedKategorija = null;
        public ObavijestKategorija SelectedKategorija
        {
            get { return _selectedKategorija; }
            set { SetProperty(ref _selectedKategorija, value);
                if (value!=null)
                {
                    InitCommand.Execute(null);    
                }
            }
        }

        public ICommand InitCommand{ get; set; }
        public async Task Init()
        {
            if (ObavijestiKategorije.Count==0)
            {
                var kateogrije = await _apiServiceKategorija.Get<List<ObavijestKategorija>>(null);
                foreach (var i in kateogrije)
                {
                    ObavijestiKategorije.Add(i);
                }
            }
            ObavijestSearchRequest searchRequest = null;
            if (SelectedKategorija!=null)
            {
                searchRequest = new ObavijestSearchRequest();
                searchRequest.KategorijaId = SelectedKategorija.Id;
            }  
            var list = await _apiService.Get<List<Obavijest>>(searchRequest);
            Obavijesti.Clear();
            foreach (var i in list)
            {
                Obavijesti.Add(i);
            }

        }
    }
}
