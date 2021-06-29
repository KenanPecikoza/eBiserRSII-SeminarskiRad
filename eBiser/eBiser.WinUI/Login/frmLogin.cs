using eBiser.Data.Requests;
using eBiser.WinUi.Clanovi;
using eBiser.WinUi.Osoblje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBiser.WinUi.Login
{
    public partial class frmLogin : Form
    {
        private readonly APIService _apiService = new APIService("Security");
        private readonly APIService _apiServiceOsoblje = new APIService("Korisnik");
        public frmLogin()
        {
            InitializeComponent();
        }
        KorisnikLoginRequest request = new KorisnikLoginRequest();

        private async Task Login()
        {
            request.KorisnickoIme = txtKorisnickoIme.Text;
            request.Password = txtPassword.Text;
            try
            {
                var korisnik = await _apiService.Login<Data.KorisniciSistema>(request);
                APIService.Token = korisnik.Token;
                APIService.KorisnikId = korisnik.KorisnikId;
                var korisnik1 = await _apiServiceOsoblje.GetById<Data.KorisniciSistema>(korisnik.KorisnikId);
                APIService.Id = korisnik1.Id;
                this.Hide();
                var form2 = new frmIndex();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            catch (Exception ex)
            {
            }
        } 

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            await Login();
        }

        private async void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await Login();
            }

        }
        private async void txtKorisnickoIme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await Login();
            }
        }

    }
}
