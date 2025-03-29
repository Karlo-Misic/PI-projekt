namespace DSUGP
{
    partial class FrmAutobusnaStanica
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
            this.btnObrisiStanicu = new System.Windows.Forms.Button();
            this.btnDodajNovuStanicu = new System.Windows.Forms.Button();
            this.dgvAutobusne_stanice = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtStanicaPretraga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodajStanicu = new System.Windows.Forms.Button();
            this.textBroj_stanice = new System.Windows.Forms.TextBox();
            this.textNaziv_stanice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutobusne_stanice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiStanicu
            // 
            this.btnObrisiStanicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiStanicu.Location = new System.Drawing.Point(31, 357);
            this.btnObrisiStanicu.Name = "btnObrisiStanicu";
            this.btnObrisiStanicu.Size = new System.Drawing.Size(350, 45);
            this.btnObrisiStanicu.TabIndex = 5;
            this.btnObrisiStanicu.Text = "Obriši autobusnu stanicu";
            this.btnObrisiStanicu.UseVisualStyleBackColor = true;
            this.btnObrisiStanicu.Click += new System.EventHandler(this.btnObrisiStanicu_Click);
            // 
            // btnDodajNovuStanicu
            // 
            this.btnDodajNovuStanicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNovuStanicu.Location = new System.Drawing.Point(413, 357);
            this.btnDodajNovuStanicu.Name = "btnDodajNovuStanicu";
            this.btnDodajNovuStanicu.Size = new System.Drawing.Size(350, 45);
            this.btnDodajNovuStanicu.TabIndex = 4;
            this.btnDodajNovuStanicu.Text = "Dodaj novu autobusnu stanicu";
            this.btnDodajNovuStanicu.UseVisualStyleBackColor = true;
            this.btnDodajNovuStanicu.Click += new System.EventHandler(this.btnDodajNovuStanicu_Click);
            // 
            // dgvAutobusne_stanice
            // 
            this.dgvAutobusne_stanice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutobusne_stanice.Location = new System.Drawing.Point(137, 73);
            this.dgvAutobusne_stanice.Name = "dgvAutobusne_stanice";
            this.dgvAutobusne_stanice.RowHeadersWidth = 62;
            this.dgvAutobusne_stanice.RowTemplate.Height = 28;
            this.dgvAutobusne_stanice.Size = new System.Drawing.Size(547, 250);
            this.dgvAutobusne_stanice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Autobusne stanice";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(232, 913);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(150, 45);
            this.btnPretrazi.TabIndex = 21;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtStanicaPretraga
            // 
            this.txtStanicaPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStanicaPretraga.Location = new System.Drawing.Point(303, 835);
            this.txtStanicaPretraga.Name = "txtStanicaPretraga";
            this.txtStanicaPretraga.Size = new System.Drawing.Size(202, 30);
            this.txtStanicaPretraga.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(144, 835);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "Naziv stanice:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 761);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(383, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pretraživanje autobusne stanice:";
            // 
            // btnDodajStanicu
            // 
            this.btnDodajStanicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStanicu.Location = new System.Drawing.Point(295, 649);
            this.btnDodajStanicu.Name = "btnDodajStanicu";
            this.btnDodajStanicu.Size = new System.Drawing.Size(192, 45);
            this.btnDodajStanicu.TabIndex = 26;
            this.btnDodajStanicu.Text = "Ažuriraj stanicu";
            this.btnDodajStanicu.UseVisualStyleBackColor = true;
            this.btnDodajStanicu.Click += new System.EventHandler(this.btnDodajStanicu_Click);
            // 
            // textBroj_stanice
            // 
            this.textBroj_stanice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBroj_stanice.Location = new System.Drawing.Point(398, 565);
            this.textBroj_stanice.Name = "textBroj_stanice";
            this.textBroj_stanice.Size = new System.Drawing.Size(174, 30);
            this.textBroj_stanice.TabIndex = 25;
            // 
            // textNaziv_stanice
            // 
            this.textNaziv_stanice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNaziv_stanice.Location = new System.Drawing.Point(398, 488);
            this.textNaziv_stanice.Name = "textNaziv_stanice";
            this.textNaziv_stanice.Size = new System.Drawing.Size(174, 30);
            this.textNaziv_stanice.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Broj stanice:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Naziv stanice:";
            // 
            // FrmAutobusnaStanica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 980);
            this.Controls.Add(this.btnDodajStanicu);
            this.Controls.Add(this.textBroj_stanice);
            this.Controls.Add(this.textNaziv_stanice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtStanicaPretraga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisiStanicu);
            this.Controls.Add(this.btnDodajNovuStanicu);
            this.Controls.Add(this.dgvAutobusne_stanice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAutobusnaStanica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAutobusnaStanica";
            this.Load += new System.EventHandler(this.FrmAutobusnaStanica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutobusne_stanice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiStanicu;
        private System.Windows.Forms.Button btnDodajNovuStanicu;
        private System.Windows.Forms.DataGridView dgvAutobusne_stanice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtStanicaPretraga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodajStanicu;
        private System.Windows.Forms.TextBox textBroj_stanice;
        private System.Windows.Forms.TextBox textNaziv_stanice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}