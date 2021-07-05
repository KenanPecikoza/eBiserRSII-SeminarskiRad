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

namespace eBiser.WindowsUI.Projekti
{
    public partial class frmProjektiUpsert : Form
    {
        private int? _id = null;
        private readonly APIService _APIService = new APIService("Projekti");
        private readonly APIService _APIServiceOsoblje = new APIService("Korisnik/Osoblje");

        public frmProjektiUpsert(int? id=null)
        {
            _id = id;

            InitializeComponent();
        }
        private async Task LoadForm(int id)
        {
            var result = await _APIService.GetById<Data.Projekti>(id);
            txtNazivProjekta.Text = result.NazivProjekta;
            txtRokIzvršenja.Text = result.RokIzvrsenja;
            dtmIzvrsenja.Value = result.DatumIzvrsenja;
            dtmPrijave.Value = result.DatumPrijave;
            numCijena.Value =(decimal)result.CijenaProjekta;
            numOdobrenaSredstva.Value =(decimal)result.OdobrenaSredstva;
            checkBox1.Checked = result.Prihvaćen;
            cBoxKreatori.SelectedValue = result.OsobljeId;
        }
        private async Task LoadDGV()
        {
            dgvProjekti.AutoGenerateColumns = false;
            var result = await _APIService.Get<List<Data.Projekti>>(null);
            dgvProjekti.DataSource = result;
            dgvProjekti.ClearSelection();
            dgvProjekti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
        }
        private async Task LoadComboBox() 
        {
            var result = await _APIServiceOsoblje.Get<List<Data.OsobljeDTO>>(null);
            cBoxKreatori.DataSource = result;
            cBoxKreatori.DisplayMember = "ImeIPrezime";
            cBoxKreatori.ValueMember = "Id";

        }




        private async void dgvProjekti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = Int32.Parse(dgvProjekti.SelectedRows[0].Cells[0].Value.ToString());
                _id = id;
                await LoadForm(_id ?? 0);
            }
            catch (Exception)
            {

            }
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            txtNazivProjekta.Text = "";
            txtRokIzvršenja.Text = "";
            dtmIzvrsenja.Value = DateTime.Now.Date;
            dtmPrijave.Value = DateTime.Now.Date;
            numCijena.Value = 0;
            numOdobrenaSredstva.Value = 0;
            checkBox1.Checked = false;
            _id = null;
            cBoxKreatori.SelectedIndex = 0;
        }

        private async void frmProjektiUpsert_Load(object sender, EventArgs e)
        {
            await LoadDGV();
            await LoadComboBox();
        }
        ProjektiUpsertRequest upsertRequest = new ProjektiUpsertRequest();

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            upsertRequest.CijenaProjekta = (double)numCijena.Value;
            upsertRequest.OdobrenaSredstva = (double)numOdobrenaSredstva.Value;
            upsertRequest.NazivProjekta = txtNazivProjekta.Text;
            upsertRequest.OsobljeId = Int32.Parse(cBoxKreatori.SelectedValue.ToString());
            upsertRequest.Prihvaćen = checkBox1.Checked;
            upsertRequest.RokIzvrsenja = txtRokIzvršenja.Text;
            upsertRequest.DatumIzvrsenja = dtmIzvrsenja.Value.Date;
            upsertRequest.DatumPrijave = dtmPrijave.Value.Date;
            if (_id.HasValue)
            {
                await _APIService.Update<Data.Projekti>(_id??0,upsertRequest);
                MessageBox.Show("Uspjesno uređeni podaci o projektu");
            }
            else
            {
                await _APIService.Insert<Data.Projekti>(upsertRequest);
                MessageBox.Show("Uspjesno dodani podaci o projektu");
            }

                await LoadDGV();
        }

        private void txtNazivProjekta_Validating(object sender, CancelEventArgs e)
        {
            if (txtNazivProjekta.Text.ToString().Length < 2)
            {
                errorProvider.SetError(txtNazivProjekta, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNazivProjekta, null);
            }
        }

        private void numCijena_Validating(object sender, CancelEventArgs e)
        {
            if (numCijena.Value<=0)
            {
                errorProvider.SetError(numCijena, Properties.Resources.ValidationRequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(numCijena, null);
            }
        }
    }
}
