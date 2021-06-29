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

namespace eBiser.WinUi.Sastanak
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
            cBoxZapisnicar.SelectedItem = result.OsobljeId-1;
            dtmDatumOdzavanja.Value = result.DatumOdrzavanja;
        }
        private async Task LoadDGV()
        {
            var result = await _apiService.Get<List<Data.Sastanak>>(null);
            dgvSastanci.DataSource = result;
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
            request.Odrzan = true;
            request.Zapisnik = txtZapisnik.Text;
            request.OsobljeId = Int32.Parse(cBoxZapisnicar.SelectedValue.ToString());
            request.DatumOdrzavanja = dtmDatumOdzavanja.Value;
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
        private void btnPonisti_Click(object sender, EventArgs e)
        {
            cBoxZapisnicar.SelectedIndex = 0;
            txtZapisnik.Text = "";
            dtmDatumOdzavanja.Value = DateTime.Now;
        }

        private async void dgvSastanci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Int32.Parse(dgvSastanci.SelectedRows[0].Cells[0].Value.ToString());
            await LoadForm(_id);
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
