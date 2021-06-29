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

namespace eBiser.WindowsUI.Osoblje
{
    public partial class frmOsoblje : Form
    {
        private readonly APIService _aPIService = new APIService("Korisnik/Osoblje");
        private readonly APIService _apiServiceDjelatnost = new APIService("DjelatnostOsoblje");

        public frmOsoblje()
        {
            InitializeComponent();
        }
        private async Task LoadDjelatnosti()
        {
            var djelatnosti = await _apiServiceDjelatnost.Get<List<Data.DjelatnostOsoblje>>(null);
            cBoxNazivDjelatnosti.DataSource = djelatnosti;
            cBoxNazivDjelatnosti.DisplayMember = "NazivDjelatnosti";
            cBoxNazivDjelatnosti.ValueMember = "Id";// u prorertis postaviti 

        }


        private async void frmOsoblje_Load(object sender, EventArgs e)
        {
            dgvOsoblje.AutoGenerateColumns = false;
            var result = await _aPIService.Get<List<Data.OsobljeDTO>>(null);
            dgvOsoblje.DataSource = result;
            dgvOsoblje.ClearSelection();
            dgvOsoblje.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            await LoadDjelatnosti();
        }

        KorisniciSearchRequest search = new KorisniciSearchRequest();
        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            search.Ime = txtIme.Text;
            search.Prezime = txtPrezime.Text;
            var result = await _aPIService.Get<List<Data.OsobljeDTO>>(search);
            dgvOsoblje.DataSource = result;
            dgvOsoblje.ClearSelection();
            dgvOsoblje.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmOsobljeUpsert frmOsobljeUpsert = new frmOsobljeUpsert();
            frmOsobljeUpsert.Show();

        }
        private void cBoxNazivDjelatnosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = cBoxNazivDjelatnosti.SelectedValue;
            int.TryParse(selectedValue.ToString(), out int DjelatnostId);
            //search.DjelatnostId = DjelatnostId;

        }

        private void dgvOsoblje_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = Int32.Parse(dgvOsoblje.SelectedRows[0].Cells[0].Value.ToString());
                frmOsobljeUpsert frmOsobljeUpsert = new frmOsobljeUpsert(id);
                frmOsobljeUpsert.Show();
                this.Close();
            }
            catch (Exception)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
