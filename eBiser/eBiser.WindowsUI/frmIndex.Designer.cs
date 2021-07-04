
namespace eBiser.WinUi
{
    partial class frmIndex
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClanoviPrikazi = new System.Windows.Forms.Button();
            this.btnClanoviDodaj = new System.Windows.Forms.Button();
            this.Clanarine = new System.Windows.Forms.GroupBox();
            this.btnClanarinePrikazi = new System.Windows.Forms.Button();
            this.btnClanarineDodaj = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObavijestiPrikaži = new System.Windows.Forms.Button();
            this.btnObavijestiDodaj = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAkcijePomociPrikazi = new System.Windows.Forms.Button();
            this.btnAkcijePomoćiDodaj = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnIzlaznaSredstvaPrikazi = new System.Windows.Forms.Button();
            this.btnIzlaznaSredstvaDodaj = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnUlaznaSredstvaPrikazi = new System.Windows.Forms.Button();
            this.btnUlaznaSredstvaDodaj = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnOsobljePrikazi = new System.Windows.Forms.Button();
            this.btnOsobljeDodaj = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnZakazi = new System.Windows.Forms.Button();
            this.btnSastanakPrikaži = new System.Windows.Forms.Button();
            this.btnSastanakDodaj = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnDonacijePrikazi = new System.Windows.Forms.Button();
            this.btnDonacijeDodaj = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnDonatoriPrikazi = new System.Windows.Forms.Button();
            this.btnDonatoriDodaj = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnFinansijskiIzvještajPrikaži = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Clanarine.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 912);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1764, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnClanoviPrikazi);
            this.groupBox1.Controls.Add(this.btnClanoviDodaj);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 218);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Članovi";
            // 
            // btnClanoviPrikazi
            // 
            this.btnClanoviPrikazi.AutoSize = true;
            this.btnClanoviPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClanoviPrikazi.Location = new System.Drawing.Point(249, 69);
            this.btnClanoviPrikazi.Name = "btnClanoviPrikazi";
            this.btnClanoviPrikazi.Size = new System.Drawing.Size(197, 71);
            this.btnClanoviPrikazi.TabIndex = 1;
            this.btnClanoviPrikazi.Text = "Prikaži";
            this.btnClanoviPrikazi.UseVisualStyleBackColor = true;
            this.btnClanoviPrikazi.Click += new System.EventHandler(this.btnClanoviPrikazi_Click);
            // 
            // btnClanoviDodaj
            // 
            this.btnClanoviDodaj.AutoSize = true;
            this.btnClanoviDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClanoviDodaj.Location = new System.Drawing.Point(18, 69);
            this.btnClanoviDodaj.Name = "btnClanoviDodaj";
            this.btnClanoviDodaj.Size = new System.Drawing.Size(197, 71);
            this.btnClanoviDodaj.TabIndex = 0;
            this.btnClanoviDodaj.Text = "Dodaj";
            this.btnClanoviDodaj.UseVisualStyleBackColor = true;
            this.btnClanoviDodaj.Click += new System.EventHandler(this.btnClanoviDodaj_Click);
            // 
            // Clanarine
            // 
            this.Clanarine.Controls.Add(this.btnClanarinePrikazi);
            this.Clanarine.Controls.Add(this.btnClanarineDodaj);
            this.Clanarine.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clanarine.Location = new System.Drawing.Point(12, 236);
            this.Clanarine.Name = "Clanarine";
            this.Clanarine.Size = new System.Drawing.Size(462, 218);
            this.Clanarine.TabIndex = 6;
            this.Clanarine.TabStop = false;
            this.Clanarine.Text = "Članarine";
            // 
            // btnClanarinePrikazi
            // 
            this.btnClanarinePrikazi.AutoSize = true;
            this.btnClanarinePrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClanarinePrikazi.Location = new System.Drawing.Point(249, 71);
            this.btnClanarinePrikazi.Name = "btnClanarinePrikazi";
            this.btnClanarinePrikazi.Size = new System.Drawing.Size(197, 71);
            this.btnClanarinePrikazi.TabIndex = 3;
            this.btnClanarinePrikazi.Text = "Prikaži";
            this.btnClanarinePrikazi.UseVisualStyleBackColor = true;
            this.btnClanarinePrikazi.Click += new System.EventHandler(this.btnClanarinePrikazi_Click);
            // 
            // btnClanarineDodaj
            // 
            this.btnClanarineDodaj.AutoSize = true;
            this.btnClanarineDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClanarineDodaj.Location = new System.Drawing.Point(18, 71);
            this.btnClanarineDodaj.Name = "btnClanarineDodaj";
            this.btnClanarineDodaj.Size = new System.Drawing.Size(197, 71);
            this.btnClanarineDodaj.TabIndex = 2;
            this.btnClanarineDodaj.Text = "Dodaj";
            this.btnClanarineDodaj.UseVisualStyleBackColor = true;
            this.btnClanarineDodaj.Click += new System.EventHandler(this.btnClanarineDodaj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObavijestiPrikaži);
            this.groupBox2.Controls.Add(this.btnObavijestiDodaj);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(480, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 218);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Obavijesti";
            // 
            // btnObavijestiPrikaži
            // 
            this.btnObavijestiPrikaži.AutoSize = true;
            this.btnObavijestiPrikaži.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObavijestiPrikaži.Location = new System.Drawing.Point(248, 71);
            this.btnObavijestiPrikaži.Name = "btnObavijestiPrikaži";
            this.btnObavijestiPrikaži.Size = new System.Drawing.Size(197, 71);
            this.btnObavijestiPrikaži.TabIndex = 3;
            this.btnObavijestiPrikaži.Text = "Prikaži";
            this.btnObavijestiPrikaži.UseVisualStyleBackColor = true;
            this.btnObavijestiPrikaži.Click += new System.EventHandler(this.btnObavijestiPrikaži_Click);
            // 
            // btnObavijestiDodaj
            // 
            this.btnObavijestiDodaj.AutoSize = true;
            this.btnObavijestiDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObavijestiDodaj.Location = new System.Drawing.Point(21, 71);
            this.btnObavijestiDodaj.Name = "btnObavijestiDodaj";
            this.btnObavijestiDodaj.Size = new System.Drawing.Size(197, 71);
            this.btnObavijestiDodaj.TabIndex = 2;
            this.btnObavijestiDodaj.Text = "Dodaj";
            this.btnObavijestiDodaj.UseVisualStyleBackColor = true;
            this.btnObavijestiDodaj.Click += new System.EventHandler(this.btnObavijestiDodaj_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAkcijePomociPrikazi);
            this.groupBox3.Controls.Add(this.btnAkcijePomoćiDodaj);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 460);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 218);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Akcije pomoći";
            // 
            // btnAkcijePomociPrikazi
            // 
            this.btnAkcijePomociPrikazi.AutoSize = true;
            this.btnAkcijePomociPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAkcijePomociPrikazi.Location = new System.Drawing.Point(249, 67);
            this.btnAkcijePomociPrikazi.Name = "btnAkcijePomociPrikazi";
            this.btnAkcijePomociPrikazi.Size = new System.Drawing.Size(197, 71);
            this.btnAkcijePomociPrikazi.TabIndex = 3;
            this.btnAkcijePomociPrikazi.Text = "Prikaži";
            this.btnAkcijePomociPrikazi.UseVisualStyleBackColor = true;
            this.btnAkcijePomociPrikazi.Click += new System.EventHandler(this.btnAkcijePomociPrikazi_Click);
            // 
            // btnAkcijePomoćiDodaj
            // 
            this.btnAkcijePomoćiDodaj.AutoSize = true;
            this.btnAkcijePomoćiDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAkcijePomoćiDodaj.Location = new System.Drawing.Point(18, 67);
            this.btnAkcijePomoćiDodaj.Name = "btnAkcijePomoćiDodaj";
            this.btnAkcijePomoćiDodaj.Size = new System.Drawing.Size(197, 71);
            this.btnAkcijePomoćiDodaj.TabIndex = 2;
            this.btnAkcijePomoćiDodaj.Text = "Dodaj";
            this.btnAkcijePomoćiDodaj.UseVisualStyleBackColor = true;
            this.btnAkcijePomoćiDodaj.Click += new System.EventHandler(this.btnAkcijePomoćiDodaj_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnIzlaznaSredstvaPrikazi);
            this.groupBox4.Controls.Add(this.btnIzlaznaSredstvaDodaj);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 684);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 218);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Izlazna sredstva";
            // 
            // btnIzlaznaSredstvaPrikazi
            // 
            this.btnIzlaznaSredstvaPrikazi.AutoSize = true;
            this.btnIzlaznaSredstvaPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlaznaSredstvaPrikazi.Location = new System.Drawing.Point(249, 70);
            this.btnIzlaznaSredstvaPrikazi.Name = "btnIzlaznaSredstvaPrikazi";
            this.btnIzlaznaSredstvaPrikazi.Size = new System.Drawing.Size(197, 71);
            this.btnIzlaznaSredstvaPrikazi.TabIndex = 3;
            this.btnIzlaznaSredstvaPrikazi.Text = "Prikaži";
            this.btnIzlaznaSredstvaPrikazi.UseVisualStyleBackColor = true;
            this.btnIzlaznaSredstvaPrikazi.Click += new System.EventHandler(this.btnIzlaznaSredstvaPrikazi_Click);
            // 
            // btnIzlaznaSredstvaDodaj
            // 
            this.btnIzlaznaSredstvaDodaj.AutoSize = true;
            this.btnIzlaznaSredstvaDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlaznaSredstvaDodaj.Location = new System.Drawing.Point(6, 70);
            this.btnIzlaznaSredstvaDodaj.Name = "btnIzlaznaSredstvaDodaj";
            this.btnIzlaznaSredstvaDodaj.Size = new System.Drawing.Size(197, 71);
            this.btnIzlaznaSredstvaDodaj.TabIndex = 2;
            this.btnIzlaznaSredstvaDodaj.Text = "Dodaj";
            this.btnIzlaznaSredstvaDodaj.UseVisualStyleBackColor = true;
            this.btnIzlaznaSredstvaDodaj.Click += new System.EventHandler(this.btnIzlaznaSredstvaDodaj_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnUlaznaSredstvaPrikazi);
            this.groupBox5.Controls.Add(this.btnUlaznaSredstvaDodaj);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(480, 684);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(462, 218);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ulazna Sredstva";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // btnUlaznaSredstvaPrikazi
            // 
            this.btnUlaznaSredstvaPrikazi.AutoSize = true;
            this.btnUlaznaSredstvaPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUlaznaSredstvaPrikazi.Location = new System.Drawing.Point(242, 70);
            this.btnUlaznaSredstvaPrikazi.Name = "btnUlaznaSredstvaPrikazi";
            this.btnUlaznaSredstvaPrikazi.Size = new System.Drawing.Size(197, 71);
            this.btnUlaznaSredstvaPrikazi.TabIndex = 3;
            this.btnUlaznaSredstvaPrikazi.Text = "Prikaži";
            this.btnUlaznaSredstvaPrikazi.UseVisualStyleBackColor = true;
            this.btnUlaznaSredstvaPrikazi.Click += new System.EventHandler(this.btnUlaznaSredstvaPrikazi_Click);
            // 
            // btnUlaznaSredstvaDodaj
            // 
            this.btnUlaznaSredstvaDodaj.AutoSize = true;
            this.btnUlaznaSredstvaDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUlaznaSredstvaDodaj.Location = new System.Drawing.Point(15, 70);
            this.btnUlaznaSredstvaDodaj.Name = "btnUlaznaSredstvaDodaj";
            this.btnUlaznaSredstvaDodaj.Size = new System.Drawing.Size(197, 71);
            this.btnUlaznaSredstvaDodaj.TabIndex = 2;
            this.btnUlaznaSredstvaDodaj.Text = "Dodaj";
            this.btnUlaznaSredstvaDodaj.UseVisualStyleBackColor = true;
            this.btnUlaznaSredstvaDodaj.Click += new System.EventHandler(this.btnUlaznaSredstvaDodaj_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.BtnOsobljePrikazi);
            this.groupBox6.Controls.Add(this.btnOsobljeDodaj);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(480, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(462, 218);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Osoblje";
            // 
            // BtnOsobljePrikazi
            // 
            this.BtnOsobljePrikazi.AutoSize = true;
            this.BtnOsobljePrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOsobljePrikazi.Location = new System.Drawing.Point(248, 69);
            this.BtnOsobljePrikazi.Name = "BtnOsobljePrikazi";
            this.BtnOsobljePrikazi.Size = new System.Drawing.Size(197, 71);
            this.BtnOsobljePrikazi.TabIndex = 1;
            this.BtnOsobljePrikazi.Text = "Prikaži";
            this.BtnOsobljePrikazi.UseVisualStyleBackColor = true;
            this.BtnOsobljePrikazi.Click += new System.EventHandler(this.BtnOsobljePrikazi_Click);
            // 
            // btnOsobljeDodaj
            // 
            this.btnOsobljeDodaj.AutoSize = true;
            this.btnOsobljeDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsobljeDodaj.Location = new System.Drawing.Point(21, 69);
            this.btnOsobljeDodaj.Name = "btnOsobljeDodaj";
            this.btnOsobljeDodaj.Size = new System.Drawing.Size(197, 71);
            this.btnOsobljeDodaj.TabIndex = 0;
            this.btnOsobljeDodaj.Text = "Dodaj";
            this.btnOsobljeDodaj.UseVisualStyleBackColor = true;
            this.btnOsobljeDodaj.Click += new System.EventHandler(this.btnOsobljeDodaj_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSize = true;
            this.groupBox7.Controls.Add(this.btnZakazi);
            this.groupBox7.Controls.Add(this.btnSastanakPrikaži);
            this.groupBox7.Controls.Add(this.btnSastanakDodaj);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(948, 684);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(729, 218);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sastanak";
            // 
            // btnZakazi
            // 
            this.btnZakazi.AutoSize = true;
            this.btnZakazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZakazi.Location = new System.Drawing.Point(492, 70);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(197, 71);
            this.btnZakazi.TabIndex = 2;
            this.btnZakazi.Text = "Zakaži";
            this.btnZakazi.UseVisualStyleBackColor = true;
            this.btnZakazi.Click += new System.EventHandler(this.btnZakazi_Click);
            // 
            // btnSastanakPrikaži
            // 
            this.btnSastanakPrikaži.AutoSize = true;
            this.btnSastanakPrikaži.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSastanakPrikaži.Location = new System.Drawing.Point(265, 70);
            this.btnSastanakPrikaži.Name = "btnSastanakPrikaži";
            this.btnSastanakPrikaži.Size = new System.Drawing.Size(197, 71);
            this.btnSastanakPrikaži.TabIndex = 1;
            this.btnSastanakPrikaži.Text = "Prikaži";
            this.btnSastanakPrikaži.UseVisualStyleBackColor = true;
            this.btnSastanakPrikaži.Click += new System.EventHandler(this.btnSastanakPrikaži_Click);
            // 
            // btnSastanakDodaj
            // 
            this.btnSastanakDodaj.AutoSize = true;
            this.btnSastanakDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSastanakDodaj.Location = new System.Drawing.Point(26, 70);
            this.btnSastanakDodaj.Name = "btnSastanakDodaj";
            this.btnSastanakDodaj.Size = new System.Drawing.Size(197, 71);
            this.btnSastanakDodaj.TabIndex = 0;
            this.btnSastanakDodaj.Text = "Dodaj";
            this.btnSastanakDodaj.UseVisualStyleBackColor = true;
            this.btnSastanakDodaj.Click += new System.EventHandler(this.btnSastanakDodaj_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(1470, 81);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(197, 71);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Odjavi se";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.AutoSize = true;
            this.groupBox8.Controls.Add(this.btnDonacijePrikazi);
            this.groupBox8.Controls.Add(this.btnDonacijeDodaj);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(480, 460);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(462, 218);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Donacije";
            // 
            // btnDonacijePrikazi
            // 
            this.btnDonacijePrikazi.AutoSize = true;
            this.btnDonacijePrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonacijePrikazi.Location = new System.Drawing.Point(248, 67);
            this.btnDonacijePrikazi.Name = "btnDonacijePrikazi";
            this.btnDonacijePrikazi.Size = new System.Drawing.Size(197, 71);
            this.btnDonacijePrikazi.TabIndex = 1;
            this.btnDonacijePrikazi.Text = "Prikaži";
            this.btnDonacijePrikazi.UseVisualStyleBackColor = true;
            this.btnDonacijePrikazi.Click += new System.EventHandler(this.btnDonacijePrikazi_Click);
            // 
            // btnDonacijeDodaj
            // 
            this.btnDonacijeDodaj.AutoSize = true;
            this.btnDonacijeDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonacijeDodaj.Location = new System.Drawing.Point(21, 67);
            this.btnDonacijeDodaj.Name = "btnDonacijeDodaj";
            this.btnDonacijeDodaj.Size = new System.Drawing.Size(197, 71);
            this.btnDonacijeDodaj.TabIndex = 0;
            this.btnDonacijeDodaj.Text = "Dodaj";
            this.btnDonacijeDodaj.UseVisualStyleBackColor = true;
            this.btnDonacijeDodaj.Click += new System.EventHandler(this.btnDonacijeDodaj_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.AutoSize = true;
            this.groupBox9.Controls.Add(this.btnDonatoriPrikazi);
            this.groupBox9.Controls.Add(this.btnDonatoriDodaj);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(948, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(462, 218);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Donatori";
            // 
            // btnDonatoriPrikazi
            // 
            this.btnDonatoriPrikazi.AutoSize = true;
            this.btnDonatoriPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonatoriPrikazi.Location = new System.Drawing.Point(244, 69);
            this.btnDonatoriPrikazi.Name = "btnDonatoriPrikazi";
            this.btnDonatoriPrikazi.Size = new System.Drawing.Size(197, 71);
            this.btnDonatoriPrikazi.TabIndex = 1;
            this.btnDonatoriPrikazi.Text = "Prikaži";
            this.btnDonatoriPrikazi.UseVisualStyleBackColor = true;
            this.btnDonatoriPrikazi.Click += new System.EventHandler(this.btnDonatoriPrikazi_Click);
            // 
            // btnDonatoriDodaj
            // 
            this.btnDonatoriDodaj.AutoSize = true;
            this.btnDonatoriDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonatoriDodaj.Location = new System.Drawing.Point(26, 69);
            this.btnDonatoriDodaj.Name = "btnDonatoriDodaj";
            this.btnDonatoriDodaj.Size = new System.Drawing.Size(197, 71);
            this.btnDonatoriDodaj.TabIndex = 0;
            this.btnDonatoriDodaj.Text = "Dodaj";
            this.btnDonatoriDodaj.UseVisualStyleBackColor = true;
            this.btnDonatoriDodaj.Click += new System.EventHandler(this.btnDonatoriDodaj_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.AutoSize = true;
            this.groupBox10.Controls.Add(this.btnPrikazi);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(948, 460);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(462, 218);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Ocjene obavijesti";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.AutoSize = true;
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.Location = new System.Drawing.Point(130, 67);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(197, 71);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.AutoSize = true;
            this.groupBox11.Controls.Add(this.btnFinansijskiIzvještajPrikaži);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(948, 236);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(462, 218);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Finansijski Izvještaj";
            // 
            // btnFinansijskiIzvještajPrikaži
            // 
            this.btnFinansijskiIzvještajPrikaži.AutoSize = true;
            this.btnFinansijskiIzvještajPrikaži.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinansijskiIzvještajPrikaži.Location = new System.Drawing.Point(130, 71);
            this.btnFinansijskiIzvještajPrikaži.Name = "btnFinansijskiIzvještajPrikaži";
            this.btnFinansijskiIzvještajPrikaži.Size = new System.Drawing.Size(197, 71);
            this.btnFinansijskiIzvještajPrikaži.TabIndex = 1;
            this.btnFinansijskiIzvještajPrikaži.Text = "Prikaži";
            this.btnFinansijskiIzvještajPrikaži.UseVisualStyleBackColor = true;
            this.btnFinansijskiIzvještajPrikaži.Click += new System.EventHandler(this.btnFinansijskiIzvještajPrikaži_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 934);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Clanarine);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "frmIndex";
            this.Text = "eBiser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Clanarine.ResumeLayout(false);
            this.Clanarine.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClanoviPrikazi;
        private System.Windows.Forms.Button btnClanoviDodaj;
        private System.Windows.Forms.GroupBox Clanarine;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClanarinePrikazi;
        private System.Windows.Forms.Button btnClanarineDodaj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObavijestiPrikaži;
        private System.Windows.Forms.Button btnObavijestiDodaj;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAkcijePomociPrikazi;
        private System.Windows.Forms.Button btnAkcijePomoćiDodaj;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnIzlaznaSredstvaPrikazi;
        private System.Windows.Forms.Button btnIzlaznaSredstvaDodaj;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnUlaznaSredstvaPrikazi;
        private System.Windows.Forms.Button btnUlaznaSredstvaDodaj;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnOsobljePrikazi;
        private System.Windows.Forms.Button btnOsobljeDodaj;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSastanakPrikaži;
        private System.Windows.Forms.Button btnSastanakDodaj;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnDonacijePrikazi;
        private System.Windows.Forms.Button btnDonacijeDodaj;
        private System.Windows.Forms.Button btnZakazi;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnDonatoriPrikazi;
        private System.Windows.Forms.Button btnDonatoriDodaj;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btnFinansijskiIzvještajPrikaži;
    }
}



