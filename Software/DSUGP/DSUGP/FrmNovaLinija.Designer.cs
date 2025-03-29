namespace DSUGP
{
    partial class FrmNovaLinija
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPotvrdi_promjene = new System.Windows.Forms.Button();
            this.txtNaziv_linije = new System.Windows.Forms.TextBox();
            this.txtPrva_stanica = new System.Windows.Forms.TextBox();
            this.txtZadnja_stanica = new System.Windows.Forms.TextBox();
            this.dateVrijeme_pocetka = new System.Windows.Forms.DateTimePicker();
            this.dateVrijeme_zavrsetka = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Definiranje vozne linije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv vozne linije:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prva stanica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zadnja stanica:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vrijeme početka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vrijeme završetka:";
            // 
            // btnPotvrdi_promjene
            // 
            this.btnPotvrdi_promjene.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi_promjene.Location = new System.Drawing.Point(440, 390);
            this.btnPotvrdi_promjene.Name = "btnPotvrdi_promjene";
            this.btnPotvrdi_promjene.Size = new System.Drawing.Size(305, 45);
            this.btnPotvrdi_promjene.TabIndex = 6;
            this.btnPotvrdi_promjene.Text = "Potvrdi promjene";
            this.btnPotvrdi_promjene.UseVisualStyleBackColor = true;
            this.btnPotvrdi_promjene.Click += new System.EventHandler(this.btnPotvrdi_promjene_Click);
            // 
            // txtNaziv_linije
            // 
            this.txtNaziv_linije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv_linije.Location = new System.Drawing.Point(32, 140);
            this.txtNaziv_linije.Name = "txtNaziv_linije";
            this.txtNaziv_linije.Size = new System.Drawing.Size(213, 30);
            this.txtNaziv_linije.TabIndex = 7;
            // 
            // txtPrva_stanica
            // 
            this.txtPrva_stanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrva_stanica.Location = new System.Drawing.Point(32, 266);
            this.txtPrva_stanica.Name = "txtPrva_stanica";
            this.txtPrva_stanica.Size = new System.Drawing.Size(213, 30);
            this.txtPrva_stanica.TabIndex = 8;
            // 
            // txtZadnja_stanica
            // 
            this.txtZadnja_stanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZadnja_stanica.Location = new System.Drawing.Point(32, 379);
            this.txtZadnja_stanica.Name = "txtZadnja_stanica";
            this.txtZadnja_stanica.Size = new System.Drawing.Size(213, 30);
            this.txtZadnja_stanica.TabIndex = 9;
            // 
            // dateVrijeme_pocetka
            // 
            this.dateVrijeme_pocetka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVrijeme_pocetka.Location = new System.Drawing.Point(435, 140);
            this.dateVrijeme_pocetka.Name = "dateVrijeme_pocetka";
            this.dateVrijeme_pocetka.Size = new System.Drawing.Size(200, 30);
            this.dateVrijeme_pocetka.TabIndex = 11;
            // 
            // dateVrijeme_zavrsetka
            // 
            this.dateVrijeme_zavrsetka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVrijeme_zavrsetka.Location = new System.Drawing.Point(435, 266);
            this.dateVrijeme_zavrsetka.Name = "dateVrijeme_zavrsetka";
            this.dateVrijeme_zavrsetka.Size = new System.Drawing.Size(200, 30);
            this.dateVrijeme_zavrsetka.TabIndex = 12;
            // 
            // FrmNovaLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateVrijeme_zavrsetka);
            this.Controls.Add(this.dateVrijeme_pocetka);
            this.Controls.Add(this.txtZadnja_stanica);
            this.Controls.Add(this.txtPrva_stanica);
            this.Controls.Add(this.txtNaziv_linije);
            this.Controls.Add(this.btnPotvrdi_promjene);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNovaLinija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNovaLinija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPotvrdi_promjene;
        private System.Windows.Forms.TextBox txtNaziv_linije;
        private System.Windows.Forms.TextBox txtPrva_stanica;
        private System.Windows.Forms.TextBox txtZadnja_stanica;
        private System.Windows.Forms.DateTimePicker dateVrijeme_pocetka;
        private System.Windows.Forms.DateTimePicker dateVrijeme_zavrsetka;
    }
}