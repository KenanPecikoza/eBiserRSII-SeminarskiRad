using eBiser.Data.Requests;
using eBiser.WindowsUI.Donatori;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBiser.WindowsUI.Donacije
{
    public partial class frmDonacijeUpsert : Form
    {
        private readonly APIService _apiServiceKorisnik = new APIService("korisnik");
        private readonly APIService _apiServiceDonacije = new APIService("donacije");
        private int? _id = null;

        public frmDonacijeUpsert(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }
        private async Task LoadDGV()
        {
            dgvDonacije.AutoGenerateColumns=false;
            dgvDonacije.DataSource = await _apiServiceDonacije.Get<List<Data.Donacije>>(null);
            dgvDonacije.ClearSelection();
            dgvDonacije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private async Task LoadForma(int id)
        {
            var donacije = await _apiServiceDonacije.GetById<Data.Donacije>(_id);
            _id = id;
            txtNaslov.Text = donacije.Naziv;
            txtObrazlozenje.Text = donacije.Obrazlozenje;
            txtOpis.Text = donacije.OpisDonacije;
            chBoxNaCekanju.Checked = donacije.NaCekanju;
            chBoxPrihvaćena.Checked = donacije.Prihvacena;
            cBoxDonatori.SelectedValue = donacije.KorisniciSistemaId;

        }
        DonacijeUpsertRequest request = new DonacijeUpsertRequest();
        private void NapuniRequest(bool prihvaćena)
        {
            request.Prihvacena = prihvaćena;
            request.Odbijena = !prihvaćena;
            request.DatumOdgovra = DateTime.Now;
            request.NaCekanju = false;
            request.Obrazlozenje = txtObrazlozenje.Text;
            request.Naziv = txtNaslov.Text;
            request.OpisDonacije = txtOpis.Text;
            request.KorisniciSistemaId = Int32.Parse(cBoxDonatori.SelectedValue.ToString());

        }

        private async void DonacijeDetails_Load(object sender, EventArgs e)
        {
            await LoadDGV();
            cBoxDonatori.DataSource = await _apiServiceKorisnik.Get<List<Data.KorisniciSistema>>(null);
            cBoxDonatori.DisplayMember = "KorisnickoIme";
            cBoxDonatori.ValueMember = "KorisnikId";// u prorertis postaviti ,

            if (_id.HasValue)
            {
                await LoadForma(_id ?? 0);
            }

        }

        private async void dgvDonacije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _id = Int32.Parse(dgvDonacije.SelectedRows[0].Cells[0].Value.ToString());
                await LoadForma(_id ?? 0);
            }
            catch (Exception)
            {

            }
        }
        private async void btnPrihvati_Click(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                NapuniRequest(true);
                await _apiServiceDonacije.Update<Data.Donacije>(_id ?? 0, request);
            }
        }

        private async void btnOdbij_Click(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                NapuniRequest(false);
                await _apiServiceDonacije.Update<Data.Donacije>(_id ?? 0, request);
            }
        }

        private async void dgvDonacije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int korisnikId = Int32.Parse(dgvDonacije.SelectedRows[0].Cells[1].Value.ToString());

            var donator = await _apiServiceKorisnik.GetById<Data.DonatorDTO>(korisnikId);

            frmDonatoriUpsert DonatoriUpsert = new frmDonatoriUpsert(donator.Id, korisnikId);
            DonatoriUpsert.Show();

        }
    }
}
