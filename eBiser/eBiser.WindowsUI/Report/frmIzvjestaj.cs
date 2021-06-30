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
        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from IzlaznaSredstva", connection);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dtU = new DataTable();
            DataTable dtI = new DataTable();
            d.Fill(dtU);
            d.Fill(dtI);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.ReportPath = @"C:\Users\Kenan\Desktop\eBiserRSII-SeminarskiRad\eBiser\eBiser.WindowsUI\Report\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("IzlaznaSredstva", dtI));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("UlaznaSredstva", dtU));
            reportViewer1.RefreshReport();



            this.reportViewer1.RefreshReport();
        }
    }
}
