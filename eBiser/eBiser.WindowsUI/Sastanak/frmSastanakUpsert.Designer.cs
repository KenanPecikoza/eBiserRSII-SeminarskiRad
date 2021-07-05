
namespace eBiser.WindowsUI.Sastanak
{
    partial class frmSastanakUpsert
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSastanci = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZapisnik = new System.Windows.Forms.TextBox();
            this.cBoxZapisnicar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmDatumOdzavanja = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOdrzavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeIPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odrzan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Zapisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastanci)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSastanci);
            this.groupBox1.Location = new System.Drawing.Point(13, 421);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(813, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sastanci";
            // 
            // dgvSastanci
            // 
            this.dgvSastanci.AllowUserToAddRows = false;
            this.dgvSastanci.AllowUserToDeleteRows = false;
            this.dgvSastanci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSastanci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSastanci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naslov,
            this.DatumOdrzavanja,
            this.ImeIPrezime,
            this.Odrzan,
            this.Zapisnik});
            this.dgvSastanci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSastanci.Location = new System.Drawing.Point(4, 24);
            this.dgvSastanci.Name = "dgvSastanci";
            this.dgvSastanci.ReadOnly = true;
            this.dgvSastanci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSastanci.Size = new System.Drawing.Size(805, 297);
            this.dgvSastanci.TabIndex = 0;
            this.dgvSastanci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSastanci_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNaslov);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnPonisti);
            this.groupBox2.Controls.Add(this.btnSnimi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtZapisnik);
            this.groupBox2.Controls.Add(this.cBoxZapisnicar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtmDatumOdzavanja);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(17, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 401);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnPonisti
            // 
            this.btnPonisti.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPonisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonisti.ForeColor = System.Drawing.Color.White;
            this.btnPonisti.Location = new System.Drawing.Point(6, 355);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(86, 41);
            this.btnPonisti.TabIndex = 10;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = false;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.Green;
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(717, 354);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(86, 41);
            this.btnSnimi.TabIndex = 9;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zapisnik";
            // 
            // txtZapisnik
            // 
            this.txtZapisnik.Location = new System.Drawing.Point(8, 200);
            this.txtZapisnik.Multiline = true;
            this.txtZapisnik.Name = "txtZapisnik";
            this.txtZapisnik.Size = new System.Drawing.Size(797, 149);
            this.txtZapisnik.TabIndex = 7;
            this.txtZapisnik.Validating += new System.ComponentModel.CancelEventHandler(this.txtZapisnik_Validating);
            // 
            // cBoxZapisnicar
            // 
            this.cBoxZapisnicar.DisplayMember = "Id";
            this.cBoxZapisnicar.FormattingEnabled = true;
            this.cBoxZapisnicar.Location = new System.Drawing.Point(10, 146);
            this.cBoxZapisnicar.Name = "cBoxZapisnicar";
            this.cBoxZapisnicar.Size = new System.Drawing.Size(284, 28);
            this.cBoxZapisnicar.TabIndex = 6;
            this.cBoxZapisnicar.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zapisnicar";
            // 
            // dtmDatumOdzavanja
            // 
            this.dtmDatumOdzavanja.Location = new System.Drawing.Point(10, 94);
            this.dtmDatumOdzavanja.Name = "dtmDatumOdzavanja";
            this.dtmDatumOdzavanja.Size = new System.Drawing.Size(284, 26);
            this.dtmDatumOdzavanja.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum održavanja";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(10, 42);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(284, 26);
            this.txtNaslov.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Naslov ";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 48;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            this.Naslov.Width = 81;
            // 
            // DatumOdrzavanja
            // 
            this.DatumOdrzavanja.DataPropertyName = "DatumOdrzavanja";
            this.DatumOdrzavanja.HeaderText = "Datum održavanja";
            this.DatumOdrzavanja.Name = "DatumOdrzavanja";
            this.DatumOdrzavanja.ReadOnly = true;
            this.DatumOdrzavanja.Width = 149;
            // 
            // ImeIPrezime
            // 
            this.ImeIPrezime.DataPropertyName = "ImeIPrezime";
            this.ImeIPrezime.HeaderText = "Ime i prezime zapisničara";
            this.ImeIPrezime.Name = "ImeIPrezime";
            this.ImeIPrezime.ReadOnly = true;
            this.ImeIPrezime.Width = 193;
            // 
            // Odrzan
            // 
            this.Odrzan.DataPropertyName = "Odrzan";
            this.Odrzan.HeaderText = "Održan";
            this.Odrzan.Name = "Odrzan";
            this.Odrzan.ReadOnly = true;
            this.Odrzan.Width = 67;
            // 
            // Zapisnik
            // 
            this.Zapisnik.DataPropertyName = "Zapisnik";
            this.Zapisnik.HeaderText = "Zapisnik";
            this.Zapisnik.Name = "Zapisnik";
            this.Zapisnik.ReadOnly = true;
            this.Zapisnik.Width = 93;
            // 
            // frmSastanakUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 775);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSastanakUpsert";
            this.Text = "frmSastanakUpsert";
            this.Load += new System.EventHandler(this.frmSastanakUpsert_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastanci)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSastanci;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZapisnik;
        private System.Windows.Forms.ComboBox cBoxZapisnicar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmDatumOdzavanja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOdrzavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeIPrezime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odrzan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zapisnik;
    }
}