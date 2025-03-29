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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DSUGP
{
    public partial class FrmVoznaLinija : Form
    {
        public FrmVoznaLinija()
        {
            InitializeComponent();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmNovaLinija frmNovaLinija = new FrmNovaLinija();
            frmNovaLinija.DataAdded += FrmNovaLinija_DataAdded;
            frmNovaLinija.ShowDialog();
        }
        private void FrmNovaLinija_DataAdded(object sender, EventArgs e)
        {
            PrikaziVozneLinije();
        }
        private void FrmVoznaLinija_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
            PrikaziVozneLinije();
            // Dodijela metode događaju
            dgvVozne_linije.SelectionChanged += dgvVozne_linije_SelectionChanged;
            dgvVozne_linije_SelectionChanged(null, EventArgs.Empty);
        }
        private void PrikaziVozneLinije()
        {
            List<VoznaLinija> voznaLinija = Repozitoriji.VozneLinije.GetVozneLinije();
            dgvVozne_linije.DataSource = voznaLinija;
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvVozne_linije.SelectedRows.Count > 0)
            {
                int Id_linija = Convert.ToInt32(dgvVozne_linije.SelectedRows[0].Cells["Id_linija"].Value);

                // Potvrda brisanja
                DialogResult result = MessageBox.Show("Jeste li sigurni da želite izbrisati ovou voznu liniju?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Izvršavanje brisanja u bazi podataka
                    bool success = Repozitoriji.VozneLinije.IzbrisiVoznuLiniju(Id_linija);

                    if (Id_linija <= 0)
                    {
                        MessageBox.Show("Nevažeći Id linije.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (success)
                    {
                        MessageBox.Show("Vozna linija uspješno izbrisana.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PrikaziVozneLinije();
                        dgvVozne_linije.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške prilikom brisanja vozne linije.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nije odabrana vozna linija za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            {
                string linija = txtNazivLinijePretraga.Text;

                if (!string.IsNullOrEmpty(linija))
                {
                    VoznaLinija trazenaLinija = Repozitoriji.VozneLinije.PretraziVoznuLiniju(linija);

                    if (trazenaLinija != null)
                    {
                        MessageBox.Show($"Pronađena linija:\nId_linija: {trazenaLinija.Id_linija}\nNaziv_linije: {trazenaLinija.Naziv_linije}\nPrva stanica: {trazenaLinija.Prva_stanica}\nZadnja stanica: {trazenaLinija.Zadnja_stanica}\nVrijeme početka: {trazenaLinija.Vrijeme_pocetka}\nVrijeme završetka: {trazenaLinija.Vrijeme_zavrsetka}", "Pretraga uspješna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Stanica nije pronađen.", "Pretraga neuspješna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Molimo unesite naziv stanice za pretragu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void dgvVozne_linije_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVozne_linije.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvVozne_linije.SelectedRows[0];

                string Naziv_linije = selectedRow.Cells["Naziv_linije"].Value.ToString();
                string Prva_stanica = selectedRow.Cells["Prva_stanica"].Value.ToString();
                string Zadnja_stanica = selectedRow.Cells["Zadnja_stanica"].Value.ToString();
                string Vrijeme_pocetka = selectedRow.Cells["Vrijeme_pocetka"].Value.ToString();
                string Vrijeme_zavrsetka = selectedRow.Cells["Vrijeme_zavrsetka"].Value.ToString();

                // Postavljanje podataka u TextBox-ove
                txtNaziv_linije.Text = Naziv_linije;
                txtPrva_stanica.Text = Prva_stanica;
                txtZadnja_stanica.Text = Zadnja_stanica;
                dateVrijeme_pocetka.Text = Vrijeme_pocetka;
                dateVrijeme_zavrsetka.Text = Vrijeme_zavrsetka;
            }
        }
        private void btnPotvrdi_promjene_Click(object sender, EventArgs e)
        {
            if (dgvVozne_linije.SelectedRows.Count > 0)
            {
                int Id_linija = Convert.ToInt32(dgvVozne_linije.SelectedRows[0].Cells["Id_linija"].Value);

                string Naziv_linije = txtNaziv_linije.Text;
                string Prva_stanica = txtPrva_stanica.Text;
                string Zadnja_stanica = txtZadnja_stanica.Text;
                string Vrijeme_pocetka = dateVrijeme_pocetka.Text;
                string Vrijeme_zavrsetka = dateVrijeme_zavrsetka.Text;

                VoznaLinija updatedLinija = new VoznaLinija
                {
                    Id_linija = Id_linija,
                    Naziv_linije = Naziv_linije,
                    Prva_stanica = Prva_stanica,
                    Zadnja_stanica = Zadnja_stanica,
                    Vrijeme_pocetka = Vrijeme_pocetka,
                    Vrijeme_zavrsetka = Vrijeme_zavrsetka
                };

                bool success = Repozitoriji.VozneLinije.AzurirajVoznuLiniju(updatedLinija);

                if (success)
                {
                    MessageBox.Show("Vozna linija uspješno ažurirana.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrikaziVozneLinije(); // Refresh DataGridView to reflect changes
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