namespace DSUGP
{
    partial class FrmVozniPark
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvVozniPark = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtBrojTablicePretraga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.txtNaziv_vozila = new System.Windows.Forms.TextBox();
            this.txtBroj_tablice = new System.Windows.Forms.TextBox();
            this.txtBroj_mjesta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVozniPark)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvVozniPark
            // 
            this.dtgvVozniPark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVozniPark.Location = new System.Drawing.Point(34, 88);
            this.dtgvVozniPark.Name = "dtgvVozniPark";
            this.dtgvVozniPark.RowHeadersWidth = 62;
            this.dtgvVozniPark.RowTemplate.Height = 28;
            this.dtgvVozniPark.Size = new System.Drawing.Size(696, 250);
            this.dtgvVozniPark.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vozni park poduzeća";
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisi.Location = new System.Drawing.Point(52, 374);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(250, 45);
            this.btnIzbrisi.TabIndex = 2;
            this.btnIzbrisi.Text = "Izbriši vozilo";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(458, 374);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(250, 45);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj novo vozilo";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(303, 941);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(150, 45);
            this.btnPretrazi.TabIndex = 25;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtBrojTablicePretraga
            // 
            this.txtBrojTablicePretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojTablicePretraga.Location = new System.Drawing.Point(374, 863);
            this.txtBrojTablicePretraga.Name = "txtBrojTablicePretraga";
            this.txtBrojTablicePretraga.Size = new System.Drawing.Size(202, 30);
            this.txtBrojTablicePretraga.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 863);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "Broj tablice:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 790);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 30);
            this.label6.TabIndex = 22;
            this.label6.Text = "Pretraživanje voznog parka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 599);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 29;
            this.label4.Text = "Broj mjesta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Broj tablice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Naziv vozila:";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(252, 711);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(266, 45);
            this.btnAzuriraj.TabIndex = 26;
            this.btnAzuriraj.Text = "Ažuriraj vozilo";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // txtNaziv_vozila
            // 
            this.txtNaziv_vozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv_vozila.Location = new System.Drawing.Point(374, 457);
            this.txtNaziv_vozila.Name = "txtNaziv_vozila";
            this.txtNaziv_vozila.Size = new System.Drawing.Size(186, 30);
            this.txtNaziv_vozila.TabIndex = 30;
            // 
            // txtBroj_tablice
            // 
            this.txtBroj_tablice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBroj_tablice.Location = new System.Drawing.Point(374, 526);
            this.txtBroj_tablice.Name = "txtBroj_tablice";
            this.txtBroj_tablice.Size = new System.Drawing.Size(186, 30);
            this.txtBroj_tablice.TabIndex = 31;
            // 
            // txtBroj_mjesta
            // 
            this.txtBroj_mjesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBroj_mjesta.Location = new System.Drawing.Point(374, 593);
            this.txtBroj_mjesta.Name = "txtBroj_mjesta";
            this.txtBroj_mjesta.Size = new System.Drawing.Size(186, 30);
            this.txtBroj_mjesta.TabIndex = 32;
            // 
            // FrmVozniPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 1020);
            this.Controls.Add(this.txtBroj_mjesta);
            this.Controls.Add(this.txtBroj_tablice);
            this.Controls.Add(this.txtNaziv_vozila);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtBrojTablicePretraga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvVozniPark);
            this.Name = "FrmVozniPark";
            this.Text = "FrmVozniPark";
            this.Load += new System.EventHandler(this.FrmVozniPark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVozniPark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVozniPark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtBrojTablicePretraga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.TextBox txtNaziv_vozila;
        private System.Windows.Forms.TextBox txtBroj_tablice;
        private System.Windows.Forms.TextBox txtBroj_mjesta;
    }
}