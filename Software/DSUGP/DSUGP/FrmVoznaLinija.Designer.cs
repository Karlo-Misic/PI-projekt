namespace DSUGP
{
    partial class FrmVoznaLinija
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvVozne_linije = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtNazivLinijePretraga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateVrijeme_zavrsetka = new System.Windows.Forms.DateTimePicker();
            this.dateVrijeme_pocetka = new System.Windows.Forms.DateTimePicker();
            this.txtZadnja_stanica = new System.Windows.Forms.TextBox();
            this.txtPrva_stanica = new System.Windows.Forms.TextBox();
            this.txtNaziv_linije = new System.Windows.Forms.TextBox();
            this.btnPotvrdi_promjene = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozne_linije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vozne linije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista postojećih voznih linija:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(700, 398);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(320, 45);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj novu voznu liniju";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvVozne_linije
            // 
            this.dgvVozne_linije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozne_linije.Location = new System.Drawing.Point(46, 114);
            this.dgvVozne_linije.Name = "dgvVozne_linije";
            this.dgvVozne_linije.RowHeadersWidth = 62;
            this.dgvVozne_linije.RowTemplate.Height = 28;
            this.dgvVozne_linije.Size = new System.Drawing.Size(996, 245);
            this.dgvVozne_linije.TabIndex = 4;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(83, 398);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(320, 45);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obriši voznu liniju";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(467, 1004);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(150, 45);
            this.btnPretrazi.TabIndex = 21;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtNazivLinijePretraga
            // 
            this.txtNazivLinijePretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivLinijePretraga.Location = new System.Drawing.Point(540, 922);
            this.txtNazivLinijePretraga.Name = "txtNazivLinijePretraga";
            this.txtNazivLinijePretraga.Size = new System.Drawing.Size(202, 30);
            this.txtNazivLinijePretraga.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 926);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "Naziv linije:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 853);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pretraživanje vozne linije:";
            // 
            // dateVrijeme_zavrsetka
            // 
            this.dateVrijeme_zavrsetka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVrijeme_zavrsetka.Location = new System.Drawing.Point(638, 645);
            this.dateVrijeme_zavrsetka.Name = "dateVrijeme_zavrsetka";
            this.dateVrijeme_zavrsetka.Size = new System.Drawing.Size(200, 30);
            this.dateVrijeme_zavrsetka.TabIndex = 32;
            // 
            // dateVrijeme_pocetka
            // 
            this.dateVrijeme_pocetka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVrijeme_pocetka.Location = new System.Drawing.Point(638, 519);
            this.dateVrijeme_pocetka.Name = "dateVrijeme_pocetka";
            this.dateVrijeme_pocetka.Size = new System.Drawing.Size(200, 30);
            this.dateVrijeme_pocetka.TabIndex = 31;
            // 
            // txtZadnja_stanica
            // 
            this.txtZadnja_stanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZadnja_stanica.Location = new System.Drawing.Point(235, 758);
            this.txtZadnja_stanica.Name = "txtZadnja_stanica";
            this.txtZadnja_stanica.Size = new System.Drawing.Size(213, 30);
            this.txtZadnja_stanica.TabIndex = 30;
            // 
            // txtPrva_stanica
            // 
            this.txtPrva_stanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrva_stanica.Location = new System.Drawing.Point(235, 645);
            this.txtPrva_stanica.Name = "txtPrva_stanica";
            this.txtPrva_stanica.Size = new System.Drawing.Size(213, 30);
            this.txtPrva_stanica.TabIndex = 29;
            // 
            // txtNaziv_linije
            // 
            this.txtNaziv_linije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv_linije.Location = new System.Drawing.Point(235, 519);
            this.txtNaziv_linije.Name = "txtNaziv_linije";
            this.txtNaziv_linije.Size = new System.Drawing.Size(213, 30);
            this.txtNaziv_linije.TabIndex = 28;
            // 
            // btnPotvrdi_promjene
            // 
            this.btnPotvrdi_promjene.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi_promjene.Location = new System.Drawing.Point(767, 769);
            this.btnPotvrdi_promjene.Name = "btnPotvrdi_promjene";
            this.btnPotvrdi_promjene.Size = new System.Drawing.Size(178, 45);
            this.btnPotvrdi_promjene.TabIndex = 27;
            this.btnPotvrdi_promjene.Text = "Ažuriraj";
            this.btnPotvrdi_promjene.UseVisualStyleBackColor = true;
            this.btnPotvrdi_promjene.Click += new System.EventHandler(this.btnPotvrdi_promjene_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 601);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Vrijeme završetka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(634, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "Vrijeme početka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 711);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Zadnja stanica:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(231, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 26);
            this.label8.TabIndex = 23;
            this.label8.Text = "Prva stanica:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(231, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 26);
            this.label9.TabIndex = 22;
            this.label9.Text = "Naziv vozne linije:";
            // 
            // FrmVoznaLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 1113);
            this.Controls.Add(this.dateVrijeme_zavrsetka);
            this.Controls.Add(this.dateVrijeme_pocetka);
            this.Controls.Add(this.txtZadnja_stanica);
            this.Controls.Add(this.txtPrva_stanica);
            this.Controls.Add(this.txtNaziv_linije);
            this.Controls.Add(this.btnPotvrdi_promjene);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtNazivLinijePretraga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvVozne_linije);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVoznaLinija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVoznaLinija";
            this.Load += new System.EventHandler(this.FrmVoznaLinija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozne_linije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvVozne_linije;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtNazivLinijePretraga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateVrijeme_zavrsetka;
        private System.Windows.Forms.DateTimePicker dateVrijeme_pocetka;
        private System.Windows.Forms.TextBox txtZadnja_stanica;
        private System.Windows.Forms.TextBox txtPrva_stanica;
        private System.Windows.Forms.TextBox txtNaziv_linije;
        private System.Windows.Forms.Button btnPotvrdi_promjene;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}