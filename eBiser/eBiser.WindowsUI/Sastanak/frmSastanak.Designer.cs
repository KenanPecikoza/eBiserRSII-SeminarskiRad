
namespace eBiser.WindowsUI.Sastanak
{
    partial class frmSastanak
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSastanci = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numGodina = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numMjesec = new System.Windows.Forms.NumericUpDown();
            this.Mjesec = new System.Windows.Forms.Label();
            this.numDan = new System.Windows.Forms.NumericUpDown();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOdrzavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeIPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odrzan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Zapisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastanci)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGodina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMjesec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSastanci);
            this.groupBox1.Location = new System.Drawing.Point(13, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(479, 458);
            this.groupBox1.TabIndex = 0;
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
            this.dgvSastanci.Size = new System.Drawing.Size(471, 429);
            this.dgvSastanci.TabIndex = 0;
            this.dgvSastanci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSastanci_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numGodina);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numMjesec);
            this.groupBox2.Controls.Add(this.Mjesec);
            this.groupBox2.Controls.Add(this.numDan);
            this.groupBox2.Controls.Add(this.btnPretraga);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // numGodina
            // 
            this.numGodina.Location = new System.Drawing.Point(135, 45);
            this.numGodina.Maximum = new decimal(new int[] {
            3500,
            0,
            0,
            0});
            this.numGodina.Name = "numGodina";
            this.numGodina.Size = new System.Drawing.Size(65, 26);
            this.numGodina.TabIndex = 7;
            this.numGodina.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Godina";
            // 
            // numMjesec
            // 
            this.numMjesec.Location = new System.Drawing.Point(70, 45);
            this.numMjesec.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMjesec.Name = "numMjesec";
            this.numMjesec.Size = new System.Drawing.Size(46, 26);
            this.numMjesec.TabIndex = 5;
            // 
            // Mjesec
            // 
            this.Mjesec.AutoSize = true;
            this.Mjesec.Location = new System.Drawing.Point(66, 22);
            this.Mjesec.Name = "Mjesec";
            this.Mjesec.Size = new System.Drawing.Size(59, 20);
            this.Mjesec.TabIndex = 4;
            this.Mjesec.Text = "Mjesec";
            // 
            // numDan
            // 
            this.numDan.Location = new System.Drawing.Point(10, 45);
            this.numDan.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDan.Name = "numDan";
            this.numDan.Size = new System.Drawing.Size(46, 26);
            this.numDan.TabIndex = 3;
            // 
            // btnPretraga
            // 
            this.btnPretraga.BackColor = System.Drawing.Color.Blue;
            this.btnPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraga.ForeColor = System.Drawing.Color.White;
            this.btnPretraga.Location = new System.Drawing.Point(387, 37);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(86, 41);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = false;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dan";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Green;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(406, 568);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(86, 41);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(17, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Izađi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.ImeIPrezime.HeaderText = "Ime i prezime zapisnicara";
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
            // frmSastanak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSastanak";
            this.Text = "SastanakForm";
            this.Load += new System.EventHandler(this.frmSastanak_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastanci)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGodina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMjesec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvSastanci;
        private System.Windows.Forms.NumericUpDown numGodina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMjesec;
        private System.Windows.Forms.Label Mjesec;
        private System.Windows.Forms.NumericUpDown numDan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOdrzavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeIPrezime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odrzan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zapisnik;
    }
}