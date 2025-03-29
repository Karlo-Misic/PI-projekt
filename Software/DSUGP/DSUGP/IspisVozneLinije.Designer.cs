namespace DSUGP
{
    partial class IspisVozneLinije
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
            this.dtgvVozne_linije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIspis = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVozne_linije)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvVozne_linije
            // 
            this.dtgvVozne_linije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVozne_linije.Location = new System.Drawing.Point(40, 74);
            this.dtgvVozne_linije.Name = "dtgvVozne_linije";
            this.dtgvVozne_linije.RowHeadersWidth = 62;
            this.dtgvVozne_linije.RowTemplate.Height = 28;
            this.dtgvVozne_linije.Size = new System.Drawing.Size(996, 258);
            this.dtgvVozne_linije.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ispis vozne linije";
            // 
            // btnIspis
            // 
            this.btnIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspis.Location = new System.Drawing.Point(438, 378);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(221, 45);
            this.btnIspis.TabIndex = 2;
            this.btnIspis.Text = "Kreiraj izvještaj";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // IspisVozneLinije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 450);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvVozne_linije);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IspisVozneLinije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IspisVozneLinije";
            this.Load += new System.EventHandler(this.IspisVozneLinije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVozne_linije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVozne_linije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIspis;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}