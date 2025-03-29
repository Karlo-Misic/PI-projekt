namespace DSUGP
{
    partial class FrmVozniRed
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
            this.dtgvVozni_red = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtIdPretraga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.cbNaziv_Vozila = new System.Windows.Forms.ComboBox();
            this.cbNaziv_linije = new System.Windows.Forms.ComboBox();
            this.cbNaziv_stanice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVozni_red)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvVozni_red
            // 
            this.dtgvVozni_red.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVozni_red.Location = new System.Drawing.Point(52, 88);
            this.dtgvVozni_red.Name = "dtgvVozni_red";
            this.dtgvVozni_red.RowHeadersWidth = 62;
            this.dtgvVozni_red.RowTemplate.Height = 28;
            this.dtgvVozni_red.Size = new System.Drawing.Size(697, 235);
            this.dtgvVozni_red.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(533, 370);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(190, 45);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj vozni red";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(63, 370);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(127, 45);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši vozni red";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vozni redovi";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(337, 1000);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(150, 45);
            this.btnPretrazi.TabIndex = 25;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtIdPretraga
            // 
            this.txtIdPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPretraga.Location = new System.Drawing.Point(405, 922);
            this.txtIdPretraga.Name = "txtIdPretraga";
            this.txtIdPretraga.Size = new System.Drawing.Size(202, 30);
            this.txtIdPretraga.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 922);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "Id vozni red:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 849);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 32);
            this.label6.TabIndex = 22;
            this.label6.Text = "Pretraživanje voznih redova:";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(294, 728);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(199, 45);
            this.btnAzuriraj.TabIndex = 32;
            this.btnAzuriraj.Text = "Ažuriraj vozni red";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // cbNaziv_Vozila
            // 
            this.cbNaziv_Vozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNaziv_Vozila.FormattingEnabled = true;
            this.cbNaziv_Vozila.Location = new System.Drawing.Point(375, 644);
            this.cbNaziv_Vozila.Name = "cbNaziv_Vozila";
            this.cbNaziv_Vozila.Size = new System.Drawing.Size(199, 33);
            this.cbNaziv_Vozila.TabIndex = 31;
            // 
            // cbNaziv_linije
            // 
            this.cbNaziv_linije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNaziv_linije.FormattingEnabled = true;
            this.cbNaziv_linije.Location = new System.Drawing.Point(375, 576);
            this.cbNaziv_linije.Name = "cbNaziv_linije";
            this.cbNaziv_linije.Size = new System.Drawing.Size(199, 33);
            this.cbNaziv_linije.TabIndex = 30;
            // 
            // cbNaziv_stanice
            // 
            this.cbNaziv_stanice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNaziv_stanice.FormattingEnabled = true;
            this.cbNaziv_stanice.Location = new System.Drawing.Point(375, 511);
            this.cbNaziv_stanice.Name = "cbNaziv_stanice";
            this.cbNaziv_stanice.Size = new System.Drawing.Size(199, 33);
            this.cbNaziv_stanice.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Naziv vozila:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Naziv linije:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 26);
            this.label4.TabIndex = 26;
            this.label4.Text = "Naziv stanice:";
            // 
            // FrmVozniRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 1070);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.cbNaziv_Vozila);
            this.Controls.Add(this.cbNaziv_linije);
            this.Controls.Add(this.cbNaziv_stanice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtIdPretraga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtgvVozni_red);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVozniRed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVozniRed";
            this.Load += new System.EventHandler(this.FrmVozniRed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVozni_red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVozni_red;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtIdPretraga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.ComboBox cbNaziv_Vozila;
        private System.Windows.Forms.ComboBox cbNaziv_linije;
        private System.Windows.Forms.ComboBox cbNaziv_stanice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}