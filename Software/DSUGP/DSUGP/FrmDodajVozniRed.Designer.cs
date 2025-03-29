namespace DSUGP
{
    partial class FrmDodajVozniRed
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
            this.cbNaziv_stanice = new System.Windows.Forms.ComboBox();
            this.cbNaziv_linije = new System.Windows.Forms.ComboBox();
            this.cbNaziv_Vozila = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv stanice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv linije:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naziv vozila:";
            // 
            // cbNaziv_stanice
            // 
            this.cbNaziv_stanice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNaziv_stanice.FormattingEnabled = true;
            this.cbNaziv_stanice.Location = new System.Drawing.Point(238, 89);
            this.cbNaziv_stanice.Name = "cbNaziv_stanice";
            this.cbNaziv_stanice.Size = new System.Drawing.Size(199, 33);
            this.cbNaziv_stanice.TabIndex = 3;
            this.cbNaziv_stanice.SelectedIndexChanged += new System.EventHandler(this.cbNaziv_stanice_SelectedIndexChanged);
            // 
            // cbNaziv_linije
            // 
            this.cbNaziv_linije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNaziv_linije.FormattingEnabled = true;
            this.cbNaziv_linije.Location = new System.Drawing.Point(238, 154);
            this.cbNaziv_linije.Name = "cbNaziv_linije";
            this.cbNaziv_linije.Size = new System.Drawing.Size(199, 33);
            this.cbNaziv_linije.TabIndex = 4;
            this.cbNaziv_linije.SelectedIndexChanged += new System.EventHandler(this.cbNaziv_linije_SelectedIndexChanged);
            // 
            // cbNaziv_Vozila
            // 
            this.cbNaziv_Vozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNaziv_Vozila.FormattingEnabled = true;
            this.cbNaziv_Vozila.Location = new System.Drawing.Point(238, 222);
            this.cbNaziv_Vozila.Name = "cbNaziv_Vozila";
            this.cbNaziv_Vozila.Size = new System.Drawing.Size(199, 33);
            this.cbNaziv_Vozila.TabIndex = 5;
            this.cbNaziv_Vozila.SelectedIndexChanged += new System.EventHandler(this.cbNaziv_Vozila_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(157, 306);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(199, 60);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj vozni red";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Definiranje voznog reda";
            // 
            // FrmDodajVozniRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 395);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbNaziv_Vozila);
            this.Controls.Add(this.cbNaziv_linije);
            this.Controls.Add(this.cbNaziv_stanice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDodajVozniRed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDodajVozniRed";
            this.Load += new System.EventHandler(this.FrmDodajVozniRed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNaziv_stanice;
        private System.Windows.Forms.ComboBox cbNaziv_linije;
        private System.Windows.Forms.ComboBox cbNaziv_Vozila;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label4;
    }
}