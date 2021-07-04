using eBiser.Data.Requests;
using eBiser.WindowsUI.Helper;
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

namespace eBiser.WindowsUI.Donatori
{
    public partial class frmDonatoriUpsert : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik/Donatori");
        private readonly APIService _apiServiceProvjera = new APIService("Korisnik/provjera");
        private int? _id = null;
        private int? _korisnikId = null;
        private readonly PhotoHelper photoHelper = new PhotoHelper();
        public frmDonatoriUpsert(int? id=null, int? korisnikId = null)
        {
            InitializeComponent();
            _id = id;
            _korisnikId = korisnikId;
        }
        DonatorUpdateRequest updateRequest = new DonatorUpdateRequest();
        DonatorUpsertRequest insertRequest = new DonatorUpsertRequest();
        private async Task LoadDGV()
        {
            dgvClanovi.AutoGenerateColumns = false;
            dgvClanovi.DataSource = await _apiService.Get<List<Data.DonatorDTO>>(null);
            dgvClanovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private async Task LoadForma(int? id)
        {
            var entity = await _apiService.GetById<Data.DonatorDTO>(_id);
            _korisnikId = entity.KorisnikId;
            txtEmail.Text = entity.Email;
            txtIme.Text = entity.Ime;
            txtPrezime.Text = entity.Prezime;
            cBoxAktivan.Checked = entity.Aktivan;
            dtpDatumRodjenja.Value = entity.DatumRodjenja.Date;
            pictureBox.Image = photoHelper.ByteArrayToImage(entity.Photo);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            txtPhoto.Text = "";
            txtKorisnickoIme.Text = entity.KorisnickoIme;
            txtOpisProfila.Text = entity.OpisProfila;
            txtBrojTelefona.Text = entity.BrojTelefona;
        }

        private async void frmDonatoriUpsert_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnSave;
            btnSave.Focus();
            await LoadDGV();
            dgvClanovi.ClearSelection();
            if (_id.HasValue)
            {
                await LoadForma(_id);
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
                updateRequest.Aktivan = cBoxAktivan.Checked;
                updateRequest.Photo = photoHelper.ImageToByteArray(pictureBox.Image);
                updateRequest.PhotoThumb = photoHelper.ImageToByteArray(pictureBox.Image);
                updateRequest.OpisProfila = txtOpisProfila.Text;
                updateRequest.KorisnickoIme = txtKorisnickoIme.Text;
                updateRequest.BrojTelefona = txtBrojTelefona.Text;
                if (_id.HasValue && _korisnikId.HasValue)
                {
                    await _apiService.Update<Data.DonatorDTO>(_korisnikId ?? 0, updateRequest);
                    MessageBox.Show("Uspjesno uređen donator profil");
                }
                else
                {
                    insertRequest.Ime = txtIme.Text;
                    insertRequest.Prezime = txtPrezime.Text;
                    insertRequest.Email = txtEmail.Text;
                    insertRequest.DatumRodjenja = dtpDatumRodjenja.Value.Date;
                    insertRequest.Aktivan = cBoxAktivan.Checked;
                    insertRequest.Photo = photoHelper.ImageToByteArray(pictureBox.Image);
                    insertRequest.PhotoThumb = photoHelper.ImageToByteArray(pictureBox.Image);
                    insertRequest.OpisProfila = txtOpisProfila.Text;
                    insertRequest.KorisnickoIme = txtKorisnickoIme.Text;
                    insertRequest.Password = txtIme.Text + txtPrezime.Text + "1$Aa";
                    insertRequest.PasswordPotvrda = txtIme.Text + txtPrezime.Text + "1$Aa";
                    insertRequest.BrojTelefona = txtBrojTelefona.Text;
                    try
                    {
                        await _apiService.Insert<Data.DonatorDTO>(insertRequest);
                        MessageBox.Show("Uspjesno dodan donator profil");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Podaci ne odgovaraju");
                    }
                }
            }
            await LoadDGV();
        }

        private void btnDodajPhoto_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var file = File.ReadAllBytes(fileName);
                if (_id.HasValue)
                {
                    updateRequest.Photo = file;
                    updateRequest.PhotoThumb = file;
                }
                else
                {
                    insertRequest.Photo = file;
                    insertRequest.PhotoThumb = file;
                }

                txtPhoto.Text = fileName;
                Image image = Image.FromFile(fileName);
                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private async void dgvClanovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _id = Int32.Parse(dgvClanovi.SelectedRows[0].Cells[0].Value.ToString());
                await LoadForma(_id);
            }
            catch (Exception)
            {

            }
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            _id = null;
            txtEmail.Text = "";
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtPhoto.Text = "";
            txtOpisProfila.Text = "";
            cBoxAktivan.Checked = true;
            dtpDatumRodjenja.Value = DateTime.Now;
            pictureBox.Image = null;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _korisnikId = null;
            txtKorisnickoIme.Text = "";
            dgvClanovi.ClearSelection();
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
                errorProvider.SetError(txtPrezime, WindowsUI.Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private async void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            Data.KorisniciSistema donator = await _apiServiceProvjera.Get<Data.KorisniciSistema>(new PotvrdaSearchRequest
            {
                Email = txtEmail.Text
            });
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(txtEmail.Text);

            if (txtEmail.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtEmail, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else if (!match.Success)
            {
                errorProvider.SetError(txtEmail, Properties.Resources.ValidationEmailField);
                e.Cancel = true;
            }
            else if (donator!=null)
            {
                errorProvider.SetError(txtEmail, Properties.Resources.EmailIsUsing);
                e.Cancel = true;
            }

            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtOpisProfila_Validating(object sender, CancelEventArgs e)
        {

            if (txtOpisProfila.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtOpisProfila, WindowsUI.Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtOpisProfila, null);
            }
        }

        private async void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {

            Data.KorisniciSistema donator = await _apiServiceProvjera.Get<Data.KorisniciSistema>(new PotvrdaSearchRequest
            {
                KorisnickoIme = txtKorisnickoIme.Text
            });
            if (txtKorisnickoIme.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else if (donator!=null)
            {

                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.UserNameIsUsing);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }
    }
}
