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
            if (this.ValidateChildren())
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
                    MessageBox.Show("Podaci ne odgovaraju");
                }
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNalov_Validating(object sender, CancelEventArgs e)
        {
            if (txtNalov.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtNalov, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNalov, null);
            }
        }
    }
}
