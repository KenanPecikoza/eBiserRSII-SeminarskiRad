
namespace eBiser.WindowsUI.AkcijePomoci
{
    partial class frmAkcijePomociUpsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numTrazenaCifra = new System.Windows.Forms.NumericUpDown();
            this.numSakupljeno = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chBoxAktivno = new System.Windows.Forms.CheckBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAkcijePomoci = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.btnPoniši = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potrazivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sakupljeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numTrazenaCifra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSakupljeno)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkcijePomoci)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(10, 45);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(257, 26);
            this.txtIme.TabIndex = 1;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(10, 96);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(257, 26);
            this.txtPrezime.TabIndex = 3;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(6, 73);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(66, 20);
            this.labelPrezime.TabIndex = 2;
            this.labelPrezime.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tražena cifra";
            // 
            // numTrazenaCifra
            // 
            this.numTrazenaCifra.Location = new System.Drawing.Point(10, 148);
            this.numTrazenaCifra.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.numTrazenaCifra.Name = "numTrazenaCifra";
            this.numTrazenaCifra.Size = new System.Drawing.Size(257, 26);
            this.numTrazenaCifra.TabIndex = 5;
            // 
            // numSakupljeno
            // 
            this.numSakupljeno.Location = new System.Drawing.Point(10, 200);
            this.numSakupljeno.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.numSakupljeno.Name = "numSakupljeno";
            this.numSakupljeno.Size = new System.Drawing.Size(257, 26);
            this.numSakupljeno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sakupljeno";
            // 
            // chBoxAktivno
            // 
            this.chBoxAktivno.AutoSize = true;
            this.chBoxAktivno.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chBoxAktivno.Checked = true;
            this.chBoxAktivno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxAktivno.Location = new System.Drawing.Point(10, 286);
            this.chBoxAktivno.Name = "chBoxAktivno";
            this.chBoxAktivno.Size = new System.Drawing.Size(80, 24);
            this.chBoxAktivno.TabIndex = 8;
            this.chBoxAktivno.Text = "Aktivno";
            this.chBoxAktivno.UseVisualStyleBackColor = true;
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.Green;
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.ForeColor = System.Drawing.Color.White;
            this.btnSnimi.Location = new System.Drawing.Point(629, 316);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(86, 41);
            this.btnSnimi.TabIndex = 9;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAkcijePomoci);
            this.groupBox1.Location = new System.Drawing.Point(12, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 335);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Akcije pomoći";
            // 
            // dgvAkcijePomoci
            // 
            this.dgvAkcijePomoci.AllowUserToAddRows = false;
            this.dgvAkcijePomoci.AllowUserToDeleteRows = false;
            this.dgvAkcijePomoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAkcijePomoci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.Potrazivanja,
            this.Sakupljeno,
            this.Aktivno});
            this.dgvAkcijePomoci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAkcijePomoci.Location = new System.Drawing.Point(3, 22);
            this.dgvAkcijePomoci.Name = "dgvAkcijePomoci";
            this.dgvAkcijePomoci.ReadOnly = true;
            this.dgvAkcijePomoci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAkcijePomoci.Size = new System.Drawing.Size(721, 310);
            this.dgvAkcijePomoci.TabIndex = 0;
            this.dgvAkcijePomoci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAkcijePomoci_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnDodaj);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPhoto);
            this.groupBox2.Controls.Add(this.btnPoniši);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtIme);
            this.groupBox2.Controls.Add(this.btnSnimi);
            this.groupBox2.Controls.Add(this.labelPrezime);
            this.groupBox2.Controls.Add(this.txtPrezime);
            this.groupBox2.Controls.Add(this.chBoxAktivno);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numTrazenaCifra);
            this.groupBox2.Controls.Add(this.numSakupljeno);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 371);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(373, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 201);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Blue;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(273, 245);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(86, 41);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Slika";
            // 
            // txtPhoto
            // 
            this.txtPhoto.Location = new System.Drawing.Point(10, 252);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(257, 26);
            this.txtPhoto.TabIndex = 14;
            // 
            // btnPoniši
            // 
            this.btnPoniši.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPoniši.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoniši.ForeColor = System.Drawing.Color.White;
            this.btnPoniši.Location = new System.Drawing.Point(6, 316);
            this.btnPoniši.Name = "btnPoniši";
            this.btnPoniši.Size = new System.Drawing.Size(86, 41);
            this.btnPoniši.TabIndex = 13;
            this.btnPoniši.Text = "Poništi";
            this.btnPoniši.UseVisualStyleBackColor = false;
            this.btnPoniši.Click += new System.EventHandler(this.btnPoniši_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
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
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Potrazivanja
            // 
            this.Potrazivanja.DataPropertyName = "TraženaCifra";
            this.Potrazivanja.HeaderText = "Potrazivanja";
            this.Potrazivanja.Name = "Potrazivanja";
            this.Potrazivanja.ReadOnly = true;
            // 
            // Sakupljeno
            // 
            this.Sakupljeno.DataPropertyName = "Skupljeno";
            this.Sakupljeno.HeaderText = "Sakupljeno";
            this.Sakupljeno.Name = "Sakupljeno";
            this.Sakupljeno.ReadOnly = true;
            // 
            // Aktivno
            // 
            this.Aktivno.DataPropertyName = "Aktivno";
            this.Aktivno.HeaderText = "Aktivno";
            this.Aktivno.Name = "Aktivno";
            this.Aktivno.ReadOnly = true;
            // 
            // frmAkcijePomociUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 755);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAkcijePomociUpsert";
            this.Text = "frmAkcijePomociUpsert";
            this.Load += new System.EventHandler(this.frmAkcijePomociUpsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTrazenaCifra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSakupljeno)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkcijePomoci)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTrazenaCifra;
        private System.Windows.Forms.NumericUpDown numSakupljeno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chBoxAktivno;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAkcijePomoci;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPoniši;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potrazivanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sakupljeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktivno;
    }
}