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

namespace eBiser.WindowsUI.IzlaznaSerdstva
{
    public partial class frmIzlaznaSredstva : Form
    {
        private readonly APIService _apiService = new APIService("IzlaznaSredstva");
        public frmIzlaznaSredstva()
        {
            InitializeComponent();
        }


        private async void frmIzlaznaSredstva_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Data.IzlaznaSredstva>>(null);
            dgvIzlaznaSredstva.DataSource = result;
            dgvIzlaznaSredstva.AutoGenerateColumns = false;
            dgvIzlaznaSredstva.AutoSize = true;
            dgvIzlaznaSredstva.ClearSelection();
            dgvIzlaznaSredstva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        IzlaznaSredstvaSearchRequest search = new IzlaznaSredstvaSearchRequest();
        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            search.Godina = (int) numGodina.Value;
            search.Mjesec =(int) numMjesec.Value;
            search.Naziv = txtNaslov.Text;
            search.Opis = txtOpis.Text;
            var result = await _apiService.Get<List<Data.IzlaznaSredstva>>(search);
            dgvIzlaznaSredstva.DataSource = result;
            dgvIzlaznaSredstva.ClearSelection();
        }

        private void dgvIzlaznaSredstva_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var _id = Int32.Parse(dgvIzlaznaSredstva.SelectedRows[0].Cells[0].Value.ToString());
                frmIzlaznaSredstvaUpsert frmIzlazna = new frmIzlaznaSredstvaUpsert(_id);
                frmIzlazna.Show();
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmIzlaznaSredstvaUpsert frmIzlazna = new frmIzlaznaSredstvaUpsert();
            frmIzlazna.Show();
            this.Close();

        }

        private void btnIzadji_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
