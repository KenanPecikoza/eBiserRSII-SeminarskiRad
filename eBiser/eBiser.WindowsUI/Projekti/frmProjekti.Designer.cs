
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPretragaIme = new System.Windows.Forms.TextBox();
            this.BtnPrikazi = new System.Windows.Forms.Button();
            this.txtPretragaPrezime = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekti)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProjekti);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projekti";
            // 
            // dgvProjekti
            // 
            this.dgvProjekti.AllowUserToAddRows = false;
            this.dgvProjekti.AllowUserToDeleteRows = false;
            this.dgvProjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjekti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjekti.Location = new System.Drawing.Point(3, 22);
            this.dgvProjekti.Name = "dgvProjekti";
            this.dgvProjekti.ReadOnly = true;
            this.dgvProjekti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjekti.Size = new System.Drawing.Size(651, 480);
            this.dgvProjekti.TabIndex = 0;
            this.dgvProjekti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjekti_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPretragaIme);
            this.groupBox3.Controls.Add(this.BtnPrikazi);
            this.groupBox3.Controls.Add(this.txtPretragaPrezime);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(657, 91);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime:";
            // 
            // txtPretragaIme
            // 
            this.txtPretragaIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretragaIme.Location = new System.Drawing.Point(9, 38);
            this.txtPretragaIme.Margin = new System.Windows.Forms.Padding(2);
            this.txtPretragaIme.Name = "txtPretragaIme";
            this.txtPretragaIme.Size = new System.Drawing.Size(259, 26);
            this.txtPretragaIme.TabIndex = 2;
            // 
            // BtnPrikazi
            // 
            this.BtnPrikazi.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrikazi.ForeColor = System.Drawing.Color.White;
            this.BtnPrikazi.Location = new System.Drawing.Point(566, 31);
            this.BtnPrikazi.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrikazi.Name = "BtnPrikazi";
            this.BtnPrikazi.Size = new System.Drawing.Size(86, 41);
            this.BtnPrikazi.TabIndex = 3;
            this.BtnPrikazi.Text = "Pretraži";
            this.BtnPrikazi.UseVisualStyleBackColor = false;
            // 
            // txtPretragaPrezime
            // 
            this.txtPretragaPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretragaPrezime.Location = new System.Drawing.Point(294, 38);
            this.txtPretragaPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.txtPretragaPrezime.Name = "txtPretragaPrezime";
            this.txtPretragaPrezime.Size = new System.Drawing.Size(259, 26);
            this.txtPretragaPrezime.TabIndex = 2;
            // 
            // frmProjekti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 626);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProjekti";
            this.Text = "frmProjekti";
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
        private System.Windows.Forms.TextBox txtPretragaIme;
        private System.Windows.Forms.Button BtnPrikazi;
        private System.Windows.Forms.TextBox txtPretragaPrezime;
    }
}