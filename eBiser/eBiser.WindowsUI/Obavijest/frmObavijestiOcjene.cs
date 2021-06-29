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

namespace eBiser.WindowsUI.Obavijest
{
    public partial class frmObavijestiOcjene : Form
    {
        public frmObavijestiOcjene()
        {
            InitializeComponent();
        }
        private readonly APIService _apiServiceObavijest = new APIService("Obavijest");
        private readonly APIService _apiServiceObavijestOcjena = new APIService("ObavijestOcjena");

        private async Task LoadClanarine(int ObavijestId)
        {
            var data = await _apiServiceObavijestOcjena.Get<List<Data.ObavijestOcjena>>(new ObavijestOcjenaSearchRequest()
            {
                ObavijestId = ObavijestId
            });
            //dgvOcjene.AutoGenerateColumns = false;
            dgvOcjene.DataSource = data;
            dgvOcjene.ClearSelection();
            dgvOcjene.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private async void frmObavijestiOcjene_Load(object sender, EventArgs e)
        {
            var items = await _apiServiceObavijest.Get<List<Data.Obavijest>>(null);
            cBoxClan.DataSource = items;
            cBoxClan.DisplayMember = "Naslov";
            cBoxClan.ValueMember = "Id";
        }

        private async void cBoxClan_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = cBoxClan.SelectedValue;

            if (int.TryParse(selectedValue.ToString(), out int ObavijestId))
            {
                await LoadClanarine(ObavijestId);
            }
        }
    }
}
