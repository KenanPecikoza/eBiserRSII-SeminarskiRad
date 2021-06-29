using eBiser.Data.Requests;
using eBiser.WinUi.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eBiser.Data.Requests.KorisniciInserttRequest;

namespace eBiser.WinUi.Osoblje
{
    public partial class frmOsobljeUpsert : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik/Osoblje");
        private readonly APIService _apiServiceDjelatnost = new APIService("DjelatnostOsoblje");
        private int? _id = null;
        private int? _Korisnikid = null;
        private readonly PhotoHelper photoHelper = new PhotoHelper();

        public frmOsobljeUpsert(int? id =null)
        {
            _id = id;
            InitializeComponent();
        }
        private async Task LoadForm(int id)
        {
            var result = await _apiService.GetById<Data.OsobljeDTO>(id);
            txtIme.Text = result.Ime;
            txtPrezime.Text = result.Prezime;
            cBoxNazivDjelatnosti.SelectedIndex = result.DjelatnostId-1;
            dtmDatumPocetka.Value = result.DatumPocetkaAngazmana;
            pictureBox.Image = photoHelper.ByteArrayToImage(result.Photo);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            txtKorisnickoIme.Text = result.KorisnickoIme;

        }
        private async Task LoadDGV()
        {
            dgvOsoblje.AutoGenerateColumns = false;
            var result = await _apiService.Get<List<Data.OsobljeDTO>>(null);
            dgvOsoblje.DataSource = result;
            dgvOsoblje.ClearSelection();
            //dgvOsoblje.ScrollBars = ScrollBars.Both;
        }
        private async Task LoadDjelatnosti()
        {
            var djelatnosti = await _apiServiceDjelatnost.Get<List<Data.DjelatnostOsoblje>>(null);
            cBoxNazivDjelatnosti.DataSource = djelatnosti;
            cBoxNazivDjelatnosti.DisplayMember = "NazivDjelatnosti";
            cBoxNazivDjelatnosti.ValueMember = "Id";// u prorertis postaviti 
        }


        private async void frmOsobljeUpsert_Load(object sender, EventArgs e)
        {
            await LoadDjelatnosti();
            await LoadDGV();
            if (_id.HasValue)
            {
                await LoadForm(_id??0);
            }
        }
        private void btnPonisti_Click(object sender, EventArgs e)
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            cBoxNazivDjelatnosti.SelectedIndex =0;
            dtmDatumPocetka.Value = DateTime.Now;
            pictureBox.Image = null;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            dgvOsoblje.ClearSelection();
            txtKorisnickoIme.Text = "";
            _id = null;
        }

        OsobljeUpsertRequest request = new OsobljeUpsertRequest();
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            request.DatumPocetkaAngazmana = dtmDatumPocetka.Value;
            request.Ime = txtIme.Text;
            request.Prezime = txtPrezime.Text;
            request.DjelatnostId = Int32.Parse(cBoxNazivDjelatnosti.SelectedValue.ToString());
            request.Photo = photoHelper.ImageToByteArray(pictureBox.Image);
            request.PhotoThumb = photoHelper.ImageToByteArray(pictureBox.Image);
            request.KorisnickoIme = txtKorisnickoIme.Text;
            if (_id.HasValue && _Korisnikid.HasValue)
            {
                 await _apiService.Update<Data.KorisniciSistema>(_Korisnikid ?? 0, request);
                MessageBox.Show("Uspjesno uređen član osoblja ");
            }
            else
            {
                //request.KorisnickoIme = request.Ime + "." + request.Prezime;
                //request.Password = txtIme.Text+"."+txtPrezime.Text;
                //request.PasswordPotvrda = txtIme.Text + "." + txtPrezime.Text;
                 await _apiService.Insert<Data.KorisniciSistema>(request);
                MessageBox.Show("Uspjesno dodan član osoblja ");
            }
            await LoadDGV();

        }

        private void btnPhotoDodaj_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Photo = file;
                request.PhotoThumb = file;
                txtFotografija.Text = fileName;
                Image image = Image.FromFile(fileName);
                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dgvOsoblje_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var id = Int32.Parse(dgvOsoblje.SelectedRows[0].Cells[0].Value.ToString());
            var korisnikid = Int32.Parse(dgvOsoblje.SelectedRows[0].Cells[1].Value.ToString());
            _id = id;
            _Korisnikid = korisnikid;
            await LoadForm(_id??0);
        }

        private void btnIzadji_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (txtIme.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtIme, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrezime.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (txtKorisnickoIme.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }
    }
}
