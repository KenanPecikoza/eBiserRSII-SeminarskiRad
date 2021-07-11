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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBiser.WindowsUI.Obavijest
{
    public partial class frmObavijestUpsert : Form
    {
        private readonly APIService _apiService = new APIService("Obavijest");
        private readonly APIService _apiServiceKategorija = new APIService("ObavijestKategorija");

        private int? _id = null;
        private readonly PhotoHelper photoHelper = new PhotoHelper();
        public frmObavijestUpsert(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }
        private async Task LoadDGVObavijesti()
        {
            //dgvObavijesti.AutoGenerateColumns = false;
            
            dgvObavijesti.DataSource = await _apiService.Get<List<Data.Obavijest>>(null);
            dgvObavijesti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvObavijesti.ClearSelection();
        }
        private async Task LoadFormaObavijest(int? id)
        {

            flowLayoutPanel1.Controls.Clear();
            var entity = await _apiService.GetById<Data.Obavijest>(_id);
            dtmPocetak.Value = entity.DatumObjave.Date;
            dtmKraj.Value = entity.VrijediDo.Date;
            txtSadržaj.Text = entity.Sadržaj;
            txtNaslov.Text = entity.Naslov;
            cbxAktivna.Checked = entity.Aktivna;
            cBoxKategorija.SelectedValue = entity.KategorijaId;

            foreach (var p in entity.Fotografije)
            {
                PictureBox pb = new PictureBox();
                pb.Image = photoHelper.ByteArrayToImage(p);
                flowLayoutPanel1.Controls.Add(pb);
                flowLayoutPanel1.AutoScroll = true;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                request.Fotografije.Add(p);
                request.Fotografije.ToList();
            }
        }

        ObavijestInsertRequest request = new ObavijestInsertRequest();
        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            var result= openFileDialog.ShowDialog();
            
            if (result== DialogResult.OK)
            {
                foreach (var file in openFileDialog.FileNames)
                {
                    PictureBox pb = new PictureBox();
                    Image loadedImage = Image.FromFile(file);
                    pb.Image = loadedImage;
                    txtPhoto.Text += file;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    flowLayoutPanel1.Controls.Add(pb);
                    flowLayoutPanel1.AutoScroll = true;
                    var photo = File.ReadAllBytes(file);
                    request.Fotografije.Add(photo);
                    request.Fotografije.ToList();
                }
            }
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            request.DatumObjave = dtmPocetak.Value;
            request.VrijediDo = dtmKraj.Value;
            request.Sadržaj = txtSadržaj.Text;
            request.Naslov = txtNaslov.Text;
            request.Aktivna = cbxAktivna.Checked;
            request.OsobljeId = APIService.Id;
            request.KategorijaId = Int32.Parse(cBoxKategorija.SelectedValue.ToString());
            if (_id.HasValue)
            {
                try
                {
                    await _apiService.Update<ObavijestInsertRequest>(_id ?? 0, request);
                    MessageBox.Show("Uspjesno uređena obavijest");
                }
                catch (Exception)
                {

                    MessageBox.Show("Podaci ne odgovaraju");
                }

            }
            else
            {
                try
                {
                    await _apiService.Insert<ObavijestInsertRequest>(request);
                    MessageBox.Show("Uspjesno dodana obavijest");
                }
                catch (Exception)
                {
                    MessageBox.Show("Podaci ne odgovaraju");
                }

            }

            await LoadDGVObavijesti();
        }

        private async void frmObavijestUpsert_Load(object sender, EventArgs e)
        {
            var kategorije = await _apiServiceKategorija.Get<List<Data.ObavijestKategorija>>(null);
            cBoxKategorija.DataSource = kategorije;
            cBoxKategorija.DisplayMember = "NazivKategorije";
            cBoxKategorija.ValueMember = "Id";
            if (_id.HasValue)
            {
                await LoadFormaObavijest(_id ?? 0);
            }
            await LoadDGVObavijesti();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dgvObavijesti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _id = Int32.Parse(dgvObavijesti.SelectedRows[0].Cells[0].Value.ToString());
                await LoadFormaObavijest(_id ?? 0);
            }
            catch (Exception)
            {

            }

        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (txtNaslov.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtNaslov, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNaslov, null);
            }
        }

        private void txtSadržaj_Validating(object sender, CancelEventArgs e)
        {
            if (txtSadržaj.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtSadržaj, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtSadržaj, null);
            }
        }

        private void btnOcjene_Click(object sender, EventArgs e)
        {
            frmObavijestiOcjene frmObavijestiOcjene = new frmObavijestiOcjene(_id);
            frmObavijestiOcjene.Show();

        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            txtNaslov.Text = "";
            _id = null;
            dtmPocetak.Value = DateTime.Now.Date;
            dtmKraj.Value = DateTime.Now.Date;
            txtPhoto.Text = "";
            cBoxKategorija.SelectedIndex = 1;
            cbxAktivna.Checked = false;
            txtSadržaj.Text = "";
            flowLayoutPanel1.Controls.Clear();
            dgvObavijesti.ClearSelection();
        }
    }
}
