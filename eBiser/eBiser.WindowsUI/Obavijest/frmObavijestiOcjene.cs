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
        public frmObavijestiOcjene(int? ObavijestId=null)
        {
            _obavijestId = ObavijestId;
            InitializeComponent();
        }

        private readonly APIService _apiServiceObavijest = new APIService("Obavijest");
        private readonly APIService _apiServiceObavijestOcjena = new APIService("ObavijestOcjena");
        private int? _obavijestId = null;
        private async Task LoadOcjene(int ObavijestId)
        {
            var data = await _apiServiceObavijestOcjena.Get<List<Data.ObavijestOcjena>>(new ObavijestOcjenaSearchRequest()
            {
                ObavijestId = ObavijestId
            });
            dgvOcjene.AutoGenerateColumns = false;
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
            if (_obavijestId.HasValue)
            {
                cBoxClan.SelectedValue = _obavijestId;
            }
        }

        private async void cBoxClan_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = cBoxClan.SelectedValue;

            if (int.TryParse(selectedValue.ToString(), out int ObavijestId))
            {
                await LoadOcjene(ObavijestId);
            }
        }
    }
}
