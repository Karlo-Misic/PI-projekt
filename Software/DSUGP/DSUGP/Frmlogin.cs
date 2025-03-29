using DBLayer;
using DSUGP.Models;
using DSUGP.Repozitoriji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DSUGP
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtKorIme.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string korisnickoIme = txtKorIme.Text;
                string lozinka = txtLozinka.Text;
                // Provjeri korisnika s unesenim korisničkim imenom i lozinkom
                if (Zaposlenici.ProvjeriKorisnika(korisnickoIme, lozinka))
                {
                    MessageBox.Show("Dobrodošli!", "Prijavljeni ste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmPocetna frmPocetna = new FrmPocetna();
                    Hide();
                    frmPocetna.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!, Zaposlenik ne postoji u bazi podataka", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Frmlogin_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
        }
        private void PrikaziZaposlenike()
        {
            List<Zaposlenik> zaposlenik = Repozitoriji.Zaposlenici.GetZaposlenik();
        }
        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            FrmDodajZaposlenika frmDodajZaposlenika = new FrmDodajZaposlenika();
            frmDodajZaposlenika.ShowDialog();
        }
    }
}