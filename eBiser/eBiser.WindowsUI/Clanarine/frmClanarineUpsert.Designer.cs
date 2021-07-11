
namespace eBiser.WindowsUI.Clanarine
{
    partial class frmClanarineUpsert
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
            this.cBoxClan = new System.Windows.Forms.ComboBox();
            this.Clan = new System.Windows.Forms.Label();
            this.datumUplate = new System.Windows.Forms.Label();
            this.dtmDatumUplate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.numIznosUplate = new System.Windows.Forms.NumericUpDown();
            this.Uplate = new System.Windows.Forms.GroupBox();
            this.dgvClanarine1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mjesec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMjesec = new System.Windows.Forms.NumericUpDown();
            this.numGodina = new System.Windows.Forms.NumericUpDown();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numIznosUplate)).BeginInit();
            this.Uplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMjesec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGodina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxClan
            // 
            this.cBoxClan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cBoxClan.DisplayMember = "ClanId";
            this.cBoxClan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxClan.FormattingEnabled = true;
            this.cBoxClan.Location = new System.Drawing.Point(10, 36);
            this.cBoxClan.Name = "cBoxClan";
            this.cBoxClan.Size = new System.Drawing.Size(285, 28);
            this.cBoxClan.TabIndex = 0;
            this.cBoxClan.ValueMember = "Id";
            this.cBoxClan.SelectedIndexChanged += new System.EventHandler(this.cBoxClan_SelectedIndexChanged);
            // 
            // Clan
            // 
            this.Clan.AutoSize = true;
            this.Clan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clan.Location = new System.Drawing.Point(6, 13);
            this.Clan.Name = "Clan";
            this.Clan.Size = new System.Drawing.Size(41, 20);
            this.Clan.TabIndex = 1;
            this.Clan.Text = "Clan";
            // 
            // datumUplate
            // 
            this.datumUplate.AutoSize = true;
            this.datumUplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumUplate.Location = new System.Drawing.Point(309, 13);
            this.datumUplate.Name = "datumUplate";
            this.datumUplate.Size = new System.Drawing.Size(105, 20);
            this.datumUplate.TabIndex = 2;
            this.datumUplate.Text = "Datum uplate";
            // 
            // dtmDatumUplate
            // 
            this.dtmDatumUplate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDatumUplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDatumUplate.Location = new System.Drawing.Point(313, 36);
            this.dtmDatumUplate.Name = "dtmDatumUplate";
            this.dtmDatumUplate.Size = new System.Drawing.Size(285, 26);
            this.dtmDatumUplate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iznos (KM)";
            // 
            // numIznosUplate
            // 
            this.numIznosUplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIznosUplate.Location = new System.Drawing.Point(10, 90);
            this.numIznosUplate.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numIznosUplate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIznosUplate.Name = "numIznosUplate";
            this.numIznosUplate.Size = new System.Drawing.Size(81, 26);
            this.numIznosUplate.TabIndex = 5;
            this.numIznosUplate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Uplate
            // 
            this.Uplate.Controls.Add(this.dgvClanarine1);
            this.Uplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uplate.Location = new System.Drawing.Point(18, 196);
            this.Uplate.Name = "Uplate";
            this.Uplate.Size = new System.Drawing.Size(651, 295);
            this.Uplate.TabIndex = 6;
            this.Uplate.TabStop = false;
            this.Uplate.Text = "Uplate";
            // 
            // dgvClanarine1
            // 
            this.dgvClanarine1.AllowUserToAddRows = false;
            this.dgvClanarine1.AllowUserToDeleteRows = false;
            this.dgvClanarine1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanarine1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.Godina,
            this.Mjesec,
            this.dataGridViewTextBoxColumn1,
            this.Iznos});
            this.dgvClanarine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClanarine1.Location = new System.Drawing.Point(3, 22);
            this.dgvClanarine1.MultiSelect = false;
            this.dgvClanarine1.Name = "dgvClanarine1";
            this.dgvClanarine1.ReadOnly = true;
            this.dgvClanarine1.RowHeadersWidth = 10;
            this.dgvClanarine1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClanarine1.Size = new System.Drawing.Size(645, 270);
            this.dgvClanarine1.TabIndex = 1;
            this.dgvClanarine1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClanarine1_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 61;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Godina
            // 
            this.Godina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Godina.DataPropertyName = "Godina";
            this.Godina.HeaderText = "Godina";
            this.Godina.Name = "Godina";
            this.Godina.ReadOnly = true;
            this.Godina.Width = 86;
            // 
            // Mjesec
            // 
            this.Mjesec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mjesec.DataPropertyName = "Mjesec";
            this.Mjesec.HeaderText = "Mjesec";
            this.Mjesec.Name = "Mjesec";
            this.Mjesec.ReadOnly = true;
            this.Mjesec.Width = 84;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DatumUplate";
            this.dataGridViewTextBoxColumn1.HeaderText = "Datum uplate";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // Iznos
            // 
            this.Iznos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            this.Iznos.Width = 73;
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.Green;
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(562, 122);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(86, 41);
            this.btnSnimi.TabIndex = 7;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mjesec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Godina";
            // 
            // numMjesec
            // 
            this.numMjesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMjesec.Location = new System.Drawing.Point(101, 90);
            this.numMjesec.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMjesec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMjesec.Name = "numMjesec";
            this.numMjesec.Size = new System.Drawing.Size(55, 26);
            this.numMjesec.TabIndex = 10;
            this.numMjesec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numGodina
            // 
            this.numGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGodina.Location = new System.Drawing.Point(166, 90);
            this.numGodina.Maximum = new decimal(new int[] {
            3500,
            0,
            0,
            0});
            this.numGodina.Minimum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numGodina.Name = "numGodina";
            this.numGodina.Size = new System.Drawing.Size(65, 26);
            this.numGodina.TabIndex = 11;
            this.numGodina.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // btnPonisti
            // 
            this.btnPonisti.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPonisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonisti.ForeColor = System.Drawing.Color.White;
            this.btnPonisti.Location = new System.Drawing.Point(6, 122);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(86, 41);
            this.btnPonisti.TabIndex = 12;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = false;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Clan);
            this.groupBox1.Controls.Add(this.btnSnimi);
            this.groupBox1.Controls.Add(this.btnPonisti);
            this.groupBox1.Controls.Add(this.cBoxClan);
            this.groupBox1.Controls.Add(this.numGodina);
            this.groupBox1.Controls.Add(this.datumUplate);
            this.groupBox1.Controls.Add(this.numMjesec);
            this.groupBox1.Controls.Add(this.dtmDatumUplate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numIznosUplate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 178);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // frmClanarineUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Uplate);
            this.Name = "frmClanarineUpsert";
            this.Text = "Članarine";
            this.Load += new System.EventHandler(this.frmClanarineUpsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numIznosUplate)).EndInit();
            this.Uplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMjesec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGodina)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxClan;
        private System.Windows.Forms.Label Clan;
        private System.Windows.Forms.Label datumUplate;
        private System.Windows.Forms.DateTimePicker dtmDatumUplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numIznosUplate;
        private System.Windows.Forms.GroupBox Uplate;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.DataGridView dgvClanarine1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMjesec;
        private System.Windows.Forms.NumericUpDown numGodina;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mjesec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
    }
}