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
    public partial class FrmVozniRed : Form
    {
        public FrmVozniRed()
        {
            InitializeComponent();
        }
        private void FrmVozniRed_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
            PrikaziVozniRed();
            dtgvVozni_red.Columns["Id_linije"].Visible = false;
            dtgvVozni_red.Columns["Id_vozni_park"].Visible = false;
            dtgvVozni_red.Columns["Id_stanice"].Visible = false;
            dtgvVozni_red.SelectionChanged += dtgvVozni_red_SelectionChanged;
            dtgvVozni_red_SelectionChanged(null, EventArgs.Empty);
            PopuniComboBoxStanice();
            PopuniComboBoxLinije();
            PopuniComboBoxVozila();
        }
        private void PrikaziVozniRed()
        {
            List<vozniRed> vozniRed = VozniRed.GetVozniRed();
            dtgvVozni_red.DataSource = vozniRed;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajVozniRed frmDodajVozniRed = new FrmDodajVozniRed();
            frmDodajVozniRed.DataAdded += FrmNoviVozniRed_DataAdded;
            frmDodajVozniRed.ShowDialog();
        }
        private void FrmNoviVozniRed_DataAdded(object sender, EventArgs e)
        {
            PrikaziVozniRed();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dtgvVozni_red.SelectedRows.Count > 0)
            {
                int Id_vozni_red = Convert.ToInt32(dtgvVozni_red.SelectedRows[0].Cells["Id_vozni_red"].Value);

                // Potvrda brisanja
                DialogResult result = MessageBox.Show("Jeste li sigurni da želite izbrisati ovu autobusnu stanicu?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Izvršavanje brisanja u bazi podataka
                    bool success = Repozitoriji.VozniRed.IzbrisiVozniRed(Id_vozni_red);

                    if (Id_vozni_red <= 0)
                    {
                        MessageBox.Show("Nevažeći Id stanice.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (success)
                    {
                        MessageBox.Show("Autobusna stanica uspješno izbrisana.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PrikaziVozniRed();
                        dtgvVozni_red.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške prilikom brisanja autobusne stanice.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nije odabrana autobusna stanica za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdPretraga.Text))
            {
                int red;
                if (int.TryParse(txtIdPretraga.Text, out red))
                {
                    vozniRed trazeniRed = Repozitoriji.VozniRed.PretraziVozniRed(red);

                    if (trazeniRed != null)
                    {
                        MessageBox.Show($"Pronađen vozni red:\nId_vozni_red: {trazeniRed.Id_vozni_red}\nNaziv_stanice: {trazeniRed.Naziv_stanice}\nNaziv linije: {trazeniRed.Naziv_linije}\nNaziv vozila: {trazeniRed.Naziv_vozila}", "Pretraga uspješna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vozni red nije pronađen.", "Pretraga neuspješna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Uneseni tekst nije valjan broj.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Molimo unesite Id voznog reda za pretragu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dtgvVozni_red_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvVozni_red.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvVozni_red.SelectedRows[0];

                // Prenosimo podatke iz odabranog reda u ComboBox-ove
                string Naziv_stanice = selectedRow.Cells["Naziv_stanice"].Value.ToString();
                string Naziv_linije = selectedRow.Cells["Naziv_linije"].Value.ToString();
                string Naziv_vozila = selectedRow.Cells["Naziv_vozila"].Value.ToString();

                // Postavljamo odabrane vrijednosti u ComboBox-ove
                cbNaziv_stanice.Text = Naziv_stanice;
                cbNaziv_linije.Text = Naziv_linije;
                cbNaziv_Vozila.Text = Naziv_vozila;
            }
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dtgvVozni_red.SelectedRows.Count > 0)
            {
                int Id_vozni_red = Convert.ToInt32(dtgvVozni_red.SelectedRows[0].Cells["Id_vozni_red"].Value);

                string Naziv_stanice = cbNaziv_stanice.SelectedValue.ToString();
                string Naziv_linije = cbNaziv_linije.SelectedValue.ToString();
                string Naziv_vozila = cbNaziv_Vozila.SelectedValue.ToString();

                vozniRed updatedRed = new vozniRed
                {
                    Naziv_stanice = Naziv_stanice,
                    Naziv_linije = Naziv_linije,
                    Naziv_vozila = Naziv_vozila,
                };


                bool success = Repozitoriji.VozniRed.AzurirajVozniRed(Id_vozni_red, updatedRed);

                if (success)
                {
                    MessageBox.Show("Vozna linija uspješno ažurirana.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrikaziVozniRed();
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
        private void PopuniComboBoxStanice()
        {
            // Dohvati sve autobusne stanice iz baze podataka
            List<AutobusnaStanica> sveStanice = AutobusneStanice.GetAutobusneStanice();

            // Kreiraj listu naziva stanica
            List<string> naziviStanica = sveStanice.Select(s => s.Naziv_stanice).ToList();

            // Postavi popis naziva stanica u ComboBox
            cbNaziv_stanice.DataSource = naziviStanica;
        }
        private void PopuniComboBoxLinije()
        {
            // Dohvati sve nazive linija iz baze podataka
            List<VoznaLinija> naziviLinija = Repozitoriji.VozneLinije.GetVozneLinije();

            // Postavi nazive linija kao DataSource ComboBox-a
            cbNaziv_linije.DataSource = naziviLinija;
            // Postavi koje polje će se prikazati u ComboBox-u
            cbNaziv_linije.DisplayMember = "Naziv_linije";
            // Postavi koje polje će biti vraćeno kao odabrana vrijednost
            cbNaziv_linije.ValueMember = "Naziv_linije";
        }
        private void PopuniComboBoxVozila()
        {
            // Dohvati sve nazive vozila iz baze podataka
            List<vozniPark> naziviVozila = Repozitoriji.VozniPark.GetVozniPark();

            // Postavi nazive vozila kao DataSource ComboBox-a
            cbNaziv_Vozila.DataSource = naziviVozila;
            // Postavi koje polje će se prikazati u ComboBox-u
            cbNaziv_Vozila.DisplayMember = "Naziv_vozila";
            // Postavi koje polje će biti vraćeno kao odabrana vrijednost
            cbNaziv_Vozila.ValueMember = "Naziv_vozila";
        }
    }
}