using eBiser.Data.Requests;
using eBiser.WindowsUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBiser.WindowsUI.Clanarine
{
    public partial class frmClanarineUpsert : Form
    {
        private readonly APIService _apiServiceClanarina = new APIService("clanarina");
        private readonly APIService _apiServiceClan = new APIService("korisnik/clan");
        private int? _id = null;
        private readonly PhotoHelper photoHelper = new PhotoHelper();
        public frmClanarineUpsert(int? id=null)
        {
            _id = id;
            InitializeComponent();
        }
        private async Task LoadClanarine(int ClanId)
        {
            var data = await _apiServiceClanarina.Get<List<Data.Clanarina>>(new ClanarinaSearchRequest()
            {
                ClanId = ClanId
            });
            dgvClanarine1.AutoGenerateColumns = false;
            dgvClanarine1.DataSource = data;
            dgvClanarine1.ClearSelection();
            dgvClanarine1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private async Task LoadForma(int id)
        {
            var clanarine = await _apiServiceClanarina.GetById<Data.Clanarina>(_id);

            dtmDatumUplate.Value = clanarine.DatumUplate;
            numGodina.Value = clanarine.Godina;
            numMjesec.Value = clanarine.Mjesec;
            numIznosUplate.Value = (decimal)clanarine.Iznos;
            cBoxClan.SelectedValue = clanarine.ClanId;
        }


        private async void frmClanarineUpsert_Load(object sender, EventArgs e)
        {
            var items = await _apiServiceClan.Get<List<Data.ClanDTO>>("");
            cBoxClan.DataSource = items;
            if (_id.HasValue)
            {
                await LoadForma(_id??0);
            }
            cBoxClan.DisplayMember = "ImeIPrezime";
            cBoxClan.ValueMember = "Id";// u prorertis postaviti 
        }
           ClanarinaUpsertRequest request = new ClanarinaUpsertRequest();
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            request.ClanId = Int32.Parse(cBoxClan.SelectedValue.ToString());
            request.DatumUplate = dtmDatumUplate.Value;
            request.Godina = int.Parse(numGodina.Value.ToString());
            request.Mjesec = int.Parse(numMjesec.Value.ToString());
            request.Iznos = Double.Parse(numIznosUplate.Value.ToString());

            if (_id.HasValue)
            {
                await _apiServiceClanarina.Update<ClanarinaUpsertRequest>(_id??0,request);
            }
            else
            {
                await _apiServiceClanarina.Insert<ClanarinaUpsertRequest>(request);
            }
            await LoadClanarine(Int32.Parse(cBoxClan.SelectedValue.ToString()));
        }

        private async void cBoxClan_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = cBoxClan.SelectedValue;

            if (int.TryParse(selectedValue.ToString(), out int ClanId))
            {
                await LoadClanarine(ClanId);
            }
        }
        private async void dgvClanarine1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _id = Int32.Parse(dgvClanarine1.SelectedRows[0].Cells[0].Value.ToString());
                await LoadForma(_id ?? 0);//bug zbog podataka 

            }
            catch (Exception)
            {

            }
        }
        private void btnPonisti_Click(object sender, EventArgs e)
        {
            _id = null;
            numGodina.Value = 2021;
            numMjesec.Value =1;
            numIznosUplate.Value = 1;
            dgvClanarine1.ClearSelection();
        }


    }
}
