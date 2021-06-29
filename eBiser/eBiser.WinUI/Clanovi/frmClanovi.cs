using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBiser.Data.Requests;
using Newtonsoft.Json;

namespace eBiser.WinUi.Clanovi
{
    public partial class frmClanovi : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik/Clan");
        //private readonly APIService _apiServiceSecurity = new APIService("Security");

        public frmClanovi()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            KorisnikLoginRequest loginData = new KorisnikLoginRequest
            {
                KorisnickoIme = "Test",
                Password = "test"
            };
            //var osoba = await _apiServiceSecurity.Login<Data.Osoblje>(loginData);
            //APIService.Token = osoba.Token;


            var result =await _apiService.Get<List<Data.ClanDTO>>(null);
            dgvClanovi.AutoGenerateColumns = false;
            dgvClanovi.DataSource = result;
            dgvClanovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private async void BtnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new Data.Requests.KorisniciSearchRequest()
            {
                Ime = txtPretragaIme.Text,
                Prezime = txtPretragaPrezime.Text
            };
            var result = await _apiService.Get<List<Data.ClanDTO>>(search);

            dgvClanovi.DataSource = result;
        }
        
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmClanoviUpsert clanoviUpsert = new frmClanoviUpsert();
            clanoviUpsert.Show();
            this.Close();
        }

        private void dgvClanovi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(dgvClanovi.SelectedRows[0].Cells[0].Value.ToString());
            int korisnikId = Int32.Parse(dgvClanovi.SelectedRows[0].Cells[1].Value.ToString());
            frmClanoviUpsert clanoviUpsert = new frmClanoviUpsert( id, korisnikId);
            clanoviUpsert.Show();
            this.Close();

        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
