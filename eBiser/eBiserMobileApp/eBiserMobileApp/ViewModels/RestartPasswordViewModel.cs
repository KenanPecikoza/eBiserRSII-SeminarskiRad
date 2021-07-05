using eBiser.Data;
using eBiser.Data.Requests;
using eBiserMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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

        bool _PasswordMatch = false;
        public bool PasswordMatch
        {
            get { return _PasswordMatch; }
            set { SetProperty(ref _PasswordMatch, value); }
        }
        string _PasswordMatchMessage = string.Empty;
        public string PasswordMatchMessage
        {
            get { return _PasswordMatchMessage; }
            set { SetProperty(ref _PasswordMatchMessage, value); }
        }
        string _PasswordStrong = string.Empty;
        public string PasswordStrong
        {
            get { return _PasswordStrong; }
            set { SetProperty(ref _PasswordStrong, value); }
        }
        bool _PasswordStrongIsTrue = false;
        public bool PasswordStrongIsTrue
        {
            get { return _PasswordStrongIsTrue; }
            set { SetProperty(ref _PasswordStrongIsTrue, value); }
        }




        RestartPasswordRequest restart = new RestartPasswordRequest();

        async Task RestartPassword()
        {
            restart.Password = Password;
            restart.NewPassword = NewPassword;
            restart.NewPasswordPotvrda = NewPasswordPotvrda;
            bool NeTacan = false;

            try
            {
                if (NewPassword != NewPasswordPotvrda)
                {
                    PasswordMatch = true;
                    PasswordMatchMessage = "Passwordi se ne podudaraju";
                    NeTacan = true;
                }
                else
                {
                    PasswordMatch = false;
                }
                var hasNumber = new Regex(@"[0-9]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasMiniMaxChars = new Regex(@".{8,}");
                var hasLowerChar = new Regex(@"[a-z]+");
                var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

                if (!hasLowerChar.IsMatch(NewPassword))
                {
                    PasswordStrong = "Lozinka treba sadržavati barem jedno malo slovo";
                    PasswordStrongIsTrue = true;
                    NeTacan = true;
                }
                else if (!hasUpperChar.IsMatch(NewPassword))
                {
                    PasswordStrong = "Lozinka treba sadržavati barem jedno veliko slovo";
                    PasswordStrongIsTrue = true;
                    NeTacan = true;
                }
                else if (!hasMiniMaxChars.IsMatch(NewPassword))
                {
                    PasswordStrong = "Lozinka ne smije biti manja od 8 karaktera";
                    PasswordStrongIsTrue = true;
                    NeTacan = true;
                }
                else if (!hasNumber.IsMatch(NewPassword))
                {
                    PasswordStrong = "Lozinka treba sadržavati barem jednu numeričku vrijednost";
                    PasswordStrongIsTrue = true;
                    NeTacan = true;
                }
                else if (!hasSymbols.IsMatch(NewPassword))
                {
                    PasswordStrong = "Lozinka treba sadržavati barem jedan poseban znak";
                    PasswordStrongIsTrue = true;
                    NeTacan = true;
                }
                else
                {
                    PasswordStrongIsTrue = false;
                }
                if (NeTacan)
                {
                    throw new Exception();
                }

                try
                {
                    var korisnik = await _apiService.Update<KorisniciSistema>(APIService.Id, restart);
                    Application.Current.MainPage = new MainPage();
                    await Application.Current.MainPage.DisplayAlert("Uspješno", "Uspješno ste promijenili password", "OK");

                }
                catch (Exception)
                {
                    await Application.Current.MainPage.DisplayAlert("Neuspješno", "Password nije odgovarajući", "OK");

                }

            }
            catch (Exception)
            {

            }
        }
    }
}
