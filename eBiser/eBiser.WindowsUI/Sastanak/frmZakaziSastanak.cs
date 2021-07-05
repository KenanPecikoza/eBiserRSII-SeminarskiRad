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

namespace eBiser.WindowsUI.Sastanak
{
    public partial class frmZakaziSastanak : Form
    {
        private readonly APIService _apiService = new APIService("Sastanak");

        public frmZakaziSastanak()
        {
            InitializeComponent();
        }
        SastanakUpsertRequest upsertRequest = new SastanakUpsertRequest();

        private async void btnZakazi_Click(object sender, EventArgs e)
        {
            upsertRequest.DatumOdrzavanja = dtmDatumOdrzavanja.Value;
            upsertRequest.Odrzan = false;
            upsertRequest.OsobljeId = APIService.Id;
            upsertRequest.Zakazan = true;
            upsertRequest.Naslov = txtNalov.Text;
            try
            {
                await _apiService.Insert<Data.Sastanak>(upsertRequest);
                MessageBox.Show("Uspješno zakazn sastanak");
            }
            catch (Exception)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
