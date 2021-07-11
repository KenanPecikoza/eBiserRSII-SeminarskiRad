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

namespace eBiser.WindowsUI.UlaznaSredstva
{
    public partial class frmUlaznaSredstvaUpsert : Form
    {
        private readonly APIService _apiService = new APIService("UlaznaSredstva");
        private int? _id = null;
        private readonly PhotoHelper photoHelper = new PhotoHelper();
        public frmUlaznaSredstvaUpsert(int? id=null)
        {
            _id = id;
            InitializeComponent();
        }
        private async Task LoadDGV()
        {
            var result = await _apiService.Get<List<Data.UlaznaSredstva>>(null);
            dgvUlaznaSredstva.DataSource = result;
            dgvUlaznaSredstva.AutoGenerateColumns = false;
            dgvUlaznaSredstva.AutoSize = true;

        }
        private async Task LoadForm(int? Id)
        {
            var result = await _apiService.GetById<Data.IzlaznaSredstva>(Id);
            txtNaslov.Text = result.Naslov;
            txtOpis.Text = result.Opis;
            numIznos.Value = (decimal)result.Količina;
            dtmDatum.Value = result.Datum;
            flowLayoutPanel1.Controls.Clear();
            foreach (var file in result.Fotografije)
            {
                PictureBox pb = new PictureBox();
                pb.Image = photoHelper.ByteArrayToImage(file);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel1.Controls.Add(pb);
            }
        }
        private async  void frmUlaznaSredstvaUpsert_Load(object sender, EventArgs e)
        {
            await LoadDGV();
            dgvUlaznaSredstva.ClearSelection();
            if (_id.HasValue)
            {
                await LoadForm(_id);
            }
        }
        UlaznaSredstvaUpsertRequest request = new UlaznaSredstvaUpsertRequest();

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                request.Datum = dtmDatum.Value;
                request.Količina = (double)numIznos.Value;
                request.Naslov = txtNaslov.Text;
                request.Opis = txtOpis.Text;
                request.OsobljeId = APIService.Id;
                if (_id.HasValue)
                {
                    await _apiService.Update<UlaznaSredstvaUpsertRequest>(_id ?? 0, request);
                }
                else
                {
                    await _apiService.Insert<IzlaznaSredstvaUpsertRequest>(request);
                }
                await LoadDGV();
                dgvUlaznaSredstva.ClearSelection();
            }
          
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            txtPhoto.Text = "";
            txtNaslov.Text = "";
            txtOpis.Text = "";
            numIznos.Value = 0;
            dtmDatum.Value = DateTime.Now;
            dgvUlaznaSredstva.ClearSelection();
            flowLayoutPanel1.Controls.Clear();
            _id = null;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dgvUlaznaSredstva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _id = Int32.Parse(dgvUlaznaSredstva.SelectedRows[0].Cells[0].Value.ToString());
                await LoadForm(_id);

            }
            catch (Exception)
            {

            }
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (var file in openFileDialog.FileNames)
                {
                    PictureBox pb = new PictureBox();
                    Image loadedImage = Image.FromFile(file);
                    pb.Image = loadedImage;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtPhoto.Text += file;
                    flowLayoutPanel1.AutoScroll = true;
                    flowLayoutPanel1.Controls.Add(pb);
                    var photo = File.ReadAllBytes(file);
                    request.Fotografije.Add(photo);
                    request.Fotografije.ToList();
                }
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

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (txtOpis.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtOpis, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtOpis, null);
            }
        }
    }
}
