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
    public partial class FrmNovoVozilo : Form
    {
        public event EventHandler DataAdded;
        public FrmNovoVozilo()
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

                string NazivVozila = txtNazivVozila.Text;
                string BrojTablice = txtBrojTablice.Text;
                string BrojMjesta = txtBrojMjesta.Text;

                vozniPark novivoznipark = new vozniPark();
                novivoznipark.Naziv_vozila = NazivVozila;
                novivoznipark.Broj_tablice = BrojTablice;
                novivoznipark.Broj_mjesta = BrojMjesta;

                if (!string.IsNullOrEmpty(NazivVozila) && !string.IsNullOrEmpty(BrojTablice) && !string.IsNullOrEmpty(BrojMjesta))
                {
                    if (Repozitoriji.VozniPark.DodajVozniPark(novivoznipark))
                    {
                        MessageBox.Show("Vozilo uspješno dodano u bazu podataka.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataAdded?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Greška prilikom dodavanja vozila u bazu podataka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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