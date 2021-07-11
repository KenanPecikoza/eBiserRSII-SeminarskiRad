
namespace eBiser.WindowsUI.Osoblje
{
    partial class frmOsoblje
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
            this.cBoxNazivDjelatnosti = new System.Windows.Forms.ComboBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOsoblje = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivDjelatnosti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPočetkaAngazmana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsoblje)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxNazivDjelatnosti);
            this.groupBox1.Controls.Add(this.btnPretrazi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // cBoxNazivDjelatnosti
            // 
            this.cBoxNazivDjelatnosti.DisplayMember = "Id";
            this.cBoxNazivDjelatnosti.FormattingEnabled = true;
            this.cBoxNazivDjelatnosti.Location = new System.Drawing.Point(10, 80);
            this.cBoxNazivDjelatnosti.Name = "cBoxNazivDjelatnosti";
            this.cBoxNazivDjelatnosti.Size = new System.Drawing.Size(367, 28);
            this.cBoxNazivDjelatnosti.TabIndex = 10;
            this.cBoxNazivDjelatnosti.ValueMember = "Id";
            this.cBoxNazivDjelatnosti.SelectedIndexChanged += new System.EventHandler(this.cBoxNazivDjelatnosti_SelectedIndexChanged);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Blue;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.Color.White;
            this.btnPretrazi.Location = new System.Drawing.Point(399, 74);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(86, 41);
            this.btnPretrazi.TabIndex = 7;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Naziv djelatnosti";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(301, 28);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(184, 26);
            this.txtPrezime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(48, 28);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(175, 26);
            this.txtIme.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOsoblje);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 366);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Osoblje";
            // 
            // dgvOsoblje
            // 
            this.dgvOsoblje.AllowUserToAddRows = false;
            this.dgvOsoblje.AllowUserToDeleteRows = false;
            this.dgvOsoblje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOsoblje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsoblje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime1,
            this.Prezime,
            this.NazivDjelatnosti,
            this.DatumPočetkaAngazmana});
            this.dgvOsoblje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOsoblje.Location = new System.Drawing.Point(3, 22);
            this.dgvOsoblje.Name = "dgvOsoblje";
            this.dgvOsoblje.ReadOnly = true;
            this.dgvOsoblje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOsoblje.Size = new System.Drawing.Size(497, 341);
            this.dgvOsoblje.TabIndex = 1;
            this.dgvOsoblje.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOsoblje_CellDoubleClick_1);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Ime1
            // 
            this.Ime1.DataPropertyName = "Ime";
            this.Ime1.HeaderText = "Ime";
            this.Ime1.Name = "Ime1";
            this.Ime1.ReadOnly = true;
            this.Ime1.Width = 61;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 91;
            // 
            // NazivDjelatnosti
            // 
            this.NazivDjelatnosti.DataPropertyName = "NazivDjelatnosti";
            this.NazivDjelatnosti.HeaderText = "Naziv djelatnosti";
            this.NazivDjelatnosti.Name = "NazivDjelatnosti";
            this.NazivDjelatnosti.ReadOnly = true;
            this.NazivDjelatnosti.Width = 135;
            // 
            // DatumPočetkaAngazmana
            // 
            this.DatumPočetkaAngazmana.DataPropertyName = "DatumPocetkaAngazmana";
            this.DatumPočetkaAngazmana.HeaderText = "Datum početka angažmana";
            this.DatumPočetkaAngazmana.Name = "DatumPočetkaAngazmana";
            this.DatumPočetkaAngazmana.ReadOnly = true;
            this.DatumPočetkaAngazmana.Width = 210;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Green;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(429, 511);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(86, 41);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Izađi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmOsoblje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOsoblje";
            this.Text = "Osoblje pretraga";
            this.Load += new System.EventHandler(this.frmOsoblje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsoblje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cBoxNazivDjelatnosti;
        private System.Windows.Forms.DataGridView dgvOsoblje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivDjelatnosti;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPočetkaAngazmana;
        private System.Windows.Forms.Button button1;
    }
}