using eBiser.Data.Requests;
using eBiserMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using eBiser.Data;

namespace eBiserMobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _apiService = new APIService("Security");

        public LoginViewModel()
        {
            LoginCommand = new Command(async()=> await Login());
            SingUpButtonCommand = new Command(()=> SingUpButton());
        }

        string _username= string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        public ICommand LoginCommand { get; set; }



        KorisnikLoginRequest request = new KorisnikLoginRequest();
        async Task Login()
        {
            request.KorisnickoIme =Username;
            request.Password = Password;
            try
            {
                KorisniciSistema korisnik = await _apiService.Login<KorisniciSistema>(request);
                APIService.Token = korisnik.Token;
                APIService.TipId = korisnik.Id;
                APIService.Id = korisnik.KorisnikId;
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception)
            {
            }
        }
        public ICommand SingUpButtonCommand { get; set; }
        void SingUpButton()
        {
            Application.Current.MainPage = new SingUp();
        }


    }
}
