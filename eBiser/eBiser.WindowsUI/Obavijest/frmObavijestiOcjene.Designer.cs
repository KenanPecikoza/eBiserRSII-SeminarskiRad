﻿
namespace eBiser.WindowsUI.Obavijest
{
    partial class frmObavijestiOcjene
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
            this.Obavijest = new System.Windows.Forms.Label();
            this.cBoxClan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOcjene = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjene)).BeginInit();
            this.SuspendLayout();
            // 
            // Obavijest
            // 
            this.Obavijest.AutoSize = true;
            this.Obavijest.Location = new System.Drawing.Point(12, 9);
            this.Obavijest.Name = "Obavijest";
            this.Obavijest.Size = new System.Drawing.Size(74, 20);
            this.Obavijest.TabIndex = 1;
            this.Obavijest.Text = "Obavijest";
            // 
            // cBoxClan
            // 
            this.cBoxClan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cBoxClan.DisplayMember = "Naziv";
            this.cBoxClan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxClan.FormattingEnabled = true;
            this.cBoxClan.Location = new System.Drawing.Point(16, 32);
            this.cBoxClan.Name = "cBoxClan";
            this.cBoxClan.Size = new System.Drawing.Size(897, 28);
            this.cBoxClan.TabIndex = 0;
            this.cBoxClan.ValueMember = "Id";
            this.cBoxClan.SelectedIndexChanged += new System.EventHandler(this.cBoxClan_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOcjene);
            this.groupBox1.Location = new System.Drawing.Point(16, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 418);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ocjene";
            // 
            // dgvOcjene
            // 
            this.dgvOcjene.AllowUserToAddRows = false;
            this.dgvOcjene.AllowUserToDeleteRows = false;
            this.dgvOcjene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcjene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOcjene.Location = new System.Drawing.Point(3, 22);
            this.dgvOcjene.Name = "dgvOcjene";
            this.dgvOcjene.ReadOnly = true;
            this.dgvOcjene.Size = new System.Drawing.Size(891, 393);
            this.dgvOcjene.TabIndex = 0;
            // 
            // frmObavijestiOcjene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Obavijest);
            this.Controls.Add(this.cBoxClan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmObavijestiOcjene";
            this.Text = "frmObavijestiOcjene";
            this.Load += new System.EventHandler(this.frmObavijestiOcjene_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Obavijest;
        private System.Windows.Forms.ComboBox cBoxClan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOcjene;
    }
}