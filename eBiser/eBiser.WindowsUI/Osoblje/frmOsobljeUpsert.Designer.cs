
namespace eBiser.WindowsUI.Osoblje
{
    partial class frmOsobljeUpsert
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxNazivDjelatnosti = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.btnPhotoDodaj = new System.Windows.Forms.Button();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.txtFotografija = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOsoblje = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivDjelatnosti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPočetkaAngazmana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsoblje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKorisnickoIme);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cBoxNazivDjelatnosti);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.btnPonisti);
            this.groupBox1.Controls.Add(this.btnSnimi);
            this.groupBox1.Controls.Add(this.btnPhotoDodaj);
            this.groupBox1.Controls.Add(this.labelPhoto);
            this.groupBox1.Controls.Add(this.txtFotografija);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtmDatumPocetka);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Ime);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 457);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(283, 26);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Email";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(10, 149);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(283, 26);
            this.txtKorisnickoIme.TabIndex = 16;
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Korisnicko ime";
            // 
            // cBoxNazivDjelatnosti
            // 
            this.cBoxNazivDjelatnosti.DisplayMember = "NazivDjelatnosti";
            this.cBoxNazivDjelatnosti.FormattingEnabled = true;
            this.cBoxNazivDjelatnosti.Location = new System.Drawing.Point(10, 255);
            this.cBoxNazivDjelatnosti.Name = "cBoxNazivDjelatnosti";
            this.cBoxNazivDjelatnosti.Size = new System.Drawing.Size(281, 28);
            this.cBoxNazivDjelatnosti.TabIndex = 14;
            this.cBoxNazivDjelatnosti.ValueMember = "Id";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox.Location = new System.Drawing.Point(318, 22);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(292, 165);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // btnPonisti
            // 
            this.btnPonisti.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPonisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonisti.ForeColor = System.Drawing.Color.White;
            this.btnPonisti.Location = new System.Drawing.Point(10, 401);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(86, 41);
            this.btnPonisti.TabIndex = 12;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = false;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.Green;
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(522, 401);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(86, 41);
            this.btnSnimi.TabIndex = 11;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // btnPhotoDodaj
            // 
            this.btnPhotoDodaj.BackColor = System.Drawing.Color.Blue;
            this.btnPhotoDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhotoDodaj.ForeColor = System.Drawing.Color.White;
            this.btnPhotoDodaj.Location = new System.Drawing.Point(299, 352);
            this.btnPhotoDodaj.Name = "btnPhotoDodaj";
            this.btnPhotoDodaj.Size = new System.Drawing.Size(86, 41);
            this.btnPhotoDodaj.TabIndex = 1;
            this.btnPhotoDodaj.Text = "Dodaj";
            this.btnPhotoDodaj.UseVisualStyleBackColor = false;
            this.btnPhotoDodaj.Click += new System.EventHandler(this.btnPhotoDodaj_Click);
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(6, 338);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(85, 20);
            this.labelPhoto.TabIndex = 10;
            this.labelPhoto.Text = "Fotografija";
            // 
            // txtFotografija
            // 
            this.txtFotografija.Location = new System.Drawing.Point(10, 359);
            this.txtFotografija.Name = "txtFotografija";
            this.txtFotografija.Size = new System.Drawing.Size(283, 26);
            this.txtFotografija.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Datum početka angažmana";
            // 
            // dtmDatumPocetka
            // 
            this.dtmDatumPocetka.Location = new System.Drawing.Point(10, 309);
            this.dtmDatumPocetka.Name = "dtmDatumPocetka";
            this.dtmDatumPocetka.Size = new System.Drawing.Size(281, 26);
            this.dtmDatumPocetka.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv djelatnosti";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(10, 97);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(283, 26);
            this.txtPrezime.TabIndex = 4;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(10, 45);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(283, 26);
            this.txtIme.TabIndex = 3;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prezime";
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(6, 22);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(36, 20);
            this.Ime.TabIndex = 1;
            this.Ime.Text = "Ime";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOsoblje);
            this.groupBox2.Location = new System.Drawing.Point(12, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Osoblje ";
            // 
            // dgvOsoblje
            // 
            this.dgvOsoblje.AllowUserToAddRows = false;
            this.dgvOsoblje.AllowUserToDeleteRows = false;
            this.dgvOsoblje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOsoblje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsoblje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.KorisnikId,
            this.Ime1,
            this.Prezime,
            this.NazivDjelatnosti,
            this.DatumPočetkaAngazmana});
            this.dgvOsoblje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOsoblje.Location = new System.Drawing.Point(3, 22);
            this.dgvOsoblje.Name = "dgvOsoblje";
            this.dgvOsoblje.ReadOnly = true;
            this.dgvOsoblje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOsoblje.Size = new System.Drawing.Size(610, 208);
            this.dgvOsoblje.TabIndex = 0;
            this.dgvOsoblje.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOsoblje_CellClick_1);
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
            // KorisnikId
            // 
            this.KorisnikId.DataPropertyName = "KorisnikId";
            this.KorisnikId.HeaderText = "KorisnikId";
            this.KorisnikId.Name = "KorisnikId";
            this.KorisnikId.ReadOnly = true;
            this.KorisnikId.Visible = false;
            this.KorisnikId.Width = 103;
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
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmOsobljeUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOsobljeUpsert";
            this.Text = "frmOsobljeUpsert";
            this.Load += new System.EventHandler(this.frmOsobljeUpsert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsoblje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnPhotoDodaj;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.TextBox txtFotografija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtmDatumPocetka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox cBoxNazivDjelatnosti;
        private System.Windows.Forms.DataGridView dgvOsoblje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivDjelatnosti;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPočetkaAngazmana;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
    }
}