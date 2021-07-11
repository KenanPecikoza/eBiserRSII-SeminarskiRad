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
            try
            {
                dgvDonacije.AutoGenerateColumns = false;
                dgvDonacije.DataSource = await _apiServiceDonacije.Get<List<Data.Donacije>>(null);
                dgvDonacije.ClearSelection();
                dgvDonacije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception)
            {

            }

        }

        private async Task LoadForma(int id)
        {
            try
            {
                var donacije = await _apiServiceDonacije.GetById<Data.Donacije>(_id);
                _id = id;
                txtNaslov.Text = donacije.Naziv;
                txtObrazlozenje.Text = donacije.Obrazlozenje;
                txtOpis.Text = donacije.OpisDonacije;
                chBoxNaCekanju.Checked = donacije.NaCekanju;
                chBoxPrihvaćena.Checked = donacije.Prihvacena;
                chBoxOdbijena.Checked = donacije.Odbijena;
                cBoxDonatori.SelectedValue = donacije.KorisniciSistemaId;
            }
            catch (Exception)
            {

            }


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
            try
            {
                cBoxDonatori.DataSource = await _apiServiceKorisnik.Get<List<Data.KorisniciSistema>>(null);
                cBoxDonatori.DisplayMember = "KorisnickoIme";
                cBoxDonatori.ValueMember = "KorisnikId";// u prorertis postaviti ,
            }
            catch (Exception)
            {

            }

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
                try
                {
                     await _apiServiceDonacije.Update<Data.Donacije>(_id ?? 0, request);
                    MessageBox.Show("Donacija je prihvaćena");
                    await LoadForma(_id??0);
                }
                catch (Exception)
                {
                    MessageBox.Show("Prihvatanje donacije nije uspjelo");
                }
            }
        }

        private async void btnOdbij_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (_id.HasValue)
                {
                    NapuniRequest(false);
                    try
                    {
                       await _apiServiceDonacije.Update<Data.Donacije>(_id ?? 0, request);
                        MessageBox.Show("Donacija je odbijena");
                        await LoadForma(_id ?? 0);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Odbijanje donacije nije uspjelo");

                    }
                }
            }
        }

        private async void dgvDonacije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int korisnikId = Int32.Parse(dgvDonacije.SelectedRows[0].Cells[1].Value.ToString());
                var donator = await _apiServiceKorisnik.GetById<Data.DonatorDTO>(korisnikId);
                frmDonatoriUpsert DonatoriUpsert = new frmDonatoriUpsert(donator.Id, korisnikId);
                DonatoriUpsert.Show();
            }
            catch (Exception)
            {
            }


        }

        private void txtObrazlozenje_Validating(object sender, CancelEventArgs e)
        {
            if (txtObrazlozenje.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtObrazlozenje, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtObrazlozenje, null);
            }
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            txtNaslov.Text = "";
            dtmPrijave.Value = DateTime.Now;
            cBoxDonatori.SelectedIndex = 0;
            txtOpis.Text = "";
            txtObrazlozenje.Text = "";
            _id = null;
        }
    }
}
