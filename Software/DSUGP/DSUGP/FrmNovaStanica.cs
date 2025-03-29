using DSUGP.Models;
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
    public partial class FrmNovaStanica : Form
    {
        public event EventHandler DataAdded;
        public FrmNovaStanica()
        {
            InitializeComponent();
        }

        private void btnDodajStanicu_Click(object sender, EventArgs e)
        {
            DialogResult potvrda = MessageBox.Show("Jeste li sigurni da želite spremiti?", "Potvrda spremanja", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (potvrda == DialogResult.Yes)
            {
                // Kod za spremanje
                //MessageBox.Show("Podaci su spremljeni.");
                DataAdded?.Invoke(this, EventArgs.Empty);

                string Naziv_stanice = textNaziv_stanice.Text;
                string Broj_stanice = textBroj_stanice.Text;

                AutobusnaStanica noviAutobusnaStanica = new AutobusnaStanica();
                noviAutobusnaStanica.Naziv_stanice = Naziv_stanice;
                noviAutobusnaStanica.Broj_stanice = Broj_stanice;

                if (!string.IsNullOrEmpty(Naziv_stanice) && !string.IsNullOrEmpty(Broj_stanice))
                {
                    if (Repozitoriji.AutobusneStanice.DodajAutobusnuStanicu(noviAutobusnaStanica))
                    {
                        MessageBox.Show("Autobusna stanica uspješno dodana u bazu podataka.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataAdded?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Greška prilikom dodavanja autobusne stanice u bazu podataka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo unesite sve podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (potvrda == DialogResult.No)
            {
                MessageBox.Show("Spremanje je otkazano.");
            }
        }
    }
}