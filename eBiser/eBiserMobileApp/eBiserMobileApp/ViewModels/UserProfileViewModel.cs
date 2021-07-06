using eBiser.Data;
using eBiserMobileApp.Views;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using static eBiser.Data.Requests.KorisniciUpdateRequest;

namespace eBiserMobileApp.ViewModels
{
    class UserProfileViewModel :BaseViewModel
    {
        private readonly APIService _apiServiceKorisnik = new APIService("Korisnik");
        private readonly APIService _apiServiceKorisnikClan = new APIService("Korisnik/Clan");
        private readonly APIService _apiServiceKorisnikDonator = new APIService("Korisnik/Donatori");
        private readonly APIService _apiServiceKorisnikOsoblje = new APIService("Korisnik/Osoblje");

        public UserProfileViewModel()
        {
            ShowDetailsCommand = new Command(async () => await ShowDetails());
            LogOutCommand = new Command( () =>  LogOut());
            IzmjeniProfilCommand = new Command(async () => await  IzmjeniProfil());
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

        // validacija 
        string _minBrojKaraterka2 = string.Empty;
        public string MinBrojKaraterka2
        {
            get { return _minBrojKaraterka2; }
            set { SetProperty(ref _minBrojKaraterka2, value); }
        }

        bool _imeIsTrue = false;
        public bool ImeIsTrue
        {
            get { return _imeIsTrue; }
            set { SetProperty(ref _imeIsTrue, value); }
        }
        bool _prezimeIstrue = false;
        public bool PrezimeIstrue
        {
            get { return _prezimeIstrue; }
            set { SetProperty(ref _prezimeIstrue, value); }
        }

        bool _BrojTelefonaTrue = false;
        public bool BrojTelefonaIsTrue
        {
            get { return _BrojTelefonaTrue; }
            set { SetProperty(ref _BrojTelefonaTrue, value); }
        }

        bool _dijagnozaIsTrue = false;
        public bool DijagnozaIsTrue
        {
            get { return _dijagnozaIsTrue; }
            set { SetProperty(ref _dijagnozaIsTrue, value); }
        }

        bool _OpisProfilaIsTrue = false;
        public bool OpisProfilaIsTrue
        {
            get { return _OpisProfilaIsTrue; }
            set { SetProperty(ref _OpisProfilaIsTrue, value); }
        }

        string _brojTelefonaMessage = string.Empty;
        public string BrojTelefonaMessage
        {
            get { return _brojTelefonaMessage; }
            set { SetProperty(ref _brojTelefonaMessage, value); }
        }


        async Task ShowDetails()
        {
            bool NeTacan = false;
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
            bool NeTacan = false;

            if (IsClanarine)
            {
                try
                {
                    var result= await _apiServiceKorisnik.GetById<ClanDTO>(APIService.Id);
                    ClanUpdate.Aktivan = result.Aktivan;
                }
                catch (Exception)
                {

                }

                try
                {
                    ClanUpdate.Ime = Ime;
                    ClanUpdate.Prezime = Prezime;
                    ClanUpdate.Photo = Fotografija;
                    ClanUpdate.PhotoThumb = Fotografija;
                    ClanUpdate.KorisnickoIme = KorisnickoIme;
                    ClanUpdate.Email = Email;
                    ClanUpdate.DatumRodjenja = DatumRodjenja;
                    ClanUpdate.BrojTelefona = BrojTelefona;
                    ClanUpdate.Dijagnoza = Dijagnoza;

                    if (Ime.Length < 2)
                    {
                        ImeIsTrue = true;
                        MinBrojKaraterka2 = "Minimalan broj karaktera je 2";
                        NeTacan = true;
                    }
                    else
                    {
                        ImeIsTrue = false;
                    }

                    if (Prezime.Length < 2)
                    {
                        PrezimeIstrue = true;
                        MinBrojKaraterka2 = "Minimalan broj karaktera je 2";
                        NeTacan = true;
                    }
                    else
                    {
                        PrezimeIstrue = false;
                    }

                    Regex regexPhone = new Regex(@"[0-9]\d{2}\d{3}\d{3,4}");
                    Match matchPhone = regexPhone.Match(BrojTelefona);
                    if (!matchPhone.Success)
                    {
                        BrojTelefonaMessage = "Format broja nije ispravan (061 111 111/1111)";
                        BrojTelefonaIsTrue = true;
                        NeTacan = true;
                    }
                    else
                    {
                        BrojTelefonaIsTrue = false;
                    }

                    if (Dijagnoza.Length < 2)
                    {
                        DijagnozaIsTrue = true;
                        MinBrojKaraterka2 = "Minimalan broj karaktera je 2";
                        NeTacan = true;
                    }
                    else
                    {
                        DijagnozaIsTrue = false;
                    }
                    if (NeTacan)
                    {
                        throw new Exception();
                    }

                    try
                    {
                        await _apiServiceKorisnikClan.Update<ClanDTO>(APIService.Id, ClanUpdate);
                        await Application.Current.MainPage.DisplayAlert("Uspješno", "Uspješno izmjenili lične podatke", "OK");
                    }
                    catch (Exception)
                    {

                    }
                }
                catch (Exception)
                {

                }



            }
            else if (IsDonator)
            {
                try
                {
                    var result = await _apiServiceKorisnik.GetById<DonatorDTO>(APIService.Id);
                    DonatorUpdate.Aktivan = result.Aktivan;
                }
                catch (Exception)
                {

                }
                try
                {
                    DonatorUpdate.Ime = Ime;
                    DonatorUpdate.Prezime = Prezime;
                    DonatorUpdate.Photo = Fotografija;
                    DonatorUpdate.PhotoThumb = Fotografija;
                    DonatorUpdate.KorisnickoIme = KorisnickoIme;
                    DonatorUpdate.Email = Email;
                    DonatorUpdate.DatumRodjenja = DatumRodjenja;
                    DonatorUpdate.BrojTelefona = BrojTelefona;
                    DonatorUpdate.OpisProfila = OpisProfila;

                    if (Ime.Length < 2)
                    {
                        ImeIsTrue = true;
                        MinBrojKaraterka2 = "Minimalan broj karaktera je 2";
                        NeTacan = true;
                    }
                    else
                    {
                        ImeIsTrue = false;
                    }

                    if (Prezime.Length < 2)
                    {
                        PrezimeIstrue = true;
                        MinBrojKaraterka2 = "Minimalan broj karaktera je 2";
                        NeTacan = true;
                    }
                    else
                    {
                        PrezimeIstrue = false;
                    }

                    Regex regexPhone = new Regex(@"[0-9]\d{2}\d{3}\d{3,4}");
                    Match matchPhone = regexPhone.Match(BrojTelefona);
                    if (!matchPhone.Success)
                    {
                        BrojTelefonaMessage = "Format broja nije ispravan (061 111 111/1111)";
                        BrojTelefonaIsTrue = true;
                        NeTacan = true;
                    }
                    else
                    {
                        BrojTelefonaIsTrue = false;
                    }
                    if (OpisProfila.Length < 2)
                    {
                        MinBrojKaraterka2 = "Minimalan broj karaktera je 2";
                        OpisProfilaIsTrue = true;
                        NeTacan = true;
                    }
                    else
                    {
                        OpisProfilaIsTrue = false;
                    }


                    if (NeTacan)
                    {
                        throw new Exception();
                    }
                    try
                    {
                        await _apiServiceKorisnikDonator.Update<DonatorDTO>(APIService.Id, DonatorUpdate);
                        await Application.Current.MainPage.DisplayAlert("Uspješno", "Uspješno izmjenili lične podatke", "OK");
                    }
                    catch (Exception)
                    {
                    }
                }
                catch (Exception)
                {
                }
             
            }
            else if (IsOsoblje)
            {

                try
                {
                    var result = await _apiServiceKorisnikOsoblje.GetById<OsobljeDTO>(APIService.Id);
                    OsobljeUpdate.Aktivan = true;
                    OsobljeUpdate.DjelatnostId = result.DjelatnostId;
                }
                catch (Exception)
                {

                }

                try
                {
                    OsobljeUpdate.Ime = Ime;
                    OsobljeUpdate.Prezime = Prezime;
                    OsobljeUpdate.Photo = Fotografija;
                    OsobljeUpdate.PhotoThumb = Fotografija;
                    OsobljeUpdate.KorisnickoIme = KorisnickoIme;
                    OsobljeUpdate.Email = Email;
                    OsobljeUpdate.DatumRodjenja = DatumRodjenja;
                    OsobljeUpdate.DatumPocetkaAngazmana = DatumAngazmana;

                    if (Ime.Length < 2)
                    {
                        ImeIsTrue = true;
                        MinBrojKaraterka2 = "Minimalan broj karaktera je 2";
                        NeTacan = true;
                    }
                    else
                    {
                        ImeIsTrue = false;
                    }

                    if (Prezime.Length < 2)
                    {
                        PrezimeIstrue = true;
                        MinBrojKaraterka2 = "Minimalan broj karaktera je 2";
                        NeTacan = true;
                    }
                    else
                    {
                        PrezimeIstrue = false;
                    }

                    if (NeTacan)
                    {
                        throw new Exception();
                    }

                    try
                    {
                        await _apiServiceKorisnikOsoblje.Update<OsobljeDTO>(APIService.Id, OsobljeUpdate);
                        await Application.Current.MainPage.DisplayAlert("Uspješno", "Uspješno izmjenili lične podatke", "OK");
                    }
                    catch (Exception)
                    {

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        public void LogOut()
        {
            APIService.Id = 0;
            APIService.Token = null;
            APIService.KorisnikId = 0;
            Application.Current.MainPage = new LoginPage();
        }

    }

}
