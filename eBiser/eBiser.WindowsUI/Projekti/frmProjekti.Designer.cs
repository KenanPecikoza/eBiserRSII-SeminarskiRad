
namespace eBiser.WindowsUI.Projekti
{
    partial class frmProjekti
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtmIzvrsenja = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmPrijave = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivProjekta = new System.Windows.Forms.TextBox();
            this.BtnPrikazi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekti)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProjekti);
            this.groupBox1.Location = new System.Drawing.Point(12, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 443);
            this.groupBox1.TabIndex = 0;
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
            this.dgvProjekti.Size = new System.Drawing.Size(622, 418);
            this.dgvProjekti.TabIndex = 0;
            this.dgvProjekti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjekti_CellDoubleClick);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.dtmIzvrsenja);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtmPrijave);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtNazivProjekta);
            this.groupBox3.Controls.Add(this.BtnPrikazi);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(628, 153);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(321, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Prihvaćen";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dtmIzvrsenja
            // 
            this.dtmIzvrsenja.Location = new System.Drawing.Point(9, 91);
            this.dtmIzvrsenja.Name = "dtmIzvrsenja";
            this.dtmIzvrsenja.Size = new System.Drawing.Size(296, 26);
            this.dtmIzvrsenja.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datum izvšenja projekta:";
            // 
            // dtmPrijave
            // 
            this.dtmPrijave.Location = new System.Drawing.Point(321, 38);
            this.dtmPrijave.Name = "dtmPrijave";
            this.dtmPrijave.Size = new System.Drawing.Size(296, 26);
            this.dtmPrijave.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv projekta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum prijave projekta:";
            // 
            // txtNazivProjekta
            // 
            this.txtNazivProjekta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivProjekta.Location = new System.Drawing.Point(9, 38);
            this.txtNazivProjekta.Margin = new System.Windows.Forms.Padding(2);
            this.txtNazivProjekta.Name = "txtNazivProjekta";
            this.txtNazivProjekta.Size = new System.Drawing.Size(296, 26);
            this.txtNazivProjekta.TabIndex = 2;
            // 
            // BtnPrikazi
            // 
            this.BtnPrikazi.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrikazi.ForeColor = System.Drawing.Color.White;
            this.BtnPrikazi.Location = new System.Drawing.Point(531, 107);
            this.BtnPrikazi.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrikazi.Name = "BtnPrikazi";
            this.BtnPrikazi.Size = new System.Drawing.Size(86, 41);
            this.BtnPrikazi.TabIndex = 3;
            this.BtnPrikazi.Text = "Pretraži";
            this.BtnPrikazi.UseVisualStyleBackColor = false;
            this.BtnPrikazi.Click += new System.EventHandler(this.BtnPrikazi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Izađi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Green;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(551, 628);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(86, 41);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmProjekti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 682);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProjekti";
            this.Text = "Projekti pretraga";
            this.Load += new System.EventHandler(this.frmProjekti_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekti)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProjekti;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivProjekta;
        private System.Windows.Forms.Button BtnPrikazi;
        private System.Windows.Forms.DateTimePicker dtmPrijave;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dtmIzvrsenja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivProjekta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaProjekta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Prihvaćen;
        private System.Windows.Forms.DataGridViewTextBoxColumn RokIzvršenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzvrsenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn KreatorProjekta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDodaj;
    }
}