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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DSUGP
{
    public partial class FrmNovaLinija : Form
    {
        public event EventHandler DataAdded;
        public FrmNovaLinija()
        {
            InitializeComponent();
        }
        private void btnPotvrdi_promjene_Click(object sender, EventArgs e)
        {
            DialogResult potvrda = MessageBox.Show("Jeste li sigurni da želite spremiti?", "Potvrda spremanja", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (potvrda == DialogResult.Yes)
            {
                // Kod za spremanje
                //MessageBox.Show("Podaci su spremljeni.");
                DataAdded?.Invoke(this, EventArgs.Empty);

                string Naziv_linije = txtNaziv_linije.Text;
                string Prva_stanica = txtPrva_stanica.Text;
                string Zadnja_stanica = txtZadnja_stanica.Text;
                string Vrijeme_pocetka = dateVrijeme_pocetka.Text;
                string Vrijeme_zavrsetka = dateVrijeme_zavrsetka.Text;

                VoznaLinija noviVoznaLinija = new VoznaLinija();
                noviVoznaLinija.Naziv_linije = Naziv_linije;
                noviVoznaLinija.Prva_stanica = Prva_stanica;
                noviVoznaLinija.Zadnja_stanica = Zadnja_stanica;
                noviVoznaLinija.Vrijeme_pocetka = Vrijeme_pocetka;
                noviVoznaLinija.Vrijeme_zavrsetka = Vrijeme_zavrsetka;

                if (!string.IsNullOrEmpty(Naziv_linije) && !string.IsNullOrEmpty(Prva_stanica) && !string.IsNullOrEmpty(Zadnja_stanica) && !string.IsNullOrEmpty(Vrijeme_pocetka) && !string.IsNullOrEmpty(Vrijeme_zavrsetka))
                {
                    if (Repozitoriji.VozneLinije.DodajVoznuLiniju(noviVoznaLinija))
                    {
                        MessageBox.Show("Vozna linija uspješno dodana u bazu podataka.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataAdded?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Greška prilikom dodavanja vozne linije u bazu podataka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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