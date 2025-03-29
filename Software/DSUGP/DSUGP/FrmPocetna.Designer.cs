namespace DSUGP
{
    partial class FrmPocetna
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
            this.btnVoznaLinija = new System.Windows.Forms.Button();
            this.btnVozniRed = new System.Windows.Forms.Button();
            this.btnAutobusnaStanica = new System.Windows.Forms.Button();
            this.btnVozniPark = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIspisReda = new System.Windows.Forms.Button();
            this.btnIspisAutobus = new System.Windows.Forms.Button();
            this.bntIspisVozila = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DSUGP početna stranica";
            // 
            // btnVoznaLinija
            // 
            this.btnVoznaLinija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoznaLinija.Location = new System.Drawing.Point(37, 155);
            this.btnVoznaLinija.Name = "btnVoznaLinija";
            this.btnVoznaLinija.Size = new System.Drawing.Size(350, 45);
            this.btnVoznaLinija.TabIndex = 1;
            this.btnVoznaLinija.Text = "Definiranje vozne linije";
            this.btnVoznaLinija.UseVisualStyleBackColor = true;
            this.btnVoznaLinija.Click += new System.EventHandler(this.btnVoznaLinija_Click);
            // 
            // btnVozniRed
            // 
            this.btnVozniRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVozniRed.Location = new System.Drawing.Point(37, 205);
            this.btnVozniRed.Name = "btnVozniRed";
            this.btnVozniRed.Size = new System.Drawing.Size(350, 45);
            this.btnVozniRed.TabIndex = 2;
            this.btnVozniRed.Text = "Definiranje voznog reda";
            this.btnVozniRed.UseVisualStyleBackColor = true;
            this.btnVozniRed.Click += new System.EventHandler(this.btnVozniRed_Click);
            // 
            // btnAutobusnaStanica
            // 
            this.btnAutobusnaStanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutobusnaStanica.Location = new System.Drawing.Point(37, 256);
            this.btnAutobusnaStanica.Name = "btnAutobusnaStanica";
            this.btnAutobusnaStanica.Size = new System.Drawing.Size(350, 45);
            this.btnAutobusnaStanica.TabIndex = 3;
            this.btnAutobusnaStanica.Text = "Definiranje autobusne stanice";
            this.btnAutobusnaStanica.UseVisualStyleBackColor = true;
            this.btnAutobusnaStanica.Click += new System.EventHandler(this.btnAutobusnaStanica_Click);
            // 
            // btnVozniPark
            // 
            this.btnVozniPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVozniPark.Location = new System.Drawing.Point(37, 308);
            this.btnVozniPark.Name = "btnVozniPark";
            this.btnVozniPark.Size = new System.Drawing.Size(350, 45);
            this.btnVozniPark.TabIndex = 4;
            this.btnVozniPark.Text = "Definiranje voznog parka";
            this.btnVozniPark.UseVisualStyleBackColor = true;
            this.btnVozniPark.Click += new System.EventHandler(this.btnVozniPark_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspis.Location = new System.Drawing.Point(468, 155);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(350, 45);
            this.btnIspis.TabIndex = 5;
            this.btnIspis.Text = "Ispis vozne linije";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Odabir elementa definiranja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(518, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Odabir izvještaja za ispis:";
            // 
            // btnIspisReda
            // 
            this.btnIspisReda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspisReda.Location = new System.Drawing.Point(468, 205);
            this.btnIspisReda.Name = "btnIspisReda";
            this.btnIspisReda.Size = new System.Drawing.Size(350, 45);
            this.btnIspisReda.TabIndex = 8;
            this.btnIspisReda.Text = "Ispis voznog reda";
            this.btnIspisReda.UseVisualStyleBackColor = true;
            this.btnIspisReda.Click += new System.EventHandler(this.btnIspisReda_Click_1);
            // 
            // btnIspisAutobus
            // 
            this.btnIspisAutobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspisAutobus.Location = new System.Drawing.Point(468, 256);
            this.btnIspisAutobus.Name = "btnIspisAutobus";
            this.btnIspisAutobus.Size = new System.Drawing.Size(350, 45);
            this.btnIspisAutobus.TabIndex = 9;
            this.btnIspisAutobus.Text = "Ispis autobusne stanice";
            this.btnIspisAutobus.UseVisualStyleBackColor = true;
            this.btnIspisAutobus.Click += new System.EventHandler(this.btnIspisAutobus_Click);
            // 
            // bntIspisVozila
            // 
            this.bntIspisVozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntIspisVozila.Location = new System.Drawing.Point(468, 308);
            this.bntIspisVozila.Name = "bntIspisVozila";
            this.bntIspisVozila.Size = new System.Drawing.Size(350, 45);
            this.bntIspisVozila.TabIndex = 10;
            this.bntIspisVozila.Text = "Ispis voznog parka";
            this.bntIspisVozila.UseVisualStyleBackColor = true;
            this.bntIspisVozila.Click += new System.EventHandler(this.bntIspisVozila_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Location = new System.Drawing.Point(283, 390);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(300, 45);
            this.btnOdjava.TabIndex = 11;
            this.btnOdjava.Text = "Odjava iz sustava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 447);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.bntIspisVozila);
            this.Controls.Add(this.btnIspisAutobus);
            this.Controls.Add(this.btnIspisReda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnVozniPark);
            this.Controls.Add(this.btnAutobusnaStanica);
            this.Controls.Add(this.btnVozniRed);
            this.Controls.Add(this.btnVoznaLinija);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPocetna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoznaLinija;
        private System.Windows.Forms.Button btnVozniRed;
        private System.Windows.Forms.Button btnAutobusnaStanica;
        private System.Windows.Forms.Button btnVozniPark;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIspisReda;
        private System.Windows.Forms.Button btnIspisAutobus;
        private System.Windows.Forms.Button bntIspisVozila;
        private System.Windows.Forms.Button btnOdjava;
    }
}