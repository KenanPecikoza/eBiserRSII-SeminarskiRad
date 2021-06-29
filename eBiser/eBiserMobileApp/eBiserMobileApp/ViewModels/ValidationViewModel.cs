using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBiserMobileApp.ViewModels
{
    public class ValidationViewModel : BaseViewModel
    {

        public ValidationViewModel()
        {
            OnClickCommand = new Command( () =>  OnClick());

        }
        public ICommand OnClickCommand { get; set; }
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        bool _tacan = false;
        public bool Tacan
        {
            get { return _tacan; }
            set { SetProperty(ref _tacan, value); }
        }

        string _EmailPoruka = string.Empty;
        public string EmailPoruka
        {
            get { return _EmailPoruka; }
            set { SetProperty(ref _EmailPoruka, value); }
        }


         void OnClick()
         {
            try
            {
                MailAddress mail = new MailAddress(Email);
                Tacan = true;
                EmailPoruka= "Email dobar";
            }
            catch (Exception )
            {
                EmailPoruka = " nije Email dobar";
            }

        }
    }
}
