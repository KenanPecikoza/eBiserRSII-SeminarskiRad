
namespace eBiser.WindowsUI.IzlaznaSerdstva
{
    partial class frmIzlaznaSredstva
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numGodina = new System.Windows.Forms.NumericUpDown();
            this.numMjesec = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.Naslov = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvIzlaznaSredstva = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaslovSredstva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGodina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMjesec)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzlaznaSredstva)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPretrazi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numGodina);
            this.groupBox2.Controls.Add(this.numMjesec);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtOpis);
            this.groupBox2.Controls.Add(this.txtNaslov);
            this.groupBox2.Controls.Add(this.Naslov);
            this.groupBox2.Location = new System.Drawing.Point(12, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(640, 101);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Blue;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.Color.White;
            this.btnPretrazi.Location = new System.Drawing.Point(538, 42);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(86, 41);
            this.btnPretrazi.TabIndex = 8;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Godina";
            // 
            // numGodina
            // 
            this.numGodina.Location = new System.Drawing.Point(453, 50);
            this.numGodina.Maximum = new decimal(new int[] {
            3500,
            0,
            0,
            0});
            this.numGodina.Name = "numGodina";
            this.numGodina.Size = new System.Drawing.Size(68, 26);
            this.numGodina.TabIndex = 0;
            // 
            // numMjesec
            // 
            this.numMjesec.Location = new System.Drawing.Point(386, 50);
            this.numMjesec.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMjesec.Name = "numMjesec";
            this.numMjesec.Size = new System.Drawing.Size(58, 26);
            this.numMjesec.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mjesec";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(200, 49);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(166, 26);
            this.txtOpis.TabIndex = 2;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(8, 49);
            this.txtNaslov.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(166, 26);
            this.txtNaslov.TabIndex = 1;
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Location = new System.Drawing.Point(4, 24);
            this.Naslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(56, 20);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "Naslov";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIzlaznaSredstva);
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 545);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izlazna sredstva";
            // 
            // dgvIzlaznaSredstva
            // 
            this.dgvIzlaznaSredstva.AllowUserToAddRows = false;
            this.dgvIzlaznaSredstva.AllowUserToDeleteRows = false;
            this.dgvIzlaznaSredstva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvIzlaznaSredstva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzlaznaSredstva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NaslovSredstva,
            this.Količina,
            this.Datum,
            this.Opis});
            this.dgvIzlaznaSredstva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIzlaznaSredstva.Location = new System.Drawing.Point(3, 22);
            this.dgvIzlaznaSredstva.Name = "dgvIzlaznaSredstva";
            this.dgvIzlaznaSredstva.ReadOnly = true;
            this.dgvIzlaznaSredstva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzlaznaSredstva.Size = new System.Drawing.Size(634, 520);
            this.dgvIzlaznaSredstva.TabIndex = 0;
            this.dgvIzlaznaSredstva.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIzlaznaSredstva_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // NaslovSredstva
            // 
            this.NaslovSredstva.DataPropertyName = "Naslov";
            this.NaslovSredstva.HeaderText = "Naslov";
            this.NaslovSredstva.Name = "NaslovSredstva";
            this.NaslovSredstva.ReadOnly = true;
            this.NaslovSredstva.Width = 81;
            // 
            // Količina
            // 
            this.Količina.DataPropertyName = "Količina";
            this.Količina.HeaderText = "Iznos";
            this.Količina.Name = "Količina";
            this.Količina.ReadOnly = true;
            this.Količina.Width = 73;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 82;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 66;
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.Red;
            this.btnIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.ForeColor = System.Drawing.Color.White;
            this.btnIzadji.Location = new System.Drawing.Point(15, 673);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(86, 41);
            this.btnIzadji.TabIndex = 8;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click_1);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Green;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(566, 673);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(86, 41);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmIzlaznaSredstva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 718);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmIzlaznaSredstva";
            this.Text = "Izlazna sredstva pretraga";
            this.Load += new System.EventHandler(this.frmIzlaznaSredstva_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGodina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMjesec)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzlaznaSredstva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numGodina;
        private System.Windows.Forms.NumericUpDown numMjesec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIzlaznaSredstva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaslovSredstva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnDodaj;
    }
}