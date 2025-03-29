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
using static System.Windows.Forms.LinkLabel;

namespace DSUGP
{
    public partial class FrmDodajZaposlenika : Form
    {
        public FrmDodajZaposlenika()
        {
            InitializeComponent();
            dgvZaposlenici.SelectionChanged += dgvZaposlenici_SelectionChanged;
        }
        private void btnDodajNovogZaposlenika_Click(object sender, EventArgs e)
        {
            string Ime = txtIme.Text;
            string Prezime = txtPrezime.Text;
            string KorIme = txtKorIme.Text;
            string Lozinka = txtLozinka.Text;

            Zaposlenik noviZaposlenik = new Zaposlenik();
            noviZaposlenik.KorIme = KorIme;
            noviZaposlenik.Lozinka = Lozinka;
            noviZaposlenik.Ime = Ime;
            noviZaposlenik.Prezime = Prezime;

            if (!string.IsNullOrEmpty(KorIme) && !string.IsNullOrEmpty(Lozinka) && !string.IsNullOrEmpty(Ime) && !string.IsNullOrEmpty(Prezime))
            {
                if (Repozitoriji.Zaposlenici.DodajZaposlenika(noviZaposlenik))
                {
                    MessageBox.Show("Zaposlenik uspješno dodan u bazu podataka.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrikaziZaposlenike();
                }
                else
                {
                    MessageBox.Show("Greška prilikom dodavanja zaposlenika u bazu podataka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Molimo unesite sve podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmDodajZaposlenika_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
            PrikaziZaposlenike();
            dgvZaposlenici.SelectionChanged += dgvZaposlenici_SelectionChanged;
            dgvZaposlenici_SelectionChanged(null, EventArgs.Empty);
        }
        private void PrikaziZaposlenike()
        {
            List<Zaposlenik> zaposlenik = Zaposlenici.GetZaposlenik();
            dgvZaposlenici.DataSource = zaposlenik;
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.SelectedRows.Count > 0)
            {
                int Id_zaposlenik = Convert.ToInt32(dgvZaposlenici.SelectedRows[0].Cells["Id_zaposlenik"].Value);

                DialogResult result = MessageBox.Show("Jeste li sigurni da želite izbrisati ovog zaposlenika?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = Repozitoriji.Zaposlenici.IzbrisiZaposlenika(Id_zaposlenik);

                    if (Id_zaposlenik <= 0)
                    {
                        MessageBox.Show("Nevažeći Id_zaposlenika.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (success)
                    {
                        PrikaziZaposlenike();
                        dgvZaposlenici.Refresh();

                        MessageBox.Show("Zaposlenik uspješno izbrisan.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške prilikom brisanja zaposlenika.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nije odabran zaposlenik za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvZaposlenici_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvZaposlenici.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvZaposlenici.SelectedRows[0];

                string Ime = selectedRow.Cells["Ime"].Value.ToString();
                string Prezime = selectedRow.Cells["Prezime"].Value.ToString();
                string KorIme = selectedRow.Cells["KorIme"].Value.ToString();
                string Lozinka = selectedRow.Cells["Lozinka"].Value.ToString();

                txtIme.Text = Ime;
                txtPrezime.Text = Prezime;
                txtKorIme.Text = KorIme;
                txtLozinka.Text = Lozinka;
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);

            int cellHeight = 20;

            int yPos = 50;

            int maxTableWidth = e.MarginBounds.Width;

            int cellWidth = maxTableWidth / dgvZaposlenici.Columns.Count;

            e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, yPos, e.MarginBounds.Right, yPos);
            yPos += 5;

            for (int i = 0; i < dgvZaposlenici.Columns.Count; i++)
            {
                e.Graphics.DrawString(dgvZaposlenici.Columns[i].HeaderText, boldFont, Brushes.Black, new Rectangle(e.MarginBounds.Left + i * cellWidth, yPos, cellWidth, cellHeight), StringFormat.GenericDefault);
                e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left + i * cellWidth, yPos + cellHeight, e.MarginBounds.Left + (i + 1) * cellWidth, yPos + cellHeight);
            }

            yPos += cellHeight + 5;

            for (int i = 0; i < dgvZaposlenici.Rows.Count; i++)
            {
                int maxHeight = 0;

                for (int j = 0; j < dgvZaposlenici.Columns.Count; j++)
                {
                    string cellText = dgvZaposlenici.Rows[i].Cells[j].Value?.ToString() ?? "";

                    if (!string.IsNullOrWhiteSpace(cellText))
                    {
                        int lines = (int)Math.Ceiling(e.Graphics.MeasureString(cellText, font, cellWidth).Height / cellHeight);
                        int cellHeightWithLines = lines * cellHeight;

                        if (cellHeightWithLines > maxHeight)
                        {
                            maxHeight = cellHeightWithLines;
                        }

                        e.Graphics.DrawString(cellText, font, Brushes.Black, new Rectangle(e.MarginBounds.Left + j * cellWidth, yPos, cellWidth, cellHeightWithLines), StringFormat.GenericDefault);
                    }
                }

                e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, yPos + maxHeight, e.MarginBounds.Right, yPos + maxHeight);

                yPos += maxHeight;

                if (i != dgvZaposlenici.Rows.Count - 1)
                {
                    e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, yPos, e.MarginBounds.Right, yPos);
                }
            }
            for (int i = 0; i <= dgvZaposlenici.Columns.Count; i++)
            {
                e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left + i * cellWidth, 50, e.MarginBounds.Left + i * cellWidth, yPos);
            }
        }
        private void btnIspisi_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorImePretraga.Text;

            if (!string.IsNullOrEmpty(korisnickoIme))
            {
                Zaposlenik trazeniZaposlenik = Repozitoriji.Zaposlenici.PretraziZaposlenika(korisnickoIme);

                if (trazeniZaposlenik != null)
                {
                    MessageBox.Show($"Pronađen zaposlenik:\nId_zaposlenik: {trazeniZaposlenik.Id_zaposlenik}\nIme: {trazeniZaposlenik.Ime}\nPrezime: {trazeniZaposlenik.Prezime}\nKorisničko ime: {trazeniZaposlenik.KorIme}\nLozinka: {trazeniZaposlenik.Lozinka}", "Pretraga uspješna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Zaposlenik s tim korisničkim imenom nije pronađen.", "Pretraga neuspješna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Molimo unesite korisničko ime za pretragu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}