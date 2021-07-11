
namespace eBiser.WindowsUI.Donacije
{
    partial class frmDonacije
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
            this.dgvDonacije = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chBox = new System.Windows.Forms.CheckBox();
            this.dtmPretragaDatum = new System.Windows.Forms.DateTimePicker();
            this.PretragaPoDatumu = new System.Windows.Forms.Label();
            this.PretragaPoNaslovu = new System.Windows.Forms.Label();
            this.txtPretragaPoNaslovu = new System.Windows.Forms.TextBox();
            this.btnPretraziSadrzaj = new System.Windows.Forms.Button();
            this.PretragaPoSadrzaju = new System.Windows.Forms.Label();
            this.txtPretragaPoSadrzaju = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonacije)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDonacije
            // 
            this.dgvDonacije.AllowUserToAddRows = false;
            this.dgvDonacije.AllowUserToDeleteRows = false;
            this.dgvDonacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonacije.Location = new System.Drawing.Point(4, 24);
            this.dgvDonacije.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDonacije.Name = "dgvDonacije";
            this.dgvDonacije.ReadOnly = true;
            this.dgvDonacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonacije.Size = new System.Drawing.Size(826, 507);
            this.dgvDonacije.TabIndex = 0;
            this.dgvDonacije.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonacije_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDonacije);
            this.groupBox1.Location = new System.Drawing.Point(13, 180);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(834, 536);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Donacije";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chBox);
            this.groupBox3.Controls.Add(this.dtmPretragaDatum);
            this.groupBox3.Controls.Add(this.PretragaPoDatumu);
            this.groupBox3.Controls.Add(this.PretragaPoNaslovu);
            this.groupBox3.Controls.Add(this.txtPretragaPoNaslovu);
            this.groupBox3.Controls.Add(this.btnPretraziSadrzaj);
            this.groupBox3.Controls.Add(this.PretragaPoSadrzaju);
            this.groupBox3.Controls.Add(this.txtPretragaPoSadrzaju);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(830, 149);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pretraga";
            // 
            // chBox
            // 
            this.chBox.AutoSize = true;
            this.chBox.Location = new System.Drawing.Point(386, 105);
            this.chBox.Name = "chBox";
            this.chBox.Size = new System.Drawing.Size(107, 24);
            this.chBox.TabIndex = 18;
            this.chBox.Text = "Na čekanju";
            this.chBox.UseVisualStyleBackColor = true;
            // 
            // dtmPretragaDatum
            // 
            this.dtmPretragaDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmPretragaDatum.Location = new System.Drawing.Point(6, 105);
            this.dtmPretragaDatum.Name = "dtmPretragaDatum";
            this.dtmPretragaDatum.Size = new System.Drawing.Size(327, 26);
            this.dtmPretragaDatum.TabIndex = 17;
            // 
            // PretragaPoDatumu
            // 
            this.PretragaPoDatumu.AutoSize = true;
            this.PretragaPoDatumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PretragaPoDatumu.Location = new System.Drawing.Point(6, 82);
            this.PretragaPoDatumu.Name = "PretragaPoDatumu";
            this.PretragaPoDatumu.Size = new System.Drawing.Size(172, 20);
            this.PretragaPoDatumu.TabIndex = 16;
            this.PretragaPoDatumu.Text = "Pretraga po datumu do";
            // 
            // PretragaPoNaslovu
            // 
            this.PretragaPoNaslovu.AutoSize = true;
            this.PretragaPoNaslovu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PretragaPoNaslovu.Location = new System.Drawing.Point(6, 26);
            this.PretragaPoNaslovu.Name = "PretragaPoNaslovu";
            this.PretragaPoNaslovu.Size = new System.Drawing.Size(150, 20);
            this.PretragaPoNaslovu.TabIndex = 11;
            this.PretragaPoNaslovu.Text = "Pretraga po naslovu";
            // 
            // txtPretragaPoNaslovu
            // 
            this.txtPretragaPoNaslovu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretragaPoNaslovu.Location = new System.Drawing.Point(10, 49);
            this.txtPretragaPoNaslovu.Name = "txtPretragaPoNaslovu";
            this.txtPretragaPoNaslovu.Size = new System.Drawing.Size(340, 26);
            this.txtPretragaPoNaslovu.TabIndex = 12;
            // 
            // btnPretraziSadrzaj
            // 
            this.btnPretraziSadrzaj.BackColor = System.Drawing.Color.Blue;
            this.btnPretraziSadrzaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziSadrzaj.ForeColor = System.Drawing.Color.White;
            this.btnPretraziSadrzaj.Location = new System.Drawing.Point(738, 100);
            this.btnPretraziSadrzaj.Name = "btnPretraziSadrzaj";
            this.btnPretraziSadrzaj.Size = new System.Drawing.Size(86, 41);
            this.btnPretraziSadrzaj.TabIndex = 15;
            this.btnPretraziSadrzaj.Text = "Pretraži";
            this.btnPretraziSadrzaj.UseVisualStyleBackColor = false;
            this.btnPretraziSadrzaj.Click += new System.EventHandler(this.btnPretraziSadrzaj_Click);
            // 
            // PretragaPoSadrzaju
            // 
            this.PretragaPoSadrzaju.AutoSize = true;
            this.PretragaPoSadrzaju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PretragaPoSadrzaju.Location = new System.Drawing.Point(371, 26);
            this.PretragaPoSadrzaju.Name = "PretragaPoSadrzaju";
            this.PretragaPoSadrzaju.Size = new System.Drawing.Size(156, 20);
            this.PretragaPoSadrzaju.TabIndex = 13;
            this.PretragaPoSadrzaju.Text = "Pretraga po sadržaju";
            // 
            // txtPretragaPoSadrzaju
            // 
            this.txtPretragaPoSadrzaju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretragaPoSadrzaju.Location = new System.Drawing.Point(375, 49);
            this.txtPretragaPoSadrzaju.Name = "txtPretragaPoSadrzaju";
            this.txtPretragaPoSadrzaju.Size = new System.Drawing.Size(349, 26);
            this.txtPretragaPoSadrzaju.TabIndex = 14;
            // 
            // frmDonacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 774);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDonacije";
            this.Text = "Donacije pretraga";
            this.Load += new System.EventHandler(this.frmDonacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonacije)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonacije;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtmPretragaDatum;
        private System.Windows.Forms.Label PretragaPoDatumu;
        private System.Windows.Forms.Label PretragaPoNaslovu;
        private System.Windows.Forms.TextBox txtPretragaPoNaslovu;
        private System.Windows.Forms.Button btnPretraziSadrzaj;
        private System.Windows.Forms.Label PretragaPoSadrzaju;
        private System.Windows.Forms.TextBox txtPretragaPoSadrzaju;
        private System.Windows.Forms.CheckBox chBox;
    }
}