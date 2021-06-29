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
using static eBiser.Data.Requests.KorisniciInserttRequest;

namespace eBiserMobileApp.ViewModels
{
    public class SingUpViewModel :BaseViewModel
    {
        private readonly APIService _apiServiceDonator = new APIService("Korisnik/Donatori");
        private readonly APIService _apiService = new APIService("Security");

        public SingUpViewModel()
        {
            SingUpComand = new Command(async () => await SingUp());
            LoginCommand = new Command(async () => await Login());

        }
        public ICommand SingUpComand { get; set; }

        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _minBrojKaraterka2 = string.Empty;
        public string MinBrojKaraterka2
        {
            get { return _minBrojKaraterka2; }
            set { SetProperty(ref _minBrojKaraterka2, value); }
        }

        bool _imeIsTrue =false;
        public bool ImeIsTrue
        {
            get { return _imeIsTrue; }
            set { SetProperty(ref _imeIsTrue, value); }
        }

        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        bool _prezimeIstrue = false;
        public bool PrezimeIstrue
        {
            get { return _prezimeIstrue; }
            set { SetProperty(ref _prezimeIstrue, value); }
        }



        string _korisnickoIme = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }
        bool _korisnickoImeIsTrue = false;
        public bool KorisnickoImeIsTrue
        {
            get { return _korisnickoImeIsTrue; }
            set { SetProperty(ref _korisnickoImeIsTrue, value); }
        }





        string _passwordDonator = string.Empty;
        public string PasswordDonator
        {
            get { return _passwordDonator; }
            set { SetProperty(ref _passwordDonator, value); }
        }
        string _passwordDonatorPotvrda = string.Empty;
        public string PasswordDonatorPotvrda
        {
            get { return _passwordDonatorPotvrda; }
            set { SetProperty(ref _passwordDonatorPotvrda, value); }
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



        string _opisProfila = string.Empty;
        public string OpisProfila
        {
            get { return _opisProfila; }
            set { SetProperty(ref _opisProfila, value); }
        }
        bool _OpisProfilaIsTrue = false;
        public bool OpisProfilaIsTrue
        {
            get { return _OpisProfilaIsTrue; }
            set { SetProperty(ref _OpisProfilaIsTrue, value); }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        bool _EmailIsTrue = false;
        public bool EmailIsTrue
        {
            get { return _EmailIsTrue; }
            set { SetProperty(ref _EmailIsTrue, value); }
        }
        string _emailMessage = string.Empty;
        public string EmailMessage
        {
            get { return _emailMessage; }
            set { SetProperty(ref _emailMessage, value); }
        }




        DateTime _datumRodjenja = new DateTime();
        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set { SetProperty(ref _datumRodjenja, value); }
        }


        DonatorUpsertRequest upsertRequest = new DonatorUpsertRequest();

        async Task SingUp()
        {
            bool NeTacan = false;
            try
            {
                if (Ime.Length<2)
                {
                    ImeIsTrue = true;
                    MinBrojKaraterka2 = "Minimalan broj karaktera je 2";
                    NeTacan = true;
                }
                else
                {
                    ImeIsTrue = false;
                }
                upsertRequest.Ime = Ime;

                if (Prezime.Length <2)
                {
                    PrezimeIstrue = true;
                    MinBrojKaraterka2 = "Minimalan broj karaktera je 2";
                    NeTacan = true;
                }
                else
                {
                    PrezimeIstrue = false;
                }
                upsertRequest.Prezime = Prezime;

                if (KorisnickoIme.Length <2)
                {
                    MinBrojKaraterka2 = "Minimalan broj karaktera je 2";
                    KorisnickoImeIsTrue = true;
                    NeTacan = true;

                }
                else
                {
                    KorisnickoImeIsTrue = false;
                }
                upsertRequest.KorisnickoIme = KorisnickoIme;

                if (OpisProfila.Length <2)
                {
                    MinBrojKaraterka2 = "Minimalan broj karaktera je 2";
                    OpisProfilaIsTrue = true;
                    NeTacan = true;
                }
                else
                {
                    OpisProfilaIsTrue = false;
                }
                upsertRequest.OpisProfila = OpisProfila;

                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(Email);
                if (!match.Success)
                {
                    EmailMessage = "Format emaila nije ispravan";
                    EmailIsTrue = true;
                    NeTacan = true;
                }
                else
                {
                    EmailIsTrue = false;
                }
                upsertRequest.Password = PasswordDonator;
                upsertRequest.PasswordPotvrda = PasswordDonatorPotvrda;
                if (PasswordDonator!=_passwordDonatorPotvrda)
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

                if (!hasLowerChar.IsMatch(PasswordDonator))
                {
                    PasswordStrong = "Lozinka treba sadržavati barem jedno malo slovo";
                    PasswordStrongIsTrue = true;
                    NeTacan = true;
                }
                else if (!hasUpperChar.IsMatch(PasswordDonator))
                {
                    PasswordStrong = "Lozinka treba sadržavati barem jedno veliko slovo";
                    PasswordStrongIsTrue = true;
                    NeTacan = true;
                }
                else if (!hasMiniMaxChars.IsMatch(PasswordDonator))
                {
                    PasswordStrong = "Lozinka ne smije biti manja od 8 karaktera";
                    PasswordStrongIsTrue = true;
                    NeTacan = true;
                }
                else if (!hasNumber.IsMatch(PasswordDonator))
                {
                    PasswordStrong = "Lozinka treba sadržavati barem jednu numeričku vrijednost";
                    PasswordStrongIsTrue = true;
                    NeTacan = true;
                }
                else if (!hasSymbols.IsMatch(PasswordDonator))
                {
                    PasswordStrong = "Lozinka treba sadržavati barem jedan poseban znak";
                    PasswordStrongIsTrue = true;
                    NeTacan = true;
                }
                else
                {
                    PasswordStrongIsTrue = false;
                }


                upsertRequest.Email = Email;
                if (NeTacan)
                {
                    throw new Exception();
                }
                upsertRequest.Aktivan = true;
                upsertRequest.Verifikovan = false;
                upsertRequest.DatumRodjenja = DatumRodjenja;

                try
                {
                    DonatorDTO korisnik = await _apiServiceDonator.Insert<DonatorDTO>(upsertRequest);
                    LoginCommand.Execute(null);
                }
                catch (Exception )
                {
                }

            }
            catch (Exception)
            {

            }

        }


        public ICommand LoginCommand { get; set; }

        KorisnikLoginRequest request = new KorisnikLoginRequest();
        async Task Login()
        {
            request.KorisnickoIme = "osoblje";
            request.Password = "osoblje";
            try
            {
                KorisniciSistema korisnik = await _apiService.Login<KorisniciSistema>(request);
                APIService.Token = korisnik.Token;
                APIService.Id = korisnik.Id;
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception )
            {
            }
        }
    }
}
