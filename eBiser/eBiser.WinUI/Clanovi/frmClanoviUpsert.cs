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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eBiser.Data.Requests.KorisniciInserttRequest;
using static eBiser.Data.Requests.KorisniciUpdateRequest;

namespace eBiser.WinUi.Clanovi
{
    public partial class frmClanoviUpsert : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik/clan");
        private int? _id = null;
        private int? _korisnikId = null;
        private readonly PhotoHelper photoHelper = new PhotoHelper();

        public frmClanoviUpsert(int? id =null,int? korisnikId=null)
        {
            InitializeComponent();
            _id = id;
            _korisnikId = korisnikId;
        }
        ClanUpsertRequest request = new ClanUpsertRequest();
        ClanUpdateRequest updateRequest = new ClanUpdateRequest();
        private async Task LoadDGVClanovi()
        {
            dgvClanovi.AutoGenerateColumns = false;
            dgvClanovi.DataSource = await _apiService.Get<List<Data.ClanDTO>>(null);
        }
        private async Task LoadFormaClan(int? id)
        {
            var entity = await _apiService.GetById<Data.ClanDTO>(_id);
            _korisnikId = entity.KorisnikId;
            txtEmail.Text = entity.Email;
            txtIme.Text = entity.Ime;
            txtBrojTelefona.Text = entity.BrojTelefona;
            txtPrezime.Text = entity.Prezime;
            cBoxAktivan.Checked = entity.Aktivan;
            dtpDatumRodjenja.Value = entity.DatumRodjenja.Date;
            pictureBox.Image = photoHelper.ByteArrayToImage(entity.Photo);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            txtPhoto.Text = "";
            txtDijagnoza.Text = entity.Dijagnoza;


        }

        private async void ClanoviUpsert_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnSave;
            btnSave.Focus();
            await LoadDGVClanovi();
            dgvClanovi.ClearSelection();
            if (_id.HasValue)
            {
                await LoadFormaClan(_id);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            
            if (this.ValidateChildren())
            {
                updateRequest.Ime = txtIme.Text;
                updateRequest.Prezime = txtPrezime.Text;
                updateRequest.Email = txtEmail.Text;
                updateRequest.DatumRodjenja = dtpDatumRodjenja.Value.Date;
                updateRequest.BrojTelefona = txtBrojTelefona.Text;
                updateRequest.Aktivan = cBoxAktivan.Checked;
                updateRequest.Photo = photoHelper.ImageToByteArray(pictureBox.Image);
                updateRequest.PhotoThumb = photoHelper.ImageToByteArray(pictureBox.Image);
                updateRequest.Dijagnoza =txtDijagnoza.Text;
                updateRequest.KorisnickoIme = txtIme.Text+txtPrezime.Text+ dtpDatumRodjenja.Value.Year.ToString();
                if (_id.HasValue && _korisnikId.HasValue)
                {
                    var result = await _apiService.Update<Data.ClanDTO>(_korisnikId ?? 0, updateRequest);
                    MessageBox.Show("Uspjesno uređen član");
                }
                else
                {
                    request.Ime = txtIme.Text;
                    request.Prezime = txtPrezime.Text;
                    request.Email = txtEmail.Text;
                    request.DatumRodjenja = dtpDatumRodjenja.Value.Date;
                    request.BrojTelefona = txtBrojTelefona.Text;
                    request.Aktivan = cBoxAktivan.Checked;
                    request.Photo = photoHelper.ImageToByteArray(pictureBox.Image);
                    request.PhotoThumb = photoHelper.ImageToByteArray(pictureBox.Image);
                    request.Dijagnoza = txtDijagnoza.Text;
                    request.KorisnickoIme = txtIme.Text + txtPrezime.Text + dtpDatumRodjenja.Value.Year.ToString();
                    request.Password = txtIme.Text+txtPrezime.Text;
                    request.PasswordPotvrda = txtIme.Text + txtPrezime.Text;
                    var result = await _apiService.Insert<ClanUpsertRequest>(request);
                    MessageBox.Show("Uspjesno dodan član");
                }
            }
            await LoadDGVClanovi();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void btnDodajPhoto_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Photo = file;
                request.PhotoThumb = file;
                txtPhoto.Text = fileName;
                Image image = Image.FromFile(fileName);
                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private async void dgvClanovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Int32.Parse(dgvClanovi.SelectedRows[0].Cells[0].Value.ToString());
            await LoadFormaClan(_id);
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            _id = null;
            txtEmail.Text = "";
            txtIme.Text = "";
            txtBrojTelefona.Text = "";
            txtPrezime.Text = "";
            txtPhoto.Text = "";
            txtDijagnoza.Text = "";
            cBoxAktivan.Checked = true;
            dtpDatumRodjenja.Value = DateTime.Now;
            pictureBox.Image = null;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _korisnikId = null;
            dgvClanovi.ClearSelection();
        }






        // validacija polja
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
            if ( txtPrezime.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.ToString().Length < 2 )
            {
                errorProvider.SetError(txtEmail, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;   
            }
            else if (txtEmail.Text.IndexOf("@") == -1)
            {
                errorProvider.SetError(txtEmail, Properties.Resources.ValidationEmailField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtBrojTelefona_Validating(object sender, CancelEventArgs e)
        {

            Match m = Regex.Match(txtBrojTelefona.Text, @"[0-9]\d{2}\d{3}\d{3}", RegexOptions.IgnoreCase);

            if (txtBrojTelefona.Text.ToString().Length < 9 )
            {
                errorProvider.SetError(txtBrojTelefona, Properties.Resources.ValidationPhoneNumberField);
                e.Cancel = true;
            }
            if ( !m.Success)
            {
                errorProvider.SetError(txtBrojTelefona, Properties.Resources.ValidationPhoneNumberTypeField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBrojTelefona, null);
            }

        }

        private void txtDijagnoza_Validating(object sender, CancelEventArgs e)
        {
            if (txtDijagnoza.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtDijagnoza, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDijagnoza, null);
            }
        }
    }
}
