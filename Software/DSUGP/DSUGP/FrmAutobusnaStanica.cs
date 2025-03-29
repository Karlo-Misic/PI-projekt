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
    public partial class FrmAutobusnaStanica : Form
    {
        public FrmAutobusnaStanica()
        {
            InitializeComponent();
        }
        private void FrmAutobusnaStanica_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
            PrikaziAutobusneStanice();
            dgvAutobusne_stanice.SelectionChanged += dgvAutobusne_stanice_SelectionChanged;
            dgvAutobusne_stanice_SelectionChanged(null, EventArgs.Empty);
        }
        private void PrikaziAutobusneStanice()
        {
            List<AutobusnaStanica> autobusnaStanica = Repozitoriji.AutobusneStanice.GetAutobusneStanice();
            dgvAutobusne_stanice.DataSource = autobusnaStanica;
        }
        private void btnDodajNovuStanicu_Click(object sender, EventArgs e)
        {
            FrmNovaStanica frmNovaStanica = new FrmNovaStanica();
            frmNovaStanica.DataAdded += FrmNovaStanica_DataAdded;
            frmNovaStanica.ShowDialog();
        }
        private void FrmNovaStanica_DataAdded(object sender, EventArgs e)
        {
            PrikaziAutobusneStanice();
        }
        private void btnObrisiStanicu_Click(object sender, EventArgs e)
        {
            if (dgvAutobusne_stanice.SelectedRows.Count > 0)
            {
                int Id_stanice = Convert.ToInt32(dgvAutobusne_stanice.SelectedRows[0].Cells["Id_stanice"].Value);

                // Potvrda brisanja
                DialogResult result = MessageBox.Show("Jeste li sigurni da želite izbrisati ovou autobusnu stanicu?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Izvršavanje brisanja u bazi podataka
                    bool success = Repozitoriji.AutobusneStanice.IzbrisiAutobusnuStanicu(Id_stanice);

                    if (Id_stanice <= 0)
                    {
                        MessageBox.Show("Nevažeći Id stanice.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (success)
                    {
                        MessageBox.Show("Autobusna stanica uspješno izbrisana.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PrikaziAutobusneStanice();
                        dgvAutobusne_stanice.Refresh();
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
            string stanica = txtStanicaPretraga.Text;

            if (!string.IsNullOrEmpty(stanica))
            {
                AutobusnaStanica trazenaStanica = Repozitoriji.AutobusneStanice.PretraziAutobusneStanice(stanica);

                if (trazenaStanica != null)
                {
                    MessageBox.Show($"Pronađena stanica:\nId_stanice: {trazenaStanica.Id_stanice}\nNaziv_stanice: {trazenaStanica.Naziv_stanice}\nBroj_stanice: {trazenaStanica.Broj_stanice}", "Pretraga uspješna", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void dgvAutobusne_stanice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAutobusne_stanice.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAutobusne_stanice.SelectedRows[0];

                string Naziv_stanice = selectedRow.Cells["Naziv_stanice"].Value.ToString();
                string Broj_stanice = selectedRow.Cells["Broj_stanice"].Value.ToString();

                // Postavljanje podataka u TextBox-ove
                textNaziv_stanice.Text = Naziv_stanice;
                textBroj_stanice.Text = Broj_stanice;
            }
        }
        private void btnDodajStanicu_Click(object sender, EventArgs e)
        {
            if (dgvAutobusne_stanice.SelectedRows.Count > 0)
            {
                int Id_stanice = Convert.ToInt32(dgvAutobusne_stanice.SelectedRows[0].Cells["Id_stanice"].Value);
                string Naziv_stanice = textNaziv_stanice.Text;
                string Broj_stanice = textBroj_stanice.Text;

                AutobusnaStanica updatedStanica = new AutobusnaStanica
                {
                    Id_stanice = Id_stanice,
                    Naziv_stanice = Naziv_stanice,
                    Broj_stanice = Broj_stanice
                };

                bool success = Repozitoriji.AutobusneStanice.AzurirajAutobusnuStanicu(updatedStanica);

                if (success)
                {
                    MessageBox.Show("Autobusna stanica uspješno ažurirana.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrikaziAutobusneStanice();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške prilikom ažuriranja autobusne stanice.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nije odabrana autobusna stanica za ažuriranje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}