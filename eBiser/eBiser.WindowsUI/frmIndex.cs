using eBiser.WindowsUI;
using eBiser.WindowsUI.AkcijePomoci;
using eBiser.WindowsUI.Clanarine;
using eBiser.WindowsUI.Clanovi;
using eBiser.WindowsUI.Donacije;
using eBiser.WindowsUI.Donatori;
using eBiser.WindowsUI.IzlaznaSerdstva;
using eBiser.WindowsUI.Login;
using eBiser.WindowsUI.Obavijest;
using eBiser.WindowsUI.Osoblje;
using eBiser.WindowsUI.Projekti;
using eBiser.WindowsUI.Report;
using eBiser.WindowsUI.Sastanak;
using eBiser.WindowsUI.UlaznaSredstva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBiser.WinUi
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }


        private void dodajObavijestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmObavijestUpsert obavijestDodaj = new frmObavijestUpsert();
            obavijestDodaj.Show();
        }

        private void pretragaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmClanovi clanovi = new frmClanovi();
            clanovi.Show();

        }

        private void noviClanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClanoviUpsert clanovi = new frmClanoviUpsert();
            //clanovi.MdiParent = this;
            clanovi.Show();
        }

        private void članarineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClanarine frmclanarine = new frmClanarine();
            frmclanarine.Show();

        }

        private void prikaziObavijestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmObavijesti obavijesti= new frmObavijesti();
            obavijesti.Show();
        }

        private void btnClanoviDodaj_Click(object sender, EventArgs e)
        {
            frmClanoviUpsert frmClanovi = new frmClanoviUpsert();
            frmClanovi.Show();
        }

        private void btnClanoviPrikazi_Click(object sender, EventArgs e)
        {
            frmClanovi frmClanovi = new frmClanovi();
            frmClanovi.Show();
        }

        private void dodajČlanarinuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClanarineUpsert frmClanarine = new frmClanarineUpsert();
            frmClanarine.Show();
        }

        private void btnClanarineDodaj_Click(object sender, EventArgs e)
        {
            frmClanarineUpsert frmClanarine = new frmClanarineUpsert();
            frmClanarine.Show();
        }

        private void btnClanarinePrikazi_Click(object sender, EventArgs e)
        {
            frmClanarine frmclanarine = new frmClanarine();
            frmclanarine.Show();
        }

        private void btnObavijestiDodaj_Click(object sender, EventArgs e)
        {
            frmObavijestUpsert obavijestDodaj = new frmObavijestUpsert();
            obavijestDodaj.Show();
        }

        private void btnObavijestiPrikaži_Click(object sender, EventArgs e)
        {
            frmObavijesti obavijesti = new frmObavijesti();
            obavijesti.Show();
        }

        private void btnAkcijePomoćiDodaj_Click(object sender, EventArgs e)
        {
            frmAkcijePomociUpsert akcijePomoci = new frmAkcijePomociUpsert();
            akcijePomoci.Show();
        }

        private void btnAkcijePomociPrikazi_Click(object sender, EventArgs e)
        {
            frmAkcijePomoci akcijePomoci = new frmAkcijePomoci();
            akcijePomoci.Show();
        }

        private void btnIzlaznaSredstvaPrikazi_Click(object sender, EventArgs e)
        {
            frmIzlaznaSredstva frmIzlaznaSredstva = new frmIzlaznaSredstva();
            frmIzlaznaSredstva.Show();
        }

        private void btnIzlaznaSredstvaDodaj_Click(object sender, EventArgs e)
        {
            frmIzlaznaSredstvaUpsert frmIzlaznaSredstva = new frmIzlaznaSredstvaUpsert();
            frmIzlaznaSredstva.Show();
        }

        private void btnUlaznaSredstvaPrikazi_Click(object sender, EventArgs e)
        {
            frmUlaznaSredstva ulaznaSredstva = new frmUlaznaSredstva();
            ulaznaSredstva.Show();
        }

        private void btnUlaznaSredstvaDodaj_Click(object sender, EventArgs e)
        {
            frmUlaznaSredstvaUpsert ulaznaSredstva = new frmUlaznaSredstvaUpsert();
            ulaznaSredstva.Show();
        }

        private void btnOsobljeDodaj_Click(object sender, EventArgs e)
        {
            frmOsobljeUpsert frmOsoblje = new frmOsobljeUpsert();
            frmOsoblje.Show();
        }

        private void BtnOsobljePrikazi_Click(object sender, EventArgs e)
        {
            frmOsoblje frmOsoblje = new frmOsoblje();
            frmOsoblje.Show();
        }

        private void btnSastanakDodaj_Click(object sender, EventArgs e)
        {
            frmSastanakUpsert sastanakUpsert = new frmSastanakUpsert();
            sastanakUpsert.Show();
        }

        private void btnSastanakPrikaži_Click(object sender, EventArgs e)
        {
            frmSastanak sastanakUpsert = new frmSastanak();
            sastanakUpsert.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            APIService.Token = null;
            this.Hide();
            var form2 = new frmLogin();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btnDonacijeDodaj_Click(object sender, EventArgs e)
        {
             frmDonacijeUpsert frmDonacijeUpsert = new frmDonacijeUpsert();
            frmDonacijeUpsert.Show();
        }

        private void btnDonacijePrikazi_Click(object sender, EventArgs e)
        {
            frmDonacije frmDonacijeUpsert = new frmDonacije();
            frmDonacijeUpsert.Show();
        }

        private void btnZakazi_Click(object sender, EventArgs e)
        {
            frmZakaziSastanak frmZakaziSastanak = new frmZakaziSastanak();
            frmZakaziSastanak.Show();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnDonatoriDodaj_Click(object sender, EventArgs e)
        {
            frmDonatoriUpsert frmDonatoriUpsert = new frmDonatoriUpsert();
            frmDonatoriUpsert.Show();
        }

        private void btnDonatoriPrikazi_Click(object sender, EventArgs e)
        {
            frmDonatori frmDonatori = new frmDonatori();
            frmDonatori.Show();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            frmObavijestiOcjene frmObavijestiOcjene = new frmObavijestiOcjene();
            frmObavijestiOcjene.Show();
        }

        private void btnFinansijskiIzvještajPrikaži_Click(object sender, EventArgs e)
        {
            frmIzvjestaj frmObavijestiOcjene = new frmIzvjestaj();
            frmObavijestiOcjene.Show();
        }

        private void btnPrikaziProjekte_Click(object sender, EventArgs e)
        {
            frmProjekti projekti = new frmProjekti();
            projekti.Show();
        }
    }
}
