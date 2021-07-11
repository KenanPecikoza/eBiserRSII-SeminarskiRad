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

namespace eBiser.WindowsUI.AkcijePomoci
{
    public partial class frmAkcijePomociUpsert : Form
    {
        private readonly APIService _apiService = new APIService("akcijepomoci");
        private int? _id = null;
        private readonly PhotoHelper photoHelper = new PhotoHelper();

        public frmAkcijePomociUpsert(int? id=null)
        {
            _id = id;
            InitializeComponent();
        }
        private async Task PopuniFormu(int? id)
        {
            var entity = await _apiService.GetById<Data.AkcijePomoci>(id);
            txtIme.Text = entity.Ime;
            txtPrezime.Text = entity.Prezime;
            numTrazenaCifra.Value = (decimal)entity.TraženaCifra;
            numSakupljeno.Value = (decimal)entity.Skupljeno;
            chBoxAktivno.Checked = entity.Aktivno;
            pictureBox1.Image = photoHelper.ByteArrayToImage(entity.Fotografija);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            txtPhoto.Text = "";
        }
        private async Task PopuniDGV()
        {
            var result = await _apiService.Get<List<Data.AkcijePomoci>>(null);
            dgvAkcijePomoci.AutoGenerateColumns = false;
            dgvAkcijePomoci.DataSource = result;
            dgvAkcijePomoci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private async void frmAkcijePomociUpsert_Load(object sender, EventArgs e)
        {
             await PopuniDGV();
            if (_id.HasValue)
            {
                await PopuniFormu(_id ?? 0);
            }
            else
            {
                dgvAkcijePomoci.ClearSelection();
            }
        }

   


        private void btnPoniši_Click(object sender, EventArgs e)
        {
            _id = null;
            txtIme.Text = "";
            txtPrezime.Text = "";
            numSakupljeno.Value = 0;
            numTrazenaCifra.Value = 0;
            chBoxAktivno.Checked = true;
            dgvAkcijePomoci.ClearSelection();
            pictureBox1.Image = null;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        AkcijePomociUpsertRequest request = new AkcijePomociUpsertRequest();

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                request.Ime = txtIme.Text;
                request.Prezime = txtPrezime.Text;
                request.Skupljeno = (double)numSakupljeno.Value;
                request.TraženaCifra = (double)numTrazenaCifra.Value;
                request.Aktivno = chBoxAktivno.Checked;
                request.Fotografija = photoHelper.ImageToByteArray(pictureBox1.Image);

                if (_id.HasValue)
                {
                    try
                    {
                        await _apiService.Update<Data.AkcijePomoci>(_id ??0, request);
                        MessageBox.Show("Uspjesno uređena akcija pomoći");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nije uspjelo uređenje akcija pomoći");
                    }

                }
                else
                {
                    try
                    {
                        await _apiService.Insert<Data.AkcijePomoci>(request);
                        MessageBox.Show("Uspjesno dodana akcija pomoći");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nije uspjelo dodavanje akcije pomoći");

                    }
                }
                await PopuniDGV();

            }
        }

        private void btnIzađi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Fotografija = file;
                txtPhoto.Text = fileName;
                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
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

        private async void dgvAkcijePomoci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _id = Int32.Parse(dgvAkcijePomoci.SelectedRows[0].Cells[0].Value.ToString());
                await PopuniFormu(_id);

            }
            catch (Exception)
            {

            }
        }
    }
}
