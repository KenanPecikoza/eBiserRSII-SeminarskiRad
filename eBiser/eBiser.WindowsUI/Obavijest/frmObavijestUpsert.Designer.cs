
namespace eBiser.WindowsUI.Obavijest
{
    partial class frmObavijestUpsert
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
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Obavijesti = new System.Windows.Forms.GroupBox();
            this.dgvObavijesti = new System.Windows.Forms.DataGridView();
            this.Naslov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.dtmPocetak = new System.Windows.Forms.DateTimePicker();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.cbxAktivna = new System.Windows.Forms.CheckBox();
            this.txtSadržaj = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOcjene = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxKategorija = new System.Windows.Forms.ComboBox();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.dtmKraj = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Obavijesti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sadržaj";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Obavijesti
            // 
            this.Obavijesti.Controls.Add(this.dgvObavijesti);
            this.Obavijesti.Location = new System.Drawing.Point(12, 554);
            this.Obavijesti.Name = "Obavijesti";
            this.Obavijesti.Size = new System.Drawing.Size(1091, 169);
            this.Obavijesti.TabIndex = 16;
            this.Obavijesti.TabStop = false;
            this.Obavijesti.Text = "Obavijesti";
            // 
            // dgvObavijesti
            // 
            this.dgvObavijesti.AllowUserToAddRows = false;
            this.dgvObavijesti.AllowUserToDeleteRows = false;
            this.dgvObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijesti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObavijesti.Location = new System.Drawing.Point(3, 22);
            this.dgvObavijesti.Name = "dgvObavijesti";
            this.dgvObavijesti.ReadOnly = true;
            this.dgvObavijesti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObavijesti.Size = new System.Drawing.Size(1085, 144);
            this.dgvObavijesti.TabIndex = 0;
            this.dgvObavijesti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObavijesti_CellClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum početka važenja  obavijesti";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(30, 56);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(281, 26);
            this.txtNaslov.TabIndex = 13;
            this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaslov_Validating);
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.Green;
            this.btnSnimi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(979, 455);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(86, 41);
            this.btnSnimi.TabIndex = 0;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // dtmPocetak
            // 
            this.dtmPocetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmPocetak.Location = new System.Drawing.Point(30, 112);
            this.dtmPocetak.Name = "dtmPocetak";
            this.dtmPocetak.Size = new System.Drawing.Size(283, 26);
            this.dtmPocetak.TabIndex = 2;
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.Red;
            this.btnIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.ForeColor = System.Drawing.Color.White;
            this.btnIzadji.Location = new System.Drawing.Point(28, 455);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(86, 41);
            this.btnIzadji.TabIndex = 1;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // cbxAktivna
            // 
            this.cbxAktivna.AutoSize = true;
            this.cbxAktivna.Location = new System.Drawing.Point(32, 311);
            this.cbxAktivna.Name = "cbxAktivna";
            this.cbxAktivna.Size = new System.Drawing.Size(80, 24);
            this.cbxAktivna.TabIndex = 14;
            this.cbxAktivna.Text = "Aktivna";
            this.cbxAktivna.UseVisualStyleBackColor = true;
            // 
            // txtSadržaj
            // 
            this.txtSadržaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSadržaj.Location = new System.Drawing.Point(28, 372);
            this.txtSadržaj.Multiline = true;
            this.txtSadržaj.Name = "txtSadržaj";
            this.txtSadržaj.Size = new System.Drawing.Size(1037, 77);
            this.txtSadržaj.TabIndex = 7;
            this.txtSadržaj.Validating += new System.ComponentModel.CancelEventHandler(this.txtSadržaj_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOcjene);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cBoxKategorija);
            this.groupBox1.Controls.Add(this.txtPhoto);
            this.groupBox1.Controls.Add(this.txtSadržaj);
            this.groupBox1.Controls.Add(this.cbxAktivna);
            this.groupBox1.Controls.Add(this.btnIzadji);
            this.groupBox1.Controls.Add(this.dtmPocetak);
            this.groupBox1.Controls.Add(this.btnSnimi);
            this.groupBox1.Controls.Add(this.txtNaslov);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Naslov);
            this.groupBox1.Controls.Add(this.dtmKraj);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddPhoto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 502);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obavijest";
            // 
            // btnOcjene
            // 
            this.btnOcjene.BackColor = System.Drawing.Color.Blue;
            this.btnOcjene.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcjene.ForeColor = System.Drawing.Color.White;
            this.btnOcjene.Location = new System.Drawing.Point(459, 455);
            this.btnOcjene.Name = "btnOcjene";
            this.btnOcjene.Size = new System.Drawing.Size(86, 41);
            this.btnOcjene.TabIndex = 18;
            this.btnOcjene.Text = "Ocjene";
            this.btnOcjene.UseVisualStyleBackColor = false;
            this.btnOcjene.Click += new System.EventHandler(this.btnOcjene_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sadržaj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kategorija";
            // 
            // cBoxKategorija
            // 
            this.cBoxKategorija.DisplayMember = "NazivKategorije";
            this.cBoxKategorija.FormattingEnabled = true;
            this.cBoxKategorija.Location = new System.Drawing.Point(28, 277);
            this.cBoxKategorija.Name = "cBoxKategorija";
            this.cBoxKategorija.Size = new System.Drawing.Size(283, 28);
            this.cBoxKategorija.TabIndex = 15;
            this.cBoxKategorija.ValueMember = "Id";
            // 
            // txtPhoto
            // 
            this.txtPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoto.Location = new System.Drawing.Point(28, 225);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(283, 26);
            this.txtPhoto.TabIndex = 8;
            // 
            // dtmKraj
            // 
            this.dtmKraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmKraj.Location = new System.Drawing.Point(28, 173);
            this.dtmKraj.Name = "dtmKraj";
            this.dtmKraj.Size = new System.Drawing.Size(283, 26);
            this.dtmKraj.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(434, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(631, 244);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum isteka važenja  obavijesti";
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BackColor = System.Drawing.Color.Blue;
            this.btnAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhoto.ForeColor = System.Drawing.Color.White;
            this.btnAddPhoto.Location = new System.Drawing.Point(317, 218);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(86, 41);
            this.btnAddPhoto.TabIndex = 10;
            this.btnAddPhoto.Text = "Dodaj";
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fotografije";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmObavijestUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 735);
            this.Controls.Add(this.Obavijesti);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmObavijestUpsert";
            this.Text = "ObavijestDodaj";
            this.Load += new System.EventHandler(this.frmObavijestUpsert_Load);
            this.Obavijesti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox Obavijesti;
        private System.Windows.Forms.DataGridView dgvObavijesti;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.DateTimePicker dtmPocetak;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.CheckBox cbxAktivna;
        private System.Windows.Forms.TextBox txtSadržaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.DateTimePicker dtmKraj;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxKategorija;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOcjene;
    }
}