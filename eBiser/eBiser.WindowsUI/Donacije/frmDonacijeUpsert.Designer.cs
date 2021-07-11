
namespace eBiser.WindowsUI.Donacije
{
    partial class frmDonacijeUpsert
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
            this.chBoxNaCekanju = new System.Windows.Forms.CheckBox();
            this.cBoxDonatori = new System.Windows.Forms.ComboBox();
            this.chBoxOdbijena = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.chBoxPrihvaćena = new System.Windows.Forms.CheckBox();
            this.dtmPrijave = new System.Windows.Forms.DateTimePicker();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Naslov = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObrazlozenje = new System.Windows.Forms.TextBox();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.btnOdbij = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDonacije = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaslovDonacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisDonacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obavijesti = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPonisti = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonacije)).BeginInit();
            this.Obavijesti.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBoxNaCekanju);
            this.groupBox1.Controls.Add(this.cBoxDonatori);
            this.groupBox1.Controls.Add(this.chBoxOdbijena);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.chBoxPrihvaćena);
            this.groupBox1.Controls.Add(this.dtmPrijave);
            this.groupBox1.Controls.Add(this.txtNaslov);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Naslov);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 348);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Donacija";
            // 
            // chBoxNaCekanju
            // 
            this.chBoxNaCekanju.AutoSize = true;
            this.chBoxNaCekanju.Enabled = false;
            this.chBoxNaCekanju.Location = new System.Drawing.Point(238, 315);
            this.chBoxNaCekanju.Name = "chBoxNaCekanju";
            this.chBoxNaCekanju.Size = new System.Drawing.Size(107, 24);
            this.chBoxNaCekanju.TabIndex = 21;
            this.chBoxNaCekanju.Text = "Na čekanju";
            this.chBoxNaCekanju.UseVisualStyleBackColor = true;
            // 
            // cBoxDonatori
            // 
            this.cBoxDonatori.DisplayMember = "KorisnikId";
            this.cBoxDonatori.Enabled = false;
            this.cBoxDonatori.FormattingEnabled = true;
            this.cBoxDonatori.Location = new System.Drawing.Point(30, 164);
            this.cBoxDonatori.Name = "cBoxDonatori";
            this.cBoxDonatori.Size = new System.Drawing.Size(283, 28);
            this.cBoxDonatori.TabIndex = 20;
            this.cBoxDonatori.ValueMember = "KorisnikId";
            // 
            // chBoxOdbijena
            // 
            this.chBoxOdbijena.AutoSize = true;
            this.chBoxOdbijena.Enabled = false;
            this.chBoxOdbijena.Location = new System.Drawing.Point(141, 315);
            this.chBoxOdbijena.Name = "chBoxOdbijena";
            this.chBoxOdbijena.Size = new System.Drawing.Size(91, 24);
            this.chBoxOdbijena.TabIndex = 19;
            this.chBoxOdbijena.Text = "Odbijena";
            this.chBoxOdbijena.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Enabled = false;
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.Location = new System.Drawing.Point(30, 218);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(654, 91);
            this.txtOpis.TabIndex = 7;
            // 
            // chBoxPrihvaćena
            // 
            this.chBoxPrihvaćena.AutoSize = true;
            this.chBoxPrihvaćena.Enabled = false;
            this.chBoxPrihvaćena.Location = new System.Drawing.Point(29, 315);
            this.chBoxPrihvaćena.Name = "chBoxPrihvaćena";
            this.chBoxPrihvaćena.Size = new System.Drawing.Size(106, 24);
            this.chBoxPrihvaćena.TabIndex = 14;
            this.chBoxPrihvaćena.Text = "Prihvaćena";
            this.chBoxPrihvaćena.UseVisualStyleBackColor = true;
            // 
            // dtmPrijave
            // 
            this.dtmPrijave.Enabled = false;
            this.dtmPrijave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmPrijave.Location = new System.Drawing.Point(30, 112);
            this.dtmPrijave.Name = "dtmPrijave";
            this.dtmPrijave.Size = new System.Drawing.Size(283, 26);
            this.dtmPrijave.TabIndex = 2;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Enabled = false;
            this.txtNaslov.Location = new System.Drawing.Point(30, 56);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(281, 26);
            this.txtNaslov.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum ";
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Location = new System.Drawing.Point(26, 33);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(56, 20);
            this.Naslov.TabIndex = 12;
            this.Naslov.Text = "Naslov";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Donator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Obrazloženje";
            // 
            // txtObrazlozenje
            // 
            this.txtObrazlozenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObrazlozenje.Location = new System.Drawing.Point(29, 46);
            this.txtObrazlozenje.Multiline = true;
            this.txtObrazlozenje.Name = "txtObrazlozenje";
            this.txtObrazlozenje.Size = new System.Drawing.Size(654, 91);
            this.txtObrazlozenje.TabIndex = 22;
            this.txtObrazlozenje.Validating += new System.ComponentModel.CancelEventHandler(this.txtObrazlozenje_Validating);
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.BackColor = System.Drawing.Color.Green;
            this.btnPrihvati.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrihvati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrihvati.ForeColor = System.Drawing.Color.White;
            this.btnPrihvati.Location = new System.Drawing.Point(597, 143);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(86, 41);
            this.btnPrihvati.TabIndex = 17;
            this.btnPrihvati.Text = "Prihvati";
            this.btnPrihvati.UseVisualStyleBackColor = false;
            this.btnPrihvati.Click += new System.EventHandler(this.btnPrihvati_Click);
            // 
            // btnOdbij
            // 
            this.btnOdbij.BackColor = System.Drawing.Color.Red;
            this.btnOdbij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdbij.ForeColor = System.Drawing.Color.White;
            this.btnOdbij.Location = new System.Drawing.Point(29, 143);
            this.btnOdbij.Name = "btnOdbij";
            this.btnOdbij.Size = new System.Drawing.Size(86, 41);
            this.btnOdbij.TabIndex = 18;
            this.btnOdbij.Text = "Odbij";
            this.btnOdbij.UseVisualStyleBackColor = false;
            this.btnOdbij.Click += new System.EventHandler(this.btnOdbij_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sadržaj";
            // 
            // dgvDonacije
            // 
            this.dgvDonacije.AllowUserToAddRows = false;
            this.dgvDonacije.AllowUserToDeleteRows = false;
            this.dgvDonacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.KorisnikID,
            this.NaslovDonacije,
            this.Donator,
            this.OpisDonacije});
            this.dgvDonacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonacije.Location = new System.Drawing.Point(3, 22);
            this.dgvDonacije.Name = "dgvDonacije";
            this.dgvDonacije.ReadOnly = true;
            this.dgvDonacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonacije.Size = new System.Drawing.Size(699, 178);
            this.dgvDonacije.TabIndex = 0;
            this.dgvDonacije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonacije_CellClick);
            this.dgvDonacije.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonacije_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // KorisnikID
            // 
            this.KorisnikID.DataPropertyName = "KorisniciSistemaId";
            this.KorisnikID.HeaderText = "KorsinikId";
            this.KorisnikID.Name = "KorisnikID";
            this.KorisnikID.ReadOnly = true;
            this.KorisnikID.Visible = false;
            // 
            // NaslovDonacije
            // 
            this.NaslovDonacije.DataPropertyName = "Naziv";
            this.NaslovDonacije.HeaderText = "Naslov";
            this.NaslovDonacije.Name = "NaslovDonacije";
            this.NaslovDonacije.ReadOnly = true;
            // 
            // Donator
            // 
            this.Donator.DataPropertyName = "ImeIPrezimeDonatora";
            this.Donator.HeaderText = "Donator";
            this.Donator.Name = "Donator";
            this.Donator.ReadOnly = true;
            // 
            // OpisDonacije
            // 
            this.OpisDonacije.DataPropertyName = "OpisDonacije";
            this.OpisDonacije.HeaderText = "Opis donacije";
            this.OpisDonacije.Name = "OpisDonacije";
            this.OpisDonacije.ReadOnly = true;
            // 
            // Obavijesti
            // 
            this.Obavijesti.Controls.Add(this.dgvDonacije);
            this.Obavijesti.Location = new System.Drawing.Point(12, 569);
            this.Obavijesti.Name = "Obavijesti";
            this.Obavijesti.Size = new System.Drawing.Size(705, 203);
            this.Obavijesti.TabIndex = 21;
            this.Obavijesti.TabStop = false;
            this.Obavijesti.Text = "Donacije";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPonisti);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtObrazlozenje);
            this.groupBox2.Controls.Add(this.btnOdbij);
            this.groupBox2.Controls.Add(this.btnPrihvati);
            this.groupBox2.Location = new System.Drawing.Point(12, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odgovor";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnPonisti
            // 
            this.btnPonisti.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPonisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonisti.ForeColor = System.Drawing.Color.White;
            this.btnPonisti.Location = new System.Drawing.Point(299, 143);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(86, 41);
            this.btnPonisti.TabIndex = 28;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = false;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // frmDonacijeUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 824);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Obavijesti);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDonacijeUpsert";
            this.Text = "DonacijeDetails";
            this.Load += new System.EventHandler(this.DonacijeDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonacije)).EndInit();
            this.Obavijesti.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.CheckBox chBoxPrihvaćena;
        private System.Windows.Forms.DateTimePicker dtmPrijave;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOdbij;
        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.DataGridView dgvDonacije;
        private System.Windows.Forms.GroupBox Obavijesti;
        private System.Windows.Forms.CheckBox chBoxOdbijena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chBoxNaCekanju;
        private System.Windows.Forms.ComboBox cBoxDonatori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObrazlozenje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaslovDonacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donator;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisDonacije;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnPonisti;
    }
}