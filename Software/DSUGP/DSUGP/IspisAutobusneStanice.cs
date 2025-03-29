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
    public partial class IspisAutobusneStanice : Form
    {
        public IspisAutobusneStanice()
        {
            InitializeComponent();
        }
        private void IspisAutobusneStanice_Load(object sender, EventArgs e)
        { 
            DB.SetConfiguration("PI2324_kmisic22_DB", "PI2324_kmisic22_User", "zWe/3M(3");
            PrikaziVozneLinije();
        }
        private void PrikaziVozneLinije()
        {
            List<AutobusnaStanica> autobusnastanica = Repozitoriji.AutobusneStanice.GetAutobusneStanice();
            dtgvAutobusnaStanica.DataSource = autobusnastanica;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);

            int cellHeight = 20;

            int yPos = 50;

            int maxTableWidth = e.MarginBounds.Width;

            int cellWidth = maxTableWidth / dtgvAutobusnaStanica.Columns.Count;

            e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, yPos, e.MarginBounds.Right, yPos);
            yPos += 5;

            for (int i = 0; i < dtgvAutobusnaStanica.Columns.Count; i++)
            {
                e.Graphics.DrawString(dtgvAutobusnaStanica.Columns[i].HeaderText, boldFont, Brushes.Black, new Rectangle(e.MarginBounds.Left + i * cellWidth, yPos, cellWidth, cellHeight), StringFormat.GenericDefault);
                e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left + i * cellWidth, yPos + cellHeight, e.MarginBounds.Left + (i + 1) * cellWidth, yPos + cellHeight);
            }

            yPos += cellHeight + 5;

            for (int i = 0; i < dtgvAutobusnaStanica.Rows.Count; i++)
            {
                int maxHeight = 0;

                for (int j = 0; j < dtgvAutobusnaStanica.Columns.Count; j++)
                {
                    string cellText = dtgvAutobusnaStanica.Rows[i].Cells[j].Value?.ToString() ?? "";

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

                if (i != dtgvAutobusnaStanica.Rows.Count - 1)
                {
                    e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, yPos, e.MarginBounds.Right, yPos);
                }
            }
            for (int i = 0; i <= dtgvAutobusnaStanica.Columns.Count; i++)
            {
                e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left + i * cellWidth, 50, e.MarginBounds.Left + i * cellWidth, yPos);
            }
        }
        private void btnIspis_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}