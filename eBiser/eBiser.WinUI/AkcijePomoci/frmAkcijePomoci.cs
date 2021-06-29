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

namespace eBiser.WinUi.AkcijePomoci
{
    public partial class frmAkcijePomoci : Form
    {
        private readonly APIService _apiService = new APIService("akcijepomoci");


        public frmAkcijePomoci()
        {
            InitializeComponent();
        }

        private async void frmAkcijePomoci_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Data.AkcijePomoci>>(null);
            dgvAkcijePomoci.DataSource = result;
        }

        private void dgvAkcijePomoci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAkcijePomociUpsert frmAkcijePomoci = new frmAkcijePomociUpsert(Int32.Parse(dgvAkcijePomoci.SelectedRows[0].Cells[0].Value.ToString()));
            frmAkcijePomoci.Show();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            AkcijePomociSearchRequest search = new AkcijePomociSearchRequest
            {
                Aktivno = chBoxAktivno.Checked,
                Ime= txtIme.Text,
                Prezime=txtPrezime.Text
            };
            var result= await _apiService.Get<List<Data.AkcijePomoci>>(search);
            dgvAkcijePomoci.DataSource = result;
            dgvAkcijePomoci.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAkcijePomociUpsert frmAkcijePomociUpsert = new frmAkcijePomociUpsert();
            frmAkcijePomociUpsert.Show();
        }
    }
}
