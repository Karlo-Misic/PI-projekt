namespace DSUGP
{
    partial class IspisAutobusneStanice
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
            this.btnIspis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvAutobusnaStanica = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAutobusnaStanica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIspis
            // 
            this.btnIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspis.Location = new System.Drawing.Point(203, 384);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(221, 45);
            this.btnIspis.TabIndex = 5;
            this.btnIspis.Text = "Kreiraj izvještaj";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ispis autobusne stanice";
            // 
            // dtgvAutobusnaStanica
            // 
            this.dtgvAutobusnaStanica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAutobusnaStanica.Location = new System.Drawing.Point(43, 83);
            this.dtgvAutobusnaStanica.Name = "dtgvAutobusnaStanica";
            this.dtgvAutobusnaStanica.RowHeadersWidth = 62;
            this.dtgvAutobusnaStanica.RowTemplate.Height = 28;
            this.dtgvAutobusnaStanica.Size = new System.Drawing.Size(547, 258);
            this.dtgvAutobusnaStanica.TabIndex = 3;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // IspisAutobusneStanice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvAutobusnaStanica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IspisAutobusneStanice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IspisAutobusneStanice";
            this.Load += new System.EventHandler(this.IspisAutobusneStanice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAutobusnaStanica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvAutobusnaStanica;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}