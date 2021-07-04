
namespace eBiser.WindowsUI.Projekti
{
    partial class frmProjektiUpsert
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
            this.dgvProjekti = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivProjekta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaProjekta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPrijave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prihvaćen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RokIzvršenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzvrsenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KreatorProjekta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projekt = new System.Windows.Forms.GroupBox();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtmIzvrsenja = new System.Windows.Forms.DateTimePicker();
            this.txtRokIzvršenja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numOdobrenaSredstva = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numCijena = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmPrijave = new System.Windows.Forms.DateTimePicker();
            this.txtNazivProjekta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekti)).BeginInit();
            this.Projekt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOdobrenaSredstva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProjekti);
            this.groupBox1.Location = new System.Drawing.Point(12, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 338);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projekti";
            // 
            // dgvProjekti
            // 
            this.dgvProjekti.AllowUserToAddRows = false;
            this.dgvProjekti.AllowUserToDeleteRows = false;
            this.dgvProjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjekti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NazivProjekta,
            this.CijenaProjekta,
            this.DatumPrijave,
            this.Prihvaćen,
            this.RokIzvršenja,
            this.DatumIzvrsenja,
            this.KreatorProjekta});
            this.dgvProjekti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjekti.Location = new System.Drawing.Point(3, 22);
            this.dgvProjekti.Name = "dgvProjekti";
            this.dgvProjekti.ReadOnly = true;
            this.dgvProjekti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjekti.Size = new System.Drawing.Size(629, 313);
            this.dgvProjekti.TabIndex = 0;
            this.dgvProjekti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjekti_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // NazivProjekta
            // 
            this.NazivProjekta.DataPropertyName = "NazivProjekta";
            this.NazivProjekta.HeaderText = "Naziv projekta";
            this.NazivProjekta.Name = "NazivProjekta";
            this.NazivProjekta.ReadOnly = true;
            // 
            // CijenaProjekta
            // 
            this.CijenaProjekta.DataPropertyName = "CijenaProjekta";
            this.CijenaProjekta.HeaderText = "Cijena projekta";
            this.CijenaProjekta.Name = "CijenaProjekta";
            this.CijenaProjekta.ReadOnly = true;
            // 
            // DatumPrijave
            // 
            this.DatumPrijave.DataPropertyName = "DatumPrijave";
            this.DatumPrijave.HeaderText = "Datum prijave projekta";
            this.DatumPrijave.Name = "DatumPrijave";
            this.DatumPrijave.ReadOnly = true;
            // 
            // Prihvaćen
            // 
            this.Prihvaćen.DataPropertyName = "Prihvaćen";
            this.Prihvaćen.HeaderText = "Prihvaćen";
            this.Prihvaćen.Name = "Prihvaćen";
            this.Prihvaćen.ReadOnly = true;
            this.Prihvaćen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Prihvaćen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RokIzvršenja
            // 
            this.RokIzvršenja.DataPropertyName = "RokIzvrsenja";
            this.RokIzvršenja.HeaderText = "Rok izvršenja";
            this.RokIzvršenja.Name = "RokIzvršenja";
            this.RokIzvršenja.ReadOnly = true;
            // 
            // DatumIzvrsenja
            // 
            this.DatumIzvrsenja.DataPropertyName = "DatumIzvrsenja";
            this.DatumIzvrsenja.HeaderText = "Datum izvršenja";
            this.DatumIzvrsenja.Name = "DatumIzvrsenja";
            this.DatumIzvrsenja.ReadOnly = true;
            // 
            // KreatorProjekta
            // 
            this.KreatorProjekta.DataPropertyName = "ImeIPrezime";
            this.KreatorProjekta.HeaderText = "Kreator projekta";
            this.KreatorProjekta.Name = "KreatorProjekta";
            this.KreatorProjekta.ReadOnly = true;
            // 
            // Projekt
            // 
            this.Projekt.Controls.Add(this.btnPonisti);
            this.Projekt.Controls.Add(this.btnSacuvaj);
            this.Projekt.Controls.Add(this.checkBox1);
            this.Projekt.Controls.Add(this.label6);
            this.Projekt.Controls.Add(this.dtmIzvrsenja);
            this.Projekt.Controls.Add(this.txtRokIzvršenja);
            this.Projekt.Controls.Add(this.label5);
            this.Projekt.Controls.Add(this.label4);
            this.Projekt.Controls.Add(this.numOdobrenaSredstva);
            this.Projekt.Controls.Add(this.label3);
            this.Projekt.Controls.Add(this.numCijena);
            this.Projekt.Controls.Add(this.label2);
            this.Projekt.Controls.Add(this.dtmPrijave);
            this.Projekt.Controls.Add(this.txtNazivProjekta);
            this.Projekt.Controls.Add(this.label1);
            this.Projekt.Location = new System.Drawing.Point(15, 12);
            this.Projekt.Name = "Projekt";
            this.Projekt.Size = new System.Drawing.Size(632, 427);
            this.Projekt.TabIndex = 2;
            this.Projekt.TabStop = false;
            this.Projekt.Text = "Projekt";
            // 
            // btnPonisti
            // 
            this.btnPonisti.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPonisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonisti.ForeColor = System.Drawing.Color.White;
            this.btnPonisti.Location = new System.Drawing.Point(10, 370);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(86, 41);
            this.btnPonisti.TabIndex = 22;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = false;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.Green;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(540, 370);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(86, 41);
            this.btnSacuvaj.TabIndex = 21;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 340);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 24);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Prihvaćen";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Datum izvršenja";
            // 
            // dtmIzvrsenja
            // 
            this.dtmIzvrsenja.Location = new System.Drawing.Point(12, 307);
            this.dtmIzvrsenja.Name = "dtmIzvrsenja";
            this.dtmIzvrsenja.Size = new System.Drawing.Size(276, 26);
            this.dtmIzvrsenja.TabIndex = 10;
            // 
            // txtRokIzvršenja
            // 
            this.txtRokIzvršenja.Location = new System.Drawing.Point(12, 203);
            this.txtRokIzvršenja.Name = "txtRokIzvršenja";
            this.txtRokIzvršenja.Size = new System.Drawing.Size(276, 26);
            this.txtRokIzvršenja.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rok izvšenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Odobrena sredstva";
            // 
            // numOdobrenaSredstva
            // 
            this.numOdobrenaSredstva.Location = new System.Drawing.Point(12, 255);
            this.numOdobrenaSredstva.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numOdobrenaSredstva.Name = "numOdobrenaSredstva";
            this.numOdobrenaSredstva.Size = new System.Drawing.Size(174, 26);
            this.numOdobrenaSredstva.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cijena projekta";
            // 
            // numCijena
            // 
            this.numCijena.Location = new System.Drawing.Point(10, 151);
            this.numCijena.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCijena.Name = "numCijena";
            this.numCijena.Size = new System.Drawing.Size(174, 26);
            this.numCijena.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum prijave";
            // 
            // dtmPrijave
            // 
            this.dtmPrijave.Location = new System.Drawing.Point(10, 97);
            this.dtmPrijave.Name = "dtmPrijave";
            this.dtmPrijave.Size = new System.Drawing.Size(276, 26);
            this.dtmPrijave.TabIndex = 2;
            // 
            // txtNazivProjekta
            // 
            this.txtNazivProjekta.Location = new System.Drawing.Point(10, 45);
            this.txtNazivProjekta.Name = "txtNazivProjekta";
            this.txtNazivProjekta.Size = new System.Drawing.Size(276, 26);
            this.txtNazivProjekta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv projekta";
            // 
            // frmProjektiUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 795);
            this.Controls.Add(this.Projekt);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProjektiUpsert";
            this.Text = "frmProjektiUpsert";
            this.Load += new System.EventHandler(this.frmProjektiUpsert_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekti)).EndInit();
            this.Projekt.ResumeLayout(false);
            this.Projekt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOdobrenaSredstva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProjekti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivProjekta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaProjekta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Prihvaćen;
        private System.Windows.Forms.DataGridViewTextBoxColumn RokIzvršenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzvrsenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn KreatorProjekta;
        private System.Windows.Forms.GroupBox Projekt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmPrijave;
        private System.Windows.Forms.TextBox txtNazivProjekta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCijena;
        private System.Windows.Forms.TextBox txtRokIzvršenja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numOdobrenaSredstva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtmIzvrsenja;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}