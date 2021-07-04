﻿using System;
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
    public partial class frmProjekti : Form
    {
        private readonly APIService _aPIService = new APIService("Projekti");

        public frmProjekti()
        {
            InitializeComponent();
        }
        private async Task LoadDGV()
        {
            //dgvProjekti.AutoGenerateColumns = false;
            var result = await _aPIService.Get<List<Data.Projekti>>(null);
            dgvProjekti.DataSource = result;
            dgvProjekti.ClearSelection();
            dgvProjekti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private async void frmProjekti_Load(object sender, EventArgs e)
        {
            await LoadDGV();
        }

        private void dgvProjekti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = Int32.Parse(dgvProjekti.SelectedRows[0].Cells[0].Value.ToString());
                frmProjektiUpsert frmOsobljeUpsert = new frmProjektiUpsert(id);
                frmOsobljeUpsert.Show();
                this.Close();
            }
            catch (Exception)
            {

            }


        }
    }
}
