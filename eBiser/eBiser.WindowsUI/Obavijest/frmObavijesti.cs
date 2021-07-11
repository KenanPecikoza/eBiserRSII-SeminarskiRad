using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBiser.WindowsUI.Obavijest
{
    public partial class frmObavijesti : Form
    {
        private readonly APIService _apiService = new APIService("Obavijest");
        private readonly APIService _apiServiceKategorija = new APIService("ObavijestKategorija");

        public frmObavijesti()
        {
            InitializeComponent();
        }
        private async Task LoadDGV(int? KateogirjaId=null)
        {
            dgvObavijesti.AutoGenerateColumns = false;
            if (KateogirjaId!=null)
            {
                var search = new Data.Requests.ObavijestSearchRequest()
                {
                    KategorijaId = KateogirjaId
                };
                dgvObavijesti.DataSource = await _apiService.Get<List<Data.Obavijest>>(search);
            }
            else
            {
                dgvObavijesti.DataSource = await _apiService.Get<List<Data.Obavijest>>(null);
            }
            dgvObavijesti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private async void Obavijesti_Load(object sender, EventArgs e)
        {
            var kategorije = await _apiServiceKategorija.Get<List<Data.ObavijestKategorija>>(null);
            cBoxKategorija.DataSource = kategorije;
            cBoxKategorija.DisplayMember = "NazivKategorije";
            cBoxKategorija.ValueMember = "Id";// u prorertis postaviti 
            await LoadDGV();


        }
        private async void btnPretraziSadrzaj_Click(object sender, EventArgs e)
        {
            var search = new Data.Requests.ObavijestSearchRequest()
            {
                PretragaPoNaslovu = txtPretragaPoNaslovu.Text,
                PretragaPoSadrzaju = txtPretragaPoSadrzaju.Text
            };
            dgvObavijesti.DataSource = await _apiService.Get<List<Data.Obavijest>>(search);

        }
        private async void btnPrezraziDatum_Click(object sender, EventArgs e)
        {
            var search = new Data.Requests.ObavijestSearchRequest()
            {
                PretragaPoDatumuDo = dtmPretragado.Value,
                PretragaPoDatumuOd = dtmPretragaOd.Value,
            };
            dgvObavijesti.DataSource = await _apiService.Get<List<Data.Obavijest>>(search);

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var search = new Data.Requests.ObavijestSearchRequest()
            {
                PretragaPoDatumuDo = dtmPretragado.Value,
                PretragaPoDatumuOd = dtmPretragaOd.Value,
                PretragaPoNaslovu = txtPretragaPoNaslovu.Text,
                PretragaPoSadrzaju = txtPretragaPoSadrzaju.Text
            };
            dgvObavijesti.DataSource = await _apiService.Get<List<Data.Obavijest>>(search);


        }

        private void dgvObavijesti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var obavijestId = Int32.Parse(dgvObavijesti.SelectedRows[0].Cells[0].Value.ToString());
                frmObavijestUpsert obavijestUpsert = new frmObavijestUpsert(obavijestId);
                obavijestUpsert.Show();
                this.Close();
            }
            catch (Exception)
            {

            }

        }

        private void btnDodajObavijest_Click(object sender, EventArgs e)
        {
            frmObavijestUpsert obavijestUpsert = new frmObavijestUpsert();
            obavijestUpsert.Show();
            this.Close();
        }

        private async void cBoxKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = cBoxKategorija.SelectedValue;

            if (int.TryParse(selectedValue.ToString(), out int KategorijaId))
            {
                await LoadDGV(KategorijaId);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
