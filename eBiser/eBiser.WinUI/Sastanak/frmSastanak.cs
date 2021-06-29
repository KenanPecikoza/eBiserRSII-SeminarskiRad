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
    public partial class frmSastanak : Form
    {
        private readonly APIService _apiService = new APIService("Sastanak");
        public frmSastanak()
        {

            InitializeComponent();
        }
        private async Task LoadDGV()
        {
            //dgvSastanci.AutoGenerateColumns = false;
            //dgvSastanci.AutoSize = true;
            var result = await _apiService.Get<List<Data.Sastanak>>(null);
            dgvSastanci.DataSource = result;
        }

        private async void frmSastanak_Load(object sender, EventArgs e)
        {
            await LoadDGV();
        }
        SastanakSearchRequest search = new SastanakSearchRequest();
        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            search.Dan =(int)numDan.Value;
            search.Mjesec =(int)numMjesec.Value;
            search.Godina =(int)numGodina.Value;
            var result = await _apiService.Get<List<Data.Sastanak>>(search);
            dgvSastanci.DataSource = result;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmSastanakUpsert frmSastanakUpsert = new frmSastanakUpsert();
            frmSastanakUpsert.Show();
        }
    }
}
