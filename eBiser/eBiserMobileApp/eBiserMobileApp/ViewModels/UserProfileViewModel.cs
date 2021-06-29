using eBiser.Data;
using eBiser.Data.Requests;
using eBiserMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBiserMobileApp.ViewModels
{
    class UserProfileViewModel :BaseViewModel
    {
        private readonly APIService _apiServiceKorisnik = new APIService("Korisnik");

        public UserProfileViewModel()
        {
            ShowDetailsCommand = new Command(async () => await ShowDetails());
            LogOutCommand = new Command( () =>  LogOut());

            ShowDetailsCommand.Execute(null);
        }
        public ICommand ShowDetailsCommand { get; set; }
        public ICommand LogOutCommand { get; set; }

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
        bool _isClanarine = false;
        public bool IsClanarine
        {
            get { return _isClanarine; }
            set { SetProperty(ref _isClanarine, value); }
        }
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
                try
                {
                    var clan = await _apiServiceKorisnik.GetById<ClanDTO>(APIService.Id);
                    if (clan.Clanarine!=null)
                    {
                        Clanarine = clan.Clanarine;
                        IsClanarine = true;
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

        public void LogOut()
        {
            APIService.Id = 0;
            APIService.Token = null;
            APIService.TipId = 0;
            Application.Current.MainPage = new LoginPage();

        }

    }

}
