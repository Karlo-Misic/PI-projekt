namespace DSUGP
{
    partial class FrmNovaStanica
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodajStanicu = new System.Windows.Forms.Button();
            this.textBroj_stanice = new System.Windows.Forms.TextBox();
            this.textNaziv_stanice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "Definiranje autobusne stanice";
            // 
            // btnDodajStanicu
            // 
            this.btnDodajStanicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStanicu.Location = new System.Drawing.Point(89, 284);
            this.btnDodajStanicu.Name = "btnDodajStanicu";
            this.btnDodajStanicu.Size = new System.Drawing.Size(341, 45);
            this.btnDodajStanicu.TabIndex = 10;
            this.btnDodajStanicu.Text = "Dodaj novu stanicu";
            this.btnDodajStanicu.UseVisualStyleBackColor = true;
            this.btnDodajStanicu.Click += new System.EventHandler(this.btnDodajStanicu_Click);
            // 
            // textBroj_stanice
            // 
            this.textBroj_stanice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBroj_stanice.Location = new System.Drawing.Point(256, 196);
            this.textBroj_stanice.Name = "textBroj_stanice";
            this.textBroj_stanice.Size = new System.Drawing.Size(174, 30);
            this.textBroj_stanice.TabIndex = 9;
            // 
            // textNaziv_stanice
            // 
            this.textNaziv_stanice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNaziv_stanice.Location = new System.Drawing.Point(256, 119);
            this.textNaziv_stanice.Name = "textNaziv_stanice";
            this.textNaziv_stanice.Size = new System.Drawing.Size(174, 30);
            this.textNaziv_stanice.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Broj stanice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv stanice:";
            // 
            // FrmNovaStanica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodajStanicu);
            this.Controls.Add(this.textBroj_stanice);
            this.Controls.Add(this.textNaziv_stanice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNovaStanica";
            this.Text = "FrmNovaStanica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajStanicu;
        private System.Windows.Forms.TextBox textBroj_stanice;
        private System.Windows.Forms.TextBox textNaziv_stanice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}