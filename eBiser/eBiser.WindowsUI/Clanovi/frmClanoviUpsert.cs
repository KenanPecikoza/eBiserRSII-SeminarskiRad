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

namespace eBiser.WindowsUI.Clanovi
{
    public partial class frmClanoviUpsert : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik/clan");
        private readonly APIService _apiServiceProvjera = new APIService("Korisnik/potvrda");

        private bool ValidacijaEmail;
        private bool ValidacijaKorisnickoIme;
        private int? _id = null;
        private int? _korisnikId = null;
        private readonly PhotoHelper photoHelper = new PhotoHelper();

        public frmClanoviUpsert(int? id =null,int? korisnikId=null)
        {
            InitializeComponent();
            _id = id;
            _korisnikId = korisnikId;
        }
        ClanUpdateRequest updateRequest = new ClanUpdateRequest();
        ClanUpsertRequest insertRequest = new ClanUpsertRequest();
        private async Task LoadDGVClanovi()
        {
            try
            {
                dgvClanovi.AutoGenerateColumns = false;
                dgvClanovi.DataSource = await _apiService.Get<List<Data.ClanDTO>>(null);
                dgvClanovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception)
            {

            }

        }
        private async Task LoadFormaClan()
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
            txtKorisnickoIme.Text = entity.KorisnickoIme;
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
                await LoadFormaClan();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
                if (_id.HasValue && _korisnikId.HasValue)
                {
                    updateRequest.Ime = txtIme.Text;
                updateRequest.Prezime = txtPrezime.Text;
                updateRequest.Email = txtEmail.Text;
                updateRequest.DatumRodjenja = dtpDatumRodjenja.Value.Date;
                updateRequest.BrojTelefona = txtBrojTelefona.Text;
                updateRequest.Aktivan = cBoxAktivan.Checked;
                updateRequest.Photo = photoHelper.ImageToByteArray(pictureBox.Image);
                updateRequest.PhotoThumb = photoHelper.ImageToByteArray(pictureBox.Image);
                updateRequest.Dijagnoza = txtDijagnoza.Text;
                updateRequest.KorisnickoIme = txtKorisnickoIme.Text;
                var korisnik=   await _apiService.GetById<Data.ClanDTO>(_id);
                try
                {
                    if (!ValidacijaEmail && korisnik.Email!=txtEmail.Text)
                    {
                        MessageBox.Show("Email ne odgovara");
                        throw new Exception();
                    }
                    if (!ValidacijaKorisnickoIme && korisnik.KorisnickoIme != txtKorisnickoIme.Text)
                    {
                        MessageBox.Show("Korisničko ime ne odgovara");
                        throw new Exception();
                    }
                    await _apiService.Update<Data.ClanDTO>(_korisnikId ?? 0, updateRequest);
                    MessageBox.Show("Uspjesno uređen član");


                }
                catch (Exception)
                {
                    if (ValidacijaEmail)
                    {
                        MessageBox.Show("Podaci ne odgovaraju");
                    }
                    if (ValidacijaKorisnickoIme)
                    {
                        MessageBox.Show("Podaci ne odgovaraju");
                    }
                    await LoadFormaClan();
                }
            }
            else
            {
                if (this.ValidateChildren()) {

                    insertRequest.Ime = txtIme.Text;
                    insertRequest.Prezime = txtPrezime.Text;
                    insertRequest.Email = txtEmail.Text;
                    insertRequest.DatumRodjenja = dtpDatumRodjenja.Value.Date;
                    insertRequest.BrojTelefona = txtBrojTelefona.Text;
                    insertRequest.Aktivan = cBoxAktivan.Checked;
                    insertRequest.Photo = photoHelper.ImageToByteArray(pictureBox.Image);
                    insertRequest.PhotoThumb = photoHelper.ImageToByteArray(pictureBox.Image);
                    insertRequest.Dijagnoza = txtDijagnoza.Text;
                    insertRequest.KorisnickoIme = txtKorisnickoIme.Text;
                    insertRequest.Password = txtIme.Text + txtPrezime.Text + "1$Aa";
                    insertRequest.PasswordPotvrda = txtIme.Text + txtPrezime.Text + "1$Aa";
                    try
                    {
                        if (!ValidacijaEmail)
                        {
                            MessageBox.Show("Email ne odgovara");
                            throw new Exception();
                        }
                        if (!ValidacijaKorisnickoIme)
                        {
                            MessageBox.Show("Korisničko ime ne odgovara");
                            throw new Exception();
                        }
                        await _apiService.Insert<Data.ClanDTO>(insertRequest);
                        MessageBox.Show("Uspjesno dodan član");

                    }
                    catch (Exception)
                    {
                        if (ValidacijaEmail)
                        {
                            MessageBox.Show("Podaci ne odgovaraju");
                        }
                        if (ValidacijaKorisnickoIme)
                        {
                            MessageBox.Show("Podaci ne odgovaraju");
                        }
                    }
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
            await LoadFormaClan();
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
            txtBrojTelefona.Text = "";
            txtPrezime.Text = "";
            txtPhoto.Text = "";
            txtDijagnoza.Text = "";
            txtKorisnickoIme.Text = "";
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

        private async void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Data.KorisniciSistema korisnik = await _apiServiceProvjera.Get<Data.KorisniciSistema>(new PotvrdaSearchRequest
            {
                Email = txtEmail.Text
            });
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(txtEmail.Text);
            if (txtEmail.Text.ToString().Length < 2 )
            {
                errorProvider.SetError(txtEmail, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;   
            }
            else if (!match.Success)
            {
                errorProvider.SetError(txtEmail, Properties.Resources.ValidationEmailField);
                e.Cancel = true;
            } 
            else if (korisnik != null)
            {
                errorProvider.SetError(txtEmail, Properties.Resources.EmailIsUsing);
                e.Cancel = true;
                ValidacijaEmail = false;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
                ValidacijaEmail = true;

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

        private async void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            Data.KorisniciSistema korisnik = await _apiServiceProvjera.Get<Data.KorisniciSistema>(new PotvrdaSearchRequest
            {
                KorisnickoIme = txtKorisnickoIme.Text
            });

            if (txtKorisnickoIme.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;

            }
            else if (korisnik != null)
            {

                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.UserNameIsUsing);
                e.Cancel = true;
                ValidacijaKorisnickoIme = false;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
                ValidacijaKorisnickoIme = true;

            }
        }
    }
}
