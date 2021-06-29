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

namespace eBiser.WinUi.IzlaznaSerdstva
{
    public partial class frmIzlaznaSredstvaUpsert : Form
    {
        private readonly APIService _apiService = new APIService("IzlaznaSredstva");
        private int? _id = null;
        private readonly PhotoHelper photoHelper = new PhotoHelper();
        public frmIzlaznaSredstvaUpsert(int? id=null)
        {
            _id = id;
            InitializeComponent();
        }
        private async Task LoadDGV()
        {
            var result = await _apiService.Get<List<Data.IzlaznaSredstva>>(null);
            dgvIzlaznaSredstva.DataSource = result;
            dgvIzlaznaSredstva.AutoGenerateColumns = false;
            dgvIzlaznaSredstva.AutoSize = true;

        }
        private async Task LoadForm(int? Id)
        {
            var result = await _apiService.GetById<Data.IzlaznaSredstva>(Id);
            txtNaslov.Text = result.Naslov;
            txtOpis.Text = result.Opis;
            numIznos.Value =(decimal) result.Količina;
            dtmDatum.Value = result.Datum;
            dgvIzlaznaSredstva.ClearSelection();
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


        private async void frmIzlaznaSredstvaUpsert_Load(object sender, EventArgs e)
        {
            await LoadDGV();
            dgvIzlaznaSredstva.ClearSelection();

        }
        IzlaznaSredstvaUpsertRequest request = new IzlaznaSredstvaUpsertRequest();

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            request.Datum = dtmDatum.Value;
            request.Količina = (double)numIznos.Value;
            request.Naslov = txtNaslov.Text;
            request.Opis = txtOpis.Text;
            request.OsobljeId = APIService.Id;
            if (_id.HasValue)
            {
                await _apiService.Update<IzlaznaSredstvaUpsertRequest>(_id??0 ,request);
            }
            else
            {
                await _apiService.Insert<IzlaznaSredstvaUpsertRequest>(request);
            }
            await LoadDGV();

        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            txtPhoto.Text = "";
            txtNaslov.Text = "";
            txtOpis.Text = "";
            numIznos.Value = 0;
            dtmDatum.Value = DateTime.Now;
            dgvIzlaznaSredstva.ClearSelection();
            _id = null;
            flowLayoutPanel1.Controls.Clear();

        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dgvIzlaznaSredstva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Int32.Parse(dgvIzlaznaSredstva.SelectedRows[0].Cells[0].Value.ToString());
            await LoadForm(_id);
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
