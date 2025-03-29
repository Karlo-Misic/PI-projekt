using DBLayer;
using DSUGP.Models;
using DSUGP.Repozitoriji;
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
    public partial class FrmDodajVozniRed : Form
    {
        public event EventHandler DataAdded;
        public FrmDodajVozniRed()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DialogResult potvrda = MessageBox.Show("Jeste li sigurni da želite spremiti?", "Potvrda spremanja", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (potvrda == DialogResult.Yes)
            {
                // Kod za spremanje
                //MessageBox.Show("Podaci su spremljeni.");
                DataAdded?.Invoke(this, EventArgs.Empty);

                string Naziv_stanice = cbNaziv_stanice.Text;
                string Naziv_linije = cbNaziv_linije.Text;
                string Naziv_vozila = cbNaziv_Vozila.Text;

                vozniRed novivoznired = new vozniRed();
                novivoznired.Naziv_stanice = Naziv_stanice;
                novivoznired.Naziv_linije = Naziv_linije;
                novivoznired.Naziv_vozila = Naziv_vozila;

                // Provjeri jesu li uneseni podaci ispravni
                if (!string.IsNullOrEmpty(Naziv_stanice) && !string.IsNullOrEmpty(Naziv_linije) && !string.IsNullOrEmpty(Naziv_vozila))
                {
                    if (Repozitoriji.VozniRed.DodajVozniRed(novivoznired))
                    {
                        MessageBox.Show("Vozni red uspješno dodan u bazu podataka.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataAdded?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Greška prilikom dodavanja voznog reda u bazu podataka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void cbNaziv_stanice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNazivStanice = cbNaziv_stanice.SelectedItem?.ToString();
            if (selectedNazivStanice != null)
            {
                //
            }
        }
        private void FrmDodajVozniRed_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
            PrikaziStanice();
            PrikaziLinije();
            PrikaziVozniPark();
        }
        private void PrikaziStanice()
        {
            List<AutobusnaStanica> autobusneStanice = AutobusneStanice.GetAutobusneStanice();

            foreach (AutobusnaStanica stanica in autobusneStanice)
            {
                cbNaziv_stanice.Items.Add(stanica.Naziv_stanice);
            }
        }
        private void cbNaziv_linije_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNazivLinije = cbNaziv_linije.SelectedItem?.ToString();
            if (selectedNazivLinije != null)
            {
                //
            }
        }
        private void PrikaziLinije()
        {
            List<VoznaLinija> voznalinije = VozneLinije.GetVozneLinije();
            foreach (VoznaLinija linija in voznalinije)
            {
                cbNaziv_linije.Items.Add(linija.Naziv_linije);
            }
        }
        private void cbNaziv_Vozila_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNazivVozila = cbNaziv_Vozila.SelectedItem?.ToString();
            if (selectedNazivVozila != null)
            {
                //
            }
        }
        private void PrikaziVozniPark()
        {
            List<vozniPark> vozniParkovi = VozniPark.GetVozniPark();
            foreach (vozniPark vozniPark in vozniParkovi)
            {
                cbNaziv_Vozila.Items.Add(vozniPark.Naziv_vozila);
            }
        }
    }
}