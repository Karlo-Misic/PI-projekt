using DBLayer;
using DSUGP.Models;
using DSUGP.Repozitoriji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSUGP
{
    public partial class IspisVoznogReda : Form
    {
        public IspisVoznogReda()
        {
            InitializeComponent();
        }

        private void IspisVoznogReda_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
            PrikaziVozniRed();
            dtgvVozniRed.Columns["Id_linije"].Visible = false;
            dtgvVozniRed.Columns["Id_vozni_park"].Visible = false;
            dtgvVozniRed.Columns["Id_stanice"].Visible = false;
        }
        private void PrikaziVozniRed()
        {
            List<vozniRed> voznired = Repozitoriji.VozniRed.GetVozniRed();
            dtgvVozniRed.DataSource = voznired;
        }
        private void btnIspis_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dtgvVozniRed.Width, this.dtgvVozniRed.Height);
            dtgvVozniRed.DrawToBitmap(bm, new Rectangle(0, 0, this.dtgvVozniRed.Width, this.dtgvVozniRed.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);

            int cellHeight = 20;

            int yPos = 50;

            int maxTableWidth = e.MarginBounds.Width;

            int cellWidth = maxTableWidth / dtgvVozniRed.Columns.Count;

            e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, yPos, e.MarginBounds.Right, yPos);
            yPos += 5;

            for (int i = 0; i < dtgvVozniRed.Columns.Count; i++)
            {
                e.Graphics.DrawString(dtgvVozniRed.Columns[i].HeaderText, boldFont, Brushes.Black, new Rectangle(e.MarginBounds.Left + i * cellWidth, yPos, cellWidth, cellHeight), StringFormat.GenericDefault);
                e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left + i * cellWidth, yPos + cellHeight, e.MarginBounds.Left + (i + 1) * cellWidth, yPos + cellHeight);
            }

            yPos += cellHeight + 5;

            for (int i = 0; i < dtgvVozniRed.Rows.Count; i++)
            {
                int maxHeight = 0;

                for (int j = 0; j < dtgvVozniRed.Columns.Count; j++)
                {
                    string cellText = dtgvVozniRed.Rows[i].Cells[j].Value?.ToString() ?? "";

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

                if (i != dtgvVozniRed.Rows.Count - 1)
                {
                    e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, yPos, e.MarginBounds.Right, yPos);
                }
            }
            for (int i = 0; i <= dtgvVozniRed.Columns.Count; i++)
            {
                e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left + i * cellWidth, 50, e.MarginBounds.Left + i * cellWidth, yPos);
            }
        }
    }
}