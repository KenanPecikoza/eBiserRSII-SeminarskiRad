using eBiser.Data.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBiser.WindowsUI;

namespace eBiser.WindowsUI.Sastanak
{
    public partial class frmSastanakUpsert : Form
    {
        private readonly APIService _apiService = new APIService("Sastanak");
        private readonly APIService _apiServiceOsoblje = new APIService("korisnik/Osoblje");
        private int? _id = null;


        public frmSastanakUpsert(int? id=null)
        {
            InitializeComponent();
            _id = id;
        }
        private async Task LoadOsoblje()
        {
            var result = await _apiServiceOsoblje.Get<List<Data.OsobljeDTO>>(null);
            cBoxZapisnicar.DataSource = result;
            cBoxZapisnicar.DisplayMember = "KorisnickoIme";
            cBoxZapisnicar.ValueMember = "Id";
        }

        private async Task LoadForm(int? Id)
        {
            var result = await _apiService.GetById<Data.Sastanak>(Id);
            txtZapisnik.Text = result.Zapisnik;
            cBoxZapisnicar.SelectedValue = result.OsobljeId;
            dtmDatumOdzavanja.Value = result.DatumOdrzavanja;
            txtNaslov.Text = result.Naslov;

        }
        private async Task LoadDGV()
        {
            dgvSastanci.AutoGenerateColumns = false;
            var result = await _apiService.Get<List<Data.Sastanak>>(null);
            dgvSastanci.DataSource = result;
            dgvSastanci.ClearSelection();
            dgvSastanci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private async void frmSastanakUpsert_Load(object sender, EventArgs e)
        {
            await LoadDGV();
            await LoadOsoblje();
            if (_id.HasValue)
            {
               await LoadForm(_id);
            }
        }
        SastanakUpsertRequest request = new SastanakUpsertRequest();
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                request.Odrzan = true;
                request.Zapisnik = txtZapisnik.Text;
                request.OsobljeId = Int32.Parse(cBoxZapisnicar.SelectedValue.ToString());
                request.DatumOdrzavanja = dtmDatumOdzavanja.Value;
                request.Naslov = txtNaslov.Text;
                if (_id.HasValue)
                {
                    await _apiService.Update<Data.Sastanak>(_id ?? 0, request);
                    MessageBox.Show("Uspjesno uređen sastanak ");
                }
                else
                {
                    await _apiService.Insert<Data.Sastanak>(request);
                    MessageBox.Show("Uspjesno dodan sastanak");
                }
                await LoadDGV();
            }

        }
        private void btnPonisti_Click(object sender, EventArgs e)
        {
            cBoxZapisnicar.SelectedIndex = 0;
            txtZapisnik.Text = "";
            dtmDatumOdzavanja.Value = DateTime.Now;
            txtNaslov.Text = "";
            _id = null;
        }

        private async void dgvSastanci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _id = Int32.Parse(dgvSastanci.SelectedRows[0].Cells[0].Value.ToString());
                await LoadForm(_id);
            }
            catch (Exception)
            {

            }
        }

        private void txtZapisnik_Validating(object sender, CancelEventArgs e)
        {
            if (txtZapisnik.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtZapisnik, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtZapisnik, null);
            }
        }
    }
}
