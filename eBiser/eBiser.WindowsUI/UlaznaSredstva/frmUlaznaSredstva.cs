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

namespace eBiser.WindowsUI.UlaznaSredstva
{
    public partial class frmUlaznaSredstva : Form
    {
        private readonly APIService _apiService = new APIService("UlaznaSredstva");

        public frmUlaznaSredstva()
        {
            InitializeComponent();
        }

        private async void frmUlaznaSredstva_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Data.UlaznaSredstva>>(null);
            dgvUlaznaSredstva.DataSource = result;
            dgvUlaznaSredstva.AutoGenerateColumns = false;
            dgvUlaznaSredstva.AutoSize = true;
            dgvUlaznaSredstva.ClearSelection();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        UlaznaSredstvaSearchRequest search = new UlaznaSredstvaSearchRequest();

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            search.Godina = (int)numGodina.Value;
            search.Mjesec = (int)numMjesec.Value;
            search.Naziv = txtNaslov.Text;
            search.Opis = txtOpis.Text;
            var result = await _apiService.Get<List<Data.UlaznaSredstva>>(search);
            dgvUlaznaSredstva.DataSource = result;
            dgvUlaznaSredstva.ClearSelection();
        }

        private void dgvUlaznaSredstva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var _id = Int32.Parse(dgvUlaznaSredstva.SelectedRows[0].Cells[0].Value.ToString());
                frmUlaznaSredstvaUpsert frmUlazna = new frmUlaznaSredstvaUpsert(_id);
                frmUlazna.Show();
            }
            catch (Exception)
            {

            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmUlaznaSredstvaUpsert frmUlazna = new frmUlaznaSredstvaUpsert();
            frmUlazna.Show();
            this.Close();
        }

        private void btnIzadji_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
