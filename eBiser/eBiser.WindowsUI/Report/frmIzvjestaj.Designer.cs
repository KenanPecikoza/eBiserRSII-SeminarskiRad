
namespace eBiser.WindowsUI.Report
{
    partial class frmIzvjestaj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.IzlaznaSredstva = new eBiser.WindowsUI.Report.IzlaznaSredstva();
            this.IzlaznaSredstvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UlaznaSredstva = new eBiser.WindowsUI.Report.UlaznaSredstva();
            this.UlaznaSredstvaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IzlaznaSredstva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzlaznaSredstvaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UlaznaSredstva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UlaznaSredstvaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "IzlaznaSredstva";
            reportDataSource1.Value = this.IzlaznaSredstvaBindingSource;
            reportDataSource2.Name = "UlaznaSredstva";
            reportDataSource2.Value = this.UlaznaSredstvaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eBiser.WindowsUI.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(53, 102);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(703, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // IzlaznaSredstva
            // 
            this.IzlaznaSredstva.DataSetName = "IzlaznaSredstva";
            this.IzlaznaSredstva.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IzlaznaSredstvaBindingSource
            // 
            this.IzlaznaSredstvaBindingSource.DataMember = "IzlaznaSredstva";
            this.IzlaznaSredstvaBindingSource.DataSource = this.IzlaznaSredstva;
            // 
            // UlaznaSredstva
            // 
            this.UlaznaSredstva.DataSetName = "UlaznaSredstva";
            this.UlaznaSredstva.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UlaznaSredstvaBindingSource
            // 
            this.UlaznaSredstvaBindingSource.DataMember = "UlaznaSredstva";
            this.UlaznaSredstvaBindingSource.DataSource = this.UlaznaSredstva;
            // 
            // frmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmIzvjestaj";
            this.Text = "frmIzvjestaj";
            this.Load += new System.EventHandler(this.frmIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IzlaznaSredstva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzlaznaSredstvaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UlaznaSredstva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UlaznaSredstvaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IzlaznaSredstvaBindingSource;
        private IzlaznaSredstva IzlaznaSredstva;
        private System.Windows.Forms.BindingSource UlaznaSredstvaBindingSource;
        private UlaznaSredstva UlaznaSredstva;
    }
}