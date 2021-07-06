using eBiser.Data;
using eBiser.Data.Requests;
using eBiserMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using static eBiser.Data.Requests.KorisniciUpdateRequest;

namespace eBiserMobileApp.ViewModels
{
    class UserProfileViewModel :BaseViewModel
    {
        private readonly APIService _apiServiceKorisnik = new APIService("Korisnik");

        public UserProfileViewModel()
        {
            ShowDetailsCommand = new Command(async () => await ShowDetails());
            LogOutCommand = new Command( () =>  LogOut());
            IzmjeniProfilCommand = new Command( () =>  IzmjeniProfil());
            ShowDetailsCommand.Execute(null);

        }
        public ICommand ShowDetailsCommand { get; set; }
        public ICommand LogOutCommand { get; set; }
        public ICommand IzmjeniProfilCommand { get; set; }

        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        string _korisnickoIme = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }
        DateTime _datumRodjenja = new DateTime();
        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set { SetProperty(ref _datumRodjenja, value); }
        }
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        byte[] _fotografija= null;
        public byte[] Fotografija
        {
            get { return _fotografija; }
            set { SetProperty(ref _fotografija, value); }
        }
        string _clanarine = string.Empty;
        public string Clanarine
        {
            get { return _clanarine; }
            set { SetProperty(ref _clanarine, value); }
        }

        bool _verifikovan = false;
        public bool IsVerifikovan
        {
            get { return _verifikovan; }
            set { SetProperty(ref _verifikovan, value); }
        }

        bool _isDonator = false;
        public bool IsDonator
        {
            get { return _isDonator; }
            set { SetProperty(ref _isDonator, value); }
        }
        bool _isOsoblje = false;
        public bool IsOsoblje
        {
            get { return _isOsoblje; }
            set { SetProperty(ref _isOsoblje, value); }
        }
        bool _isClanarine = false;
        public bool IsClanarine
        {
            get { return _isClanarine; }
            set { SetProperty(ref _isClanarine, value); }
        }

        string _brojTelefona = string.Empty;
        public string BrojTelefona
        {
            get { return _brojTelefona; }
            set { SetProperty(ref _brojTelefona, value); }
        }

        string _opisProfila = string.Empty;
        public string OpisProfila
        {
            get { return _opisProfila; }
            set { SetProperty(ref _opisProfila, value); }
        }

        string _dijagnoza = string.Empty;
        public string Dijagnoza
        {
            get { return _dijagnoza; }
            set { SetProperty(ref _dijagnoza, value); }
        }
        string _nazivDjelatnosti = string.Empty;
        public string NazivDjelatnosti
        {
            get { return _nazivDjelatnosti; }
            set { SetProperty(ref _nazivDjelatnosti, value); }
        }

        DateTime _datumAngazmana = new DateTime();
        public DateTime DatumAngazmana
        {
            get { return _datumAngazmana; }
            set { SetProperty(ref _datumAngazmana, value); }
        }


        // verifikovan i datum rođenja



        async Task ShowDetails()
        {
            try
            {
                var korisnik =  await _apiServiceKorisnik.GetById<KorisniciSistema>(APIService.Id);
                Ime = korisnik.Ime;
                Prezime = korisnik.Prezime;
                KorisnickoIme = korisnik.KorisnickoIme;
                DatumRodjenja = korisnik.DatumRodjenja;
                Email = korisnik.Email;
                Fotografija = korisnik.Photo;
                IsVerifikovan = korisnik.Verifikovan;
                try
                {
                    var clan = await _apiServiceKorisnik.GetById<ClanDTO>(APIService.Id);
                    if (clan.Clanarine!=null)
                    {
                        Clanarine = clan.Clanarine;
                        IsClanarine = true;
                        BrojTelefona = clan.BrojTelefona;
                        Dijagnoza = clan.Dijagnoza;

                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    var Osoblje = await _apiServiceKorisnik.GetById<OsobljeDTO>(APIService.Id);
                    if (Osoblje.NazivDjelatnosti != null)
                    {
                        IsOsoblje = true;
                        NazivDjelatnosti = Osoblje.NazivDjelatnosti;
                        DatumAngazmana = Osoblje.DatumPocetkaAngazmana;

                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    var donatori = await _apiServiceKorisnik.GetById<DonatorDTO>(APIService.Id);
                    if (donatori.OpisProfila != null)
                    {
                        IsDonator = true;
                        BrojTelefona = donatori.BrojTelefona;
                        OpisProfila = donatori.OpisProfila;
                        
                    }
                }
                catch (Exception)
                {
                }
            }
            catch (Exception )
            {
            }
        }
        ClanUpdateRequest ClanUpdate = new ClanUpdateRequest();
        DonatorUpdateRequest DonatorUpdate = new DonatorUpdateRequest();
        OsobljeUpdateRequest OsobljeUpdate = new OsobljeUpdateRequest();

        async Task IzmjeniProfil()
        {


            if (IsClanarine)
            {
                ClanUpdate.Ime = Ime;
                ClanUpdate.Prezime = Prezime;
                ClanUpdate.Photo = Fotografija;
                ClanUpdate.PhotoThumb = Fotografija;
                ClanUpdate.KorisnickoIme = KorisnickoIme;
                ClanUpdate.Email = Email;
                ClanUpdate.Aktivan = true;
                ClanUpdate.DatumRodjenja = DatumRodjenja;
                ClanUpdate.BrojTelefona = BrojTelefona;
                ClanUpdate.Dijagnoza = Dijagnoza;
            }
            else if (IsDonator)
            {

            }
            else if (IsOsoblje)
            {

            }

        }


        public void LogOut()
        {
            APIService.Id = 0;
            APIService.Token = null;
            APIService.TipId = 0;
            Application.Current.MainPage = new LoginPage();

        }

    }

}
