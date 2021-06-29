
namespace eBiser.WinUi.Sastanak
{
    partial class frmZakaziSastanak
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNalov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmDatumOdrzavanja = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnZakazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov";
            // 
            // txtNalov
            // 
            this.txtNalov.Location = new System.Drawing.Point(38, 48);
            this.txtNalov.Name = "txtNalov";
            this.txtNalov.Size = new System.Drawing.Size(254, 26);
            this.txtNalov.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum održavanja";
            // 
            // dtmDatumOdrzavanja
            // 
            this.dtmDatumOdrzavanja.Location = new System.Drawing.Point(310, 48);
            this.dtmDatumOdrzavanja.Name = "dtmDatumOdrzavanja";
            this.dtmDatumOdrzavanja.Size = new System.Drawing.Size(254, 26);
            this.dtmDatumOdrzavanja.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(38, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 41);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Nazad";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnZakazi
            // 
            this.btnZakazi.BackColor = System.Drawing.Color.Green;
            this.btnZakazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZakazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZakazi.ForeColor = System.Drawing.Color.White;
            this.btnZakazi.Location = new System.Drawing.Point(478, 100);
            this.btnZakazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(86, 41);
            this.btnZakazi.TabIndex = 28;
            this.btnZakazi.Text = "Zakaži";
            this.btnZakazi.UseVisualStyleBackColor = false;
            this.btnZakazi.Click += new System.EventHandler(this.btnZakazi_Click);
            // 
            // frmZakaziSastanak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 168);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnZakazi);
            this.Controls.Add(this.dtmDatumOdrzavanja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNalov);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmZakaziSastanak";
            this.Text = " Zakaži sastanak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNalov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmDatumOdrzavanja;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnZakazi;
    }
}