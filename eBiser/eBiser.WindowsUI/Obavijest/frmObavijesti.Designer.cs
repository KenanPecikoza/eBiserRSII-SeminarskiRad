
namespace eBiser.WindowsUI.Obavijest
{
    partial class frmObavijesti
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
            this.PretragaPoNaslovu = new System.Windows.Forms.Label();
            this.txtPretragaPoNaslovu = new System.Windows.Forms.TextBox();
            this.txtPretragaPoSadrzaju = new System.Windows.Forms.TextBox();
            this.PretragaPoSadrzaju = new System.Windows.Forms.Label();
            this.btnPretraziSadrzaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvObavijesti = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DatumObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijediDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadržaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PretragaPoDatumu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtmPretragaOd = new System.Windows.Forms.DateTimePicker();
            this.dtmPretragado = new System.Windows.Forms.DateTimePicker();
            this.gbPretragaPoDatumu = new System.Windows.Forms.GroupBox();
            this.btnPrezraziDatum = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPretragaObaParametra = new System.Windows.Forms.Button();
            this.btnDodajObavijest = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cBoxKategorija = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).BeginInit();
            this.gbPretragaPoDatumu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PretragaPoNaslovu
            // 
            this.PretragaPoNaslovu.AutoSize = true;
            this.PretragaPoNaslovu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PretragaPoNaslovu.Location = new System.Drawing.Point(6, 18);
            this.PretragaPoNaslovu.Name = "PretragaPoNaslovu";
            this.PretragaPoNaslovu.Size = new System.Drawing.Size(150, 20);
            this.PretragaPoNaslovu.TabIndex = 0;
            this.PretragaPoNaslovu.Text = "Pretraga po naslovu";
            // 
            // txtPretragaPoNaslovu
            // 
            this.txtPretragaPoNaslovu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretragaPoNaslovu.Location = new System.Drawing.Point(10, 41);
            this.txtPretragaPoNaslovu.Name = "txtPretragaPoNaslovu";
            this.txtPretragaPoNaslovu.Size = new System.Drawing.Size(261, 26);
            this.txtPretragaPoNaslovu.TabIndex = 1;
            // 
            // txtPretragaPoSadrzaju
            // 
            this.txtPretragaPoSadrzaju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretragaPoSadrzaju.Location = new System.Drawing.Point(10, 94);
            this.txtPretragaPoSadrzaju.Name = "txtPretragaPoSadrzaju";
            this.txtPretragaPoSadrzaju.Size = new System.Drawing.Size(261, 26);
            this.txtPretragaPoSadrzaju.TabIndex = 3;
            // 
            // PretragaPoSadrzaju
            // 
            this.PretragaPoSadrzaju.AutoSize = true;
            this.PretragaPoSadrzaju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PretragaPoSadrzaju.Location = new System.Drawing.Point(6, 71);
            this.PretragaPoSadrzaju.Name = "PretragaPoSadrzaju";
            this.PretragaPoSadrzaju.Size = new System.Drawing.Size(156, 20);
            this.PretragaPoSadrzaju.TabIndex = 2;
            this.PretragaPoSadrzaju.Text = "Pretraga po sadržaju";
            // 
            // btnPretraziSadrzaj
            // 
            this.btnPretraziSadrzaj.BackColor = System.Drawing.Color.Blue;
            this.btnPretraziSadrzaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziSadrzaj.ForeColor = System.Drawing.Color.White;
            this.btnPretraziSadrzaj.Location = new System.Drawing.Point(185, 129);
            this.btnPretraziSadrzaj.Name = "btnPretraziSadrzaj";
            this.btnPretraziSadrzaj.Size = new System.Drawing.Size(86, 41);
            this.btnPretraziSadrzaj.TabIndex = 8;
            this.btnPretraziSadrzaj.Text = "Pretraži";
            this.btnPretraziSadrzaj.UseVisualStyleBackColor = false;
            this.btnPretraziSadrzaj.Click += new System.EventHandler(this.btnPretraziSadrzaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvObavijesti);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 497);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obavijesti";
            // 
            // dgvObavijesti
            // 
            this.dgvObavijesti.AllowUserToAddRows = false;
            this.dgvObavijesti.AllowUserToDeleteRows = false;
            this.dgvObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijesti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naslov,
            this.Aktivna,
            this.DatumObjave,
            this.VrijediDo,
            this.Sadržaj});
            this.dgvObavijesti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObavijesti.Location = new System.Drawing.Point(3, 22);
            this.dgvObavijesti.Name = "dgvObavijesti";
            this.dgvObavijesti.ReadOnly = true;
            this.dgvObavijesti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObavijesti.Size = new System.Drawing.Size(827, 472);
            this.dgvObavijesti.TabIndex = 0;
            this.dgvObavijesti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObavijesti_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // Aktivna
            // 
            this.Aktivna.DataPropertyName = "Aktivna";
            this.Aktivna.HeaderText = "Aktivna";
            this.Aktivna.Name = "Aktivna";
            this.Aktivna.ReadOnly = true;
            // 
            // DatumObjave
            // 
            this.DatumObjave.DataPropertyName = "DatumObjave";
            this.DatumObjave.HeaderText = "Datum objave";
            this.DatumObjave.Name = "DatumObjave";
            this.DatumObjave.ReadOnly = true;
            // 
            // VrijediDo
            // 
            this.VrijediDo.DataPropertyName = "VrijediDo";
            this.VrijediDo.HeaderText = "Vrijedi do";
            this.VrijediDo.Name = "VrijediDo";
            this.VrijediDo.ReadOnly = true;
            // 
            // Sadržaj
            // 
            this.Sadržaj.DataPropertyName = "Sadržaj";
            this.Sadržaj.HeaderText = "Sadržaj";
            this.Sadržaj.Name = "Sadržaj";
            this.Sadržaj.ReadOnly = true;
            // 
            // PretragaPoDatumu
            // 
            this.PretragaPoDatumu.AutoSize = true;
            this.PretragaPoDatumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PretragaPoDatumu.Location = new System.Drawing.Point(5, 18);
            this.PretragaPoDatumu.Name = "PretragaPoDatumu";
            this.PretragaPoDatumu.Size = new System.Drawing.Size(172, 20);
            this.PretragaPoDatumu.TabIndex = 4;
            this.PretragaPoDatumu.Text = "Pretraga po datumu od";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pretraga po datumu do";
            // 
            // dtmPretragaOd
            // 
            this.dtmPretragaOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmPretragaOd.Location = new System.Drawing.Point(6, 41);
            this.dtmPretragaOd.Name = "dtmPretragaOd";
            this.dtmPretragaOd.Size = new System.Drawing.Size(283, 26);
            this.dtmPretragaOd.TabIndex = 5;
            // 
            // dtmPretragado
            // 
            this.dtmPretragado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmPretragado.Location = new System.Drawing.Point(6, 94);
            this.dtmPretragado.Name = "dtmPretragado";
            this.dtmPretragado.Size = new System.Drawing.Size(283, 26);
            this.dtmPretragado.TabIndex = 7;
            // 
            // gbPretragaPoDatumu
            // 
            this.gbPretragaPoDatumu.Controls.Add(this.btnPrezraziDatum);
            this.gbPretragaPoDatumu.Controls.Add(this.dtmPretragaOd);
            this.gbPretragaPoDatumu.Controls.Add(this.PretragaPoDatumu);
            this.gbPretragaPoDatumu.Controls.Add(this.label1);
            this.gbPretragaPoDatumu.Controls.Add(this.dtmPretragado);
            this.gbPretragaPoDatumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPretragaPoDatumu.Location = new System.Drawing.Point(304, 25);
            this.gbPretragaPoDatumu.Name = "gbPretragaPoDatumu";
            this.gbPretragaPoDatumu.Size = new System.Drawing.Size(299, 179);
            this.gbPretragaPoDatumu.TabIndex = 10;
            this.gbPretragaPoDatumu.TabStop = false;
            // 
            // btnPrezraziDatum
            // 
            this.btnPrezraziDatum.BackColor = System.Drawing.Color.Blue;
            this.btnPrezraziDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrezraziDatum.ForeColor = System.Drawing.Color.White;
            this.btnPrezraziDatum.Location = new System.Drawing.Point(203, 129);
            this.btnPrezraziDatum.Name = "btnPrezraziDatum";
            this.btnPrezraziDatum.Size = new System.Drawing.Size(86, 41);
            this.btnPrezraziDatum.TabIndex = 11;
            this.btnPrezraziDatum.Text = "Pretraži";
            this.btnPrezraziDatum.UseVisualStyleBackColor = false;
            this.btnPrezraziDatum.Click += new System.EventHandler(this.btnPrezraziDatum_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PretragaPoNaslovu);
            this.groupBox2.Controls.Add(this.txtPretragaPoNaslovu);
            this.groupBox2.Controls.Add(this.btnPretraziSadrzaj);
            this.groupBox2.Controls.Add(this.PretragaPoSadrzaju);
            this.groupBox2.Controls.Add(this.txtPretragaPoSadrzaju);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 179);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnPretragaObaParametra
            // 
            this.btnPretragaObaParametra.BackColor = System.Drawing.Color.Blue;
            this.btnPretragaObaParametra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretragaObaParametra.ForeColor = System.Drawing.Color.White;
            this.btnPretragaObaParametra.Location = new System.Drawing.Point(609, 154);
            this.btnPretragaObaParametra.Name = "btnPretragaObaParametra";
            this.btnPretragaObaParametra.Size = new System.Drawing.Size(215, 44);
            this.btnPretragaObaParametra.TabIndex = 13;
            this.btnPretragaObaParametra.Text = "Pretraga oba paramtetra";
            this.btnPretragaObaParametra.UseVisualStyleBackColor = false;
            this.btnPretragaObaParametra.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDodajObavijest
            // 
            this.btnDodajObavijest.BackColor = System.Drawing.Color.Green;
            this.btnDodajObavijest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajObavijest.ForeColor = System.Drawing.Color.White;
            this.btnDodajObavijest.Location = new System.Drawing.Point(759, 749);
            this.btnDodajObavijest.Name = "btnDodajObavijest";
            this.btnDodajObavijest.Size = new System.Drawing.Size(86, 41);
            this.btnDodajObavijest.TabIndex = 14;
            this.btnDodajObavijest.Text = "Dodaj ";
            this.btnDodajObavijest.UseVisualStyleBackColor = false;
            this.btnDodajObavijest.Click += new System.EventHandler(this.btnDodajObavijest_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cBoxKategorija);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.btnPretragaObaParametra);
            this.groupBox3.Controls.Add(this.gbPretragaPoDatumu);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(830, 234);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pretraga";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 745);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Izađi";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cBoxKategorija
            // 
            this.cBoxKategorija.DisplayMember = "Id";
            this.cBoxKategorija.FormattingEnabled = true;
            this.cBoxKategorija.Location = new System.Drawing.Point(609, 66);
            this.cBoxKategorija.Name = "cBoxKategorija";
            this.cBoxKategorija.Size = new System.Drawing.Size(208, 28);
            this.cBoxKategorija.TabIndex = 14;
            this.cBoxKategorija.ValueMember = "Id";
            this.cBoxKategorija.SelectedIndexChanged += new System.EventHandler(this.cBoxKategorija_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kategorija";
            // 
            // frmObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 802);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDodajObavijest);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmObavijesti";
            this.Text = "Obavijesti";
            this.Load += new System.EventHandler(this.Obavijesti_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).EndInit();
            this.gbPretragaPoDatumu.ResumeLayout(false);
            this.gbPretragaPoDatumu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PretragaPoNaslovu;
        private System.Windows.Forms.TextBox txtPretragaPoNaslovu;
        private System.Windows.Forms.TextBox txtPretragaPoSadrzaju;
        private System.Windows.Forms.Label PretragaPoSadrzaju;
        private System.Windows.Forms.Button btnPretraziSadrzaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvObavijesti;
        private System.Windows.Forms.Label PretragaPoDatumu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtmPretragaOd;
        private System.Windows.Forms.DateTimePicker dtmPretragado;
        private System.Windows.Forms.GroupBox gbPretragaPoDatumu;
        private System.Windows.Forms.Button btnPrezraziDatum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPretragaObaParametra;
        private System.Windows.Forms.Button btnDodajObavijest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivna;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumObjave;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijediDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadržaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxKategorija;
    }
}