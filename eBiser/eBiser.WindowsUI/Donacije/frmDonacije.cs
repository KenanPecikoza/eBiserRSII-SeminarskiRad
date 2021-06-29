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


namespace eBiser.WindowsUI.Donacije
{
    public partial class frmDonacije : Form
    {
        private readonly APIService _apiService = new APIService("Donacije");
        DonacijeSearchRequest request = null;
        public frmDonacije()
        {
            InitializeComponent();
        }
        private async Task LoadDGV()
        {
            var result = await _apiService.Get<List<Data.Donacije>>(request);
            //dgvDonacije.AutoGenerateColumns = false;
            dgvDonacije.DataSource = result;
            dgvDonacije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private async void frmDonacije_Load(object sender, EventArgs e)
        {
            await LoadDGV();

        }

        private async void btnPretraziSadrzaj_Click(object sender, EventArgs e)
        {
            request = new DonacijeSearchRequest();
            request.DatumPrijave = dtmPretragaDatum.Value;
            request.Naziv = txtPretragaPoNaslovu.Text;
            request.OpisDonacije = txtPretragaPoSadrzaju.Text;
            await LoadDGV();
        }

        private void dgvDonacije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Int32.Parse(dgvDonacije.SelectedRows[0].Cells[0].Value.ToString());
                frmDonacijeUpsert clanoviUpsert = new frmDonacijeUpsert(id);
                clanoviUpsert.Show();
                this.Close();

            }
            catch (Exception)
            {

            }
        }
    }
}
