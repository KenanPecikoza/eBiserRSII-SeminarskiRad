using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBiser.WindowsUI.Projekti
{
    public partial class frmProjektiUpsert : Form
    {
        private int? _id = null;

        public frmProjektiUpsert(int? id=null)
        {
            _id = id;

            InitializeComponent();
        }
    }
}
