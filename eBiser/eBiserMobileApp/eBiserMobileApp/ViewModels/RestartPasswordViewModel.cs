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
    public class RestartPasswordViewModel : BaseViewModel
    {
        private readonly APIService _apiService = new APIService("Security");

        public RestartPasswordViewModel()
        {
            RestartPasswordCommand = new Command(async () => await RestartPassword());

        }
        public ICommand RestartPasswordCommand { get; set; }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        string _newpassword = string.Empty;
        public string NewPassword
        {
            get { return _newpassword; }
            set { SetProperty(ref _newpassword, value); }
        }
        string _newpasswordPotvrda = string.Empty;
        public string NewPasswordPotvrda
        {
            get { return _newpasswordPotvrda; }
            set { SetProperty(ref _newpasswordPotvrda, value); }
        }

        RestartPasswordRequest restart = new RestartPasswordRequest();

        async Task RestartPassword()
        {
            restart.Password = Password;
            restart.NewPassword = NewPassword;
            restart.NewPasswordPotvrda = NewPasswordPotvrda;
            try
            {
                var korisnik =  await _apiService.Update<KorisniciSistema>(APIService.Id, restart);
                Application.Current.MainPage = new MainPage();
                await Application.Current.MainPage.DisplayAlert("Uspješno", "Uspješno ste promijenili password", "OK");


            }
            catch (Exception)
            {
                await Application.Current.MainPage.DisplayAlert("Neuspiješno", "Passwordi se ne podudaraju", "OK");

            }
        }
    }
}
