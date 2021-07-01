using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBiser.WindowsUI.Report
{
    public partial class frmIzvjestaj : Form
    {
        public frmIzvjestaj()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=localhost,1401;Initial Catalog=eBiser;Persist Security Info=True;User ID=sa;Password=QWElkj132!");
        private void Izvjestaj(string godina)
        {
            SqlCommand commandIzlazna = new SqlCommand($"Select * from IzlaznaSredstva WHERE YEAR([Datum])={godina}", connection);
            SqlCommand commandUlazna = new SqlCommand($"Select * from UlaznaSredstva WHERE YEAR([Datum])={godina}", connection);
            SqlDataAdapter dI = new SqlDataAdapter(commandIzlazna);
            SqlDataAdapter dU = new SqlDataAdapter(commandUlazna);
            DataTable dtU = new DataTable();
            DataTable dtI = new DataTable();
            dU.Fill(dtU);
            dI.Fill(dtI);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.ReportPath = @"C:\Users\Kenan\Desktop\eBiserRSII-SeminarskiRad\eBiser\eBiser.WindowsUI\Report\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("IzlaznaSredstva", dtI));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("UlaznaSredstva", dtU));
            reportViewer1.RefreshReport();



            this.reportViewer1.RefreshReport();
        }




        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            Izvjestaj(DateTime.Now.Year.ToString());
        }

        private void btnOsvježi_Click(object sender, EventArgs e)
        {
            Izvjestaj(numericUpDown1.Value.ToString());
        }
    }
}
