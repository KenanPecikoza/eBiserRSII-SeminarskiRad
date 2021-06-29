
namespace eBiser.WinUi.UlaznaSredstva
{
    partial class frmUlaznaSredstvaUpsert
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
            this.btnPonisti = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.Fotografije = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numIznos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtmDatum = new System.Windows.Forms.DateTimePicker();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.Naslov = new System.Windows.Forms.Label();
            this.dgvUlaznaSredstva = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaslovSredstva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIznos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUlaznaSredstva)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPonisti
            // 
            this.btnPonisti.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPonisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonisti.ForeColor = System.Drawing.Color.White;
            this.btnPonisti.Location = new System.Drawing.Point(6, 320);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(86, 41);
            this.btnPonisti.TabIndex = 13;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = false;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Controls.Add(this.btnPonisti);
            this.groupBox2.Controls.Add(this.btnSnimi);
            this.groupBox2.Controls.Add(this.btnAddPhoto);
            this.groupBox2.Controls.Add(this.txtPhoto);
            this.groupBox2.Controls.Add(this.Fotografije);
            this.groupBox2.Controls.Add(this.txtOpis);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numIznos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtmDatum);
            this.groupBox2.Controls.Add(this.txtNaslov);
            this.groupBox2.Controls.Add(this.Naslov);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 369);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(347, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(429, 166);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.Green;
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(690, 322);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(86, 41);
            this.btnSnimi.TabIndex = 11;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BackColor = System.Drawing.Color.Blue;
            this.btnAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhoto.ForeColor = System.Drawing.Color.White;
            this.btnAddPhoto.Location = new System.Drawing.Point(304, 194);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(86, 41);
            this.btnAddPhoto.TabIndex = 10;
            this.btnAddPhoto.Text = "Dodaj";
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // txtPhoto
            // 
            this.txtPhoto.Location = new System.Drawing.Point(10, 201);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(288, 26);
            this.txtPhoto.TabIndex = 9;
            // 
            // Fotografije
            // 
            this.Fotografije.AutoSize = true;
            this.Fotografije.Location = new System.Drawing.Point(6, 178);
            this.Fotografije.Name = "Fotografije";
            this.Fotografije.Size = new System.Drawing.Size(85, 20);
            this.Fotografije.TabIndex = 8;
            this.Fotografije.Text = "Fotografije";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(6, 253);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(770, 61);
            this.txtOpis.TabIndex = 7;
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opis";
            // 
            // numIznos
            // 
            this.numIznos.Location = new System.Drawing.Point(10, 149);
            this.numIznos.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numIznos.Name = "numIznos";
            this.numIznos.Size = new System.Drawing.Size(120, 26);
            this.numIznos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Iznos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum";
            // 
            // dtmDatum
            // 
            this.dtmDatum.Location = new System.Drawing.Point(10, 97);
            this.dtmDatum.Name = "dtmDatum";
            this.dtmDatum.Size = new System.Drawing.Size(288, 26);
            this.dtmDatum.TabIndex = 2;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(10, 45);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(288, 26);
            this.txtNaslov.TabIndex = 1;
            this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaslov_Validating);
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Location = new System.Drawing.Point(6, 22);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(56, 20);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "Naslov";
            // 
            // dgvUlaznaSredstva
            // 
            this.dgvUlaznaSredstva.AllowUserToAddRows = false;
            this.dgvUlaznaSredstva.AllowUserToDeleteRows = false;
            this.dgvUlaznaSredstva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUlaznaSredstva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUlaznaSredstva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NaslovSredstva,
            this.Iznos,
            this.Datum,
            this.Opis});
            this.dgvUlaznaSredstva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUlaznaSredstva.Location = new System.Drawing.Point(3, 22);
            this.dgvUlaznaSredstva.Name = "dgvUlaznaSredstva";
            this.dgvUlaznaSredstva.ReadOnly = true;
            this.dgvUlaznaSredstva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUlaznaSredstva.Size = new System.Drawing.Size(779, 238);
            this.dgvUlaznaSredstva.TabIndex = 0;
            this.dgvUlaznaSredstva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUlaznaSredstva_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 48;
            // 
            // NaslovSredstva
            // 
            this.NaslovSredstva.DataPropertyName = "Naslov";
            this.NaslovSredstva.HeaderText = "Naslov";
            this.NaslovSredstva.Name = "NaslovSredstva";
            this.NaslovSredstva.ReadOnly = true;
            this.NaslovSredstva.Width = 81;
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "Količina";
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            this.Iznos.Width = 73;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUlaznaSredstva);
            this.groupBox1.Location = new System.Drawing.Point(9, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 263);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulazna sredstva";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmUlaznaSredstvaUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 690);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUlaznaSredstvaUpsert";
            this.Text = "frmUlaznaSredstvaUpsert";
            this.Load += new System.EventHandler(this.frmUlaznaSredstvaUpsert_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIznos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUlaznaSredstva)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.Label Fotografije;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numIznos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtmDatum;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.DataGridView dgvUlaznaSredstva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaslovSredstva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}