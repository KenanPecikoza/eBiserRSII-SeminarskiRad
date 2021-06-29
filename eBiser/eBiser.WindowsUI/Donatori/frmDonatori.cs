using eBiser.Data.Requests;
using eBiser.WindowsUI.Clanovi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBiser.WindowsUI.Donatori
{
    public partial class frmDonatori : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik/Donatori");

        public frmDonatori()
        {
            InitializeComponent();
        }


        private async void BtnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest()
            {
                Ime = txtPretragaIme.Text,
                Prezime = txtPretragaPrezime.Text
            };
            var result = await _apiService.Get<List<Data.DonatorDTO>>(search);
            dgvClanovi.DataSource = result;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDonatoriUpsert frmDonatoriUpsert = new frmDonatoriUpsert();
            frmDonatoriUpsert.Show();
            this.Close();
        }

        private void dgvClanovi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(dgvClanovi.SelectedRows[0].Cells[0].Value.ToString());
            int korisnikId = Int32.Parse(dgvClanovi.SelectedRows[0].Cells[1].Value.ToString());
            frmDonatoriUpsert frmDonatoriUpsert = new frmDonatoriUpsert(id, korisnikId);
            frmDonatoriUpsert.Show();
            this.Close();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
                this.Close();
            
        }

        private async void frmDonatori_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Data.ClanDTO>>(null);
            dgvClanovi.AutoGenerateColumns = false;
            dgvClanovi.DataSource = result;
            dgvClanovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
