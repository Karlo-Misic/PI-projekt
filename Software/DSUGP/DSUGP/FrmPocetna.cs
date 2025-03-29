using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSUGP
{
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }
        private void btnVoznaLinija_Click(object sender, EventArgs e)
        {
            FrmVoznaLinija frmVoznaLinija = new FrmVoznaLinija();
            //Hide();
            frmVoznaLinija.ShowDialog();
            //Close();
        }
        private void btnAutobusnaStanica_Click(object sender, EventArgs e)
        {
            FrmAutobusnaStanica frmAutobusnaStanica = new FrmAutobusnaStanica();
            //Hide();
            frmAutobusnaStanica.ShowDialog();
            //Close();
        }
        private void btnVozniPark_Click(object sender, EventArgs e)
        {
            FrmVozniPark frmVozniPark = new FrmVozniPark();
            //Hide();
            frmVozniPark.ShowDialog();
            //Close();
        }
        private void btnIspis_Click(object sender, EventArgs e)
        {
            IspisVozneLinije ispisVozneLinije = new IspisVozneLinije();
            //Hide();
            ispisVozneLinije.ShowDialog();
            //Close();
        }
        private void btnIspisAutobus_Click(object sender, EventArgs e)
        {
            IspisAutobusneStanice ispisAutobusneStanice = new IspisAutobusneStanice();
            //Hide();
            ispisAutobusneStanice.ShowDialog();
            //Close();
        }
        private void bntIspisVozila_Click(object sender, EventArgs e)
        {
            IspisVoznogParka ispisVoznogParka = new IspisVoznogParka();
            //Hide();
            ispisVoznogParka.ShowDialog();
            //Close();
        }
        private void btnVozniRed_Click(object sender, EventArgs e)
        {
            FrmVozniRed frmVozniRed = new FrmVozniRed();
            //Hide();
            frmVozniRed.ShowDialog();
            //Close();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Frmlogin frmlogin = new Frmlogin();
            Hide();
            frmlogin.ShowDialog();
            Close();
        }
        private void btnIspisReda_Click_1(object sender, EventArgs e)
        {
            IspisVoznogReda ispisVoznogReda = new IspisVoznogReda();
            //Hide();
            ispisVoznogReda.ShowDialog();
            //Close();
        }
    }
}