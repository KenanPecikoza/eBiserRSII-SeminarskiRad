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

namespace eBiser.WindowsUI.Osoblje
{
    public partial class frmOsobljeUpsert : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik/Osoblje");
        private readonly APIService _apiServiceDjelatnost = new APIService("DjelatnostOsoblje");
        private readonly APIService _apiServiceProvjera = new APIService("Korisnik/potvrda");
        private bool ValidacijaEmail;
        private bool ValidacijaKorisnickoIme;

        private int? _id = null;
        private int? _Korisnikid = null;
        private readonly PhotoHelper photoHelper = new PhotoHelper();

        public frmOsobljeUpsert(int? id =null)
        {
            _id = id;
            InitializeComponent();
        }
        private async Task LoadForm()
        {
            var result = await _apiService.GetById<Data.OsobljeDTO>(_id);
            txtIme.Text = result.Ime;
            txtPrezime.Text = result.Prezime;
            cBoxNazivDjelatnosti.SelectedValue = result.DjelatnostId;
            dtmDatumPocetka.Value = result.DatumPocetkaAngazmana;
            pictureBox.Image = photoHelper.ByteArrayToImage(result.Photo);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            txtKorisnickoIme.Text = result.KorisnickoIme;
            txtEmail.Text = result.Email;
        }
        private async Task LoadDGV()
        {
            dgvOsoblje.AutoGenerateColumns = false;
            var result = await _apiService.Get<List<Data.OsobljeDTO>>(null);
            dgvOsoblje.DataSource = result;
            dgvOsoblje.ClearSelection();
            dgvOsoblje.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private async Task LoadDjelatnosti()
        {
            var djelatnosti = await _apiServiceDjelatnost.Get<List<Data.DjelatnostOsoblje>>(null);
            cBoxNazivDjelatnosti.DataSource = djelatnosti;
            cBoxNazivDjelatnosti.DisplayMember = "NazivDjelatnosti";
            cBoxNazivDjelatnosti.ValueMember = "Id";
        }


        private async void frmOsobljeUpsert_Load(object sender, EventArgs e)
        {
            await LoadDjelatnosti();
            await LoadDGV();
            if (_id.HasValue)
            {
                await LoadForm();
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
            txtEmail.Text = "";
            _id = null;
        }

        OsobljeUpdateRequest updateRequest = new OsobljeUpdateRequest();
        OsobljeUpsertRequest insertRequest = new OsobljeUpsertRequest();
        private async void btnSnimi_Click(object sender, EventArgs e)
        {

            if (_id.HasValue && _Korisnikid.HasValue)
            {
                updateRequest.Ime = txtIme.Text;
                updateRequest.Prezime = txtPrezime.Text;
                updateRequest.DjelatnostId = Int32.Parse(cBoxNazivDjelatnosti.SelectedValue.ToString());
                updateRequest.Photo = photoHelper.ImageToByteArray(pictureBox.Image);
                updateRequest.PhotoThumb = photoHelper.ImageToByteArray(pictureBox.Image);
                updateRequest.KorisnickoIme = txtKorisnickoIme.Text;
                updateRequest.DatumPocetkaAngazmana = dtmDatumPocetka.Value;
                updateRequest.DatumRodjenja = DateTime.Now;
                updateRequest.DjelatnostId = Int32.Parse(cBoxNazivDjelatnosti.SelectedValue.ToString());
                updateRequest.Email =txtEmail.Text;
                var korisnik = await _apiService.GetById<Data.OsobljeDTO>(_id);

                try
                {
                    if (!ValidacijaEmail && korisnik.Email != txtEmail.Text)
                    {
                        MessageBox.Show("Email ne odgovara");
                        throw new Exception();
                    }
                    if (!ValidacijaKorisnickoIme && korisnik.KorisnickoIme != txtKorisnickoIme.Text)
                    {
                        MessageBox.Show("Korisničko ime ne odgovara");
                        throw new Exception();
                    }
                    await _apiService.Update<Data.KorisniciSistema>(_Korisnikid ?? 0, updateRequest);
                    MessageBox.Show("Uspjesno uređen član osoblja ");
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
                    await LoadForm();
                }

            }
            else
            {
                insertRequest.Ime = txtIme.Text;
                insertRequest.Prezime = txtPrezime.Text;
                insertRequest.Photo = photoHelper.ImageToByteArray(pictureBox.Image);
                insertRequest.PhotoThumb = photoHelper.ImageToByteArray(pictureBox.Image);
                insertRequest.KorisnickoIme = txtKorisnickoIme.Text;
                insertRequest.Password = txtIme.Text + txtPrezime.Text + "1$Aa";
                insertRequest.PasswordPotvrda = txtIme.Text + txtPrezime.Text + "1$Aa";
                insertRequest.DatumPocetkaAngazmana = dtmDatumPocetka.Value;
                insertRequest.Email = txtEmail.Text;
                insertRequest.DatumRodjenja = DateTime.Now;
                insertRequest.DjelatnostId = Int32.Parse(cBoxNazivDjelatnosti.SelectedValue.ToString());
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
                    MessageBox.Show("Uspjesno dodan član osoblja");

                }
                catch (Exception)
                {
                    if (ValidacijaEmail )
                    {
                        MessageBox.Show("Podaci ne odgovaraju");
                    }
                    if (ValidacijaKorisnickoIme)
                    {
                        MessageBox.Show("Podaci ne odgovaraju");
                    }
                }
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
                if (_id.HasValue && _Korisnikid.HasValue)
                {
                    updateRequest.Photo = file;
                    updateRequest.PhotoThumb = file;
                }
                else
                {
                    insertRequest.Photo = file;
                    insertRequest.PhotoThumb = file;
                }
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
            try
            {
                var id = Int32.Parse(dgvOsoblje.SelectedRows[0].Cells[0].Value.ToString());
                var korisnikid = Int32.Parse(dgvOsoblje.SelectedRows[0].Cells[1].Value.ToString());
                _id = id;
                _Korisnikid = korisnikid;
                await LoadForm();
            }
            catch (Exception)
            {

            }
        }

        private void btnIzadji_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (txtIme.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtIme,Properties.Resources.ValidationRequiredField);
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
            else if (korisnik!=null)
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

        private async void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Data.KorisniciSistema korisnik = await _apiServiceProvjera.Get<Data.KorisniciSistema>(new PotvrdaSearchRequest
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
            else if (korisnik!=null)
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
    }
}
