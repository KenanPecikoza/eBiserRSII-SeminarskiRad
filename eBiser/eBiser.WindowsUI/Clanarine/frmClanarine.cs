using System.Windows.Forms;
using eBiser.Data.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBiser.WindowsUI.Clanarine
{
    public partial class frmClanarine : Form
    {
        private readonly APIService _apiService = new APIService("clanarina");

        public frmClanarine()
        {
            InitializeComponent();
        }

        private async void frmClanarine_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Data.Clanarina>>("");
            dgvClanarine.AutoGenerateColumns = false;
            dgvClanarine.DataSource = result;
            dgvClanarine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        ClanarinaSearchRequest searchRequest = new ClanarinaSearchRequest();
        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            searchRequest.Godina = Convert.ToInt32(numGodina.Value);
            searchRequest.Mjesec = Convert.ToInt32(numMjesec.Value);
            searchRequest.Ime = txtIme.Text;
            searchRequest.Prezime = txtPrezime.Text;
            var result= await _apiService.Get<List<Data.Clanarina>>(searchRequest);
            dgvClanarine.DataSource = result;
            dgvClanarine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvClanarine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Int32.Parse(dgvClanarine.SelectedRows[0].Cells[0].Value.ToString());
            frmClanarineUpsert frmClanarineUpsert = new frmClanarineUpsert(Id);
            frmClanarineUpsert.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmClanarineUpsert frmClanarineUpsert = new frmClanarineUpsert();
            frmClanarineUpsert.Show();
        }
    }
}
