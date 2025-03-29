using DBLayer;
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
    public partial class FrmVozniPark : Form
    {
        public FrmVozniPark()
        {
            InitializeComponent();
        }
        private void FrmVozniPark_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
            PrikaziVozniPark();
            dtgvVozniPark.SelectionChanged += dtgvVozniPark_SelectionChanged;
            dtgvVozniPark_SelectionChanged(null, EventArgs.Empty);
        }
        private void FrmNovoVozilo_DataAdded(object sender, EventArgs e)
        {
            PrikaziVozniPark();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmNovoVozilo frmNovoVozilo = new FrmNovoVozilo();
            frmNovoVozilo.DataAdded += FrmNovoVozilo_DataAdded;
            frmNovoVozilo.ShowDialog();
        }
        private void PrikaziVozniPark()
        {
            List<vozniPark> voznipark = Repozitoriji.VozniPark.GetVozniPark();
            dtgvVozniPark.DataSource = voznipark;
        }
        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (dtgvVozniPark.SelectedRows.Count > 0)
            {
                int Id_vozni_park = Convert.ToInt32(dtgvVozniPark.SelectedRows[0].Cells["Id_vozni_park"].Value);

                // Potvrda brisanja
                DialogResult result = MessageBox.Show("Jeste li sigurni da želite izbrisati ovo vozilo?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Izvršavanje brisanja u bazi podataka
                    bool success = Repozitoriji.VozniPark.IzbrisiVozniPark(Id_vozni_park);

                    if (Id_vozni_park <= 0)
                    {
                        MessageBox.Show("Nevažeći Id voznog parka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (success)
                    {
                        MessageBox.Show("Vozilo uspješno izbrisana.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PrikaziVozniPark();
                        dtgvVozniPark.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške prilikom brisanja vozila.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nije odabrano vozilo za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string tablica = txtBrojTablicePretraga.Text;

            if (!string.IsNullOrEmpty(tablica))
            {
                vozniPark trazenaTablica = Repozitoriji.VozniPark.PretraziVozniPark(tablica);

                if (trazenaTablica != null)
                {
                    MessageBox.Show($"Pronađeno vozilo:\nId_vozni_park: {trazenaTablica.Id_vozni_park}\nNaziv_vozila: {trazenaTablica.Naziv_vozila}\nBroj_tablice: {trazenaTablica.Broj_tablice}\nBroj_mjesta: {trazenaTablica.Broj_mjesta}", "Pretraga uspješna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vozilo nije pronađen.", "Pretraga neuspješna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Molimo unesite naziv stanice za pretragu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dtgvVozniPark_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvVozniPark.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvVozniPark.SelectedRows[0];

                string Naziv_vozila = selectedRow.Cells["Naziv_vozila"].Value.ToString();
                string Broj_tablice = selectedRow.Cells["Broj_tablice"].Value.ToString();
                string Broj_mjesta = selectedRow.Cells["Broj_mjesta"].Value.ToString();

                // Postavljanje podataka u TextBox-ove
                txtNaziv_vozila.Text = Naziv_vozila;
                txtBroj_tablice.Text = Broj_tablice;
                txtBroj_mjesta.Text = Broj_mjesta;
            }
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dtgvVozniPark.SelectedRows.Count > 0)
            {
                int Id_vozni_park = Convert.ToInt32(dtgvVozniPark.SelectedRows[0].Cells["Id_vozni_park"].Value);

                // Retrieve updated values from the TextBoxes
                string Naziv_vozila = txtNaziv_vozila.Text;
                string Broj_tablice = txtBroj_tablice.Text;
                string Broj_mjesta = txtBroj_mjesta.Text;

                vozniPark updatedPark = new vozniPark
                {
                    Id_vozni_park = Id_vozni_park,
                    Naziv_vozila = Naziv_vozila,
                    Broj_tablice = Broj_tablice,
                    Broj_mjesta = Broj_mjesta,
                };

                bool success = Repozitoriji.VozniPark.AzurirajVozniPark(Id_vozni_park, updatedPark);

                if (success)
                {
                    MessageBox.Show("Vozna linija uspješno ažurirana.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrikaziVozniPark();
                    dtgvVozniPark.DataSource = null;
                    dtgvVozniPark.DataSource = Repozitoriji.VozniPark.GetVozniPark();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške prilikom ažuriranja vozne linije.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nije odabrana vozna linija za ažuriranje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}