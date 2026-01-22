namespace EwidencjaPojazdow
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblNrRej = new System.Windows.Forms.Label();
            this.txtNrRej = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblRok = new System.Windows.Forms.Label();
            this.numRok = new System.Windows.Forms.NumericUpDown();
            this.lblDataPrzegladu = new System.Windows.Forms.Label();
            this.dtpPrzeglad = new System.Windows.Forms.DateTimePicker();
            this.lblWlasciciel = new System.Windows.Forms.Label();
            this.txtWlasciciel = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnGenerujRaport = new System.Windows.Forms.Button();
            this.btnEksportPdf = new System.Windows.Forms.Button();
            this.dgvPojazdy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numRok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNrRej
            // 
            this.lblNrRej.Location = new System.Drawing.Point(26, 33);
            this.lblNrRej.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNrRej.Name = "lblNrRej";
            this.lblNrRej.Size = new System.Drawing.Size(129, 31);
            this.lblNrRej.TabIndex = 0;
            this.lblNrRej.Text = "Nr rejestracyjny:";
            // 
            // txtNrRej
            // 
            this.txtNrRej.Location = new System.Drawing.Point(167, 29);
            this.txtNrRej.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNrRej.Name = "txtNrRej";
            this.txtNrRej.Size = new System.Drawing.Size(192, 26);
            this.txtNrRej.TabIndex = 1;
            // 
            // lblMarka
            // 
            this.lblMarka.Location = new System.Drawing.Point(26, 80);
            this.lblMarka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(129, 31);
            this.lblMarka.TabIndex = 2;
            this.lblMarka.Text = "Marka:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(167, 76);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(192, 26);
            this.txtMarka.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(26, 127);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(129, 31);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(167, 123);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(192, 26);
            this.txtModel.TabIndex = 5;
            // 
            // lblRok
            // 
            this.lblRok.Location = new System.Drawing.Point(26, 173);
            this.lblRok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRok.Name = "lblRok";
            this.lblRok.Size = new System.Drawing.Size(129, 31);
            this.lblRok.TabIndex = 6;
            this.lblRok.Text = "Rok produkcji:";
            // 
            // numRok
            // 
            this.numRok.Location = new System.Drawing.Point(167, 169);
            this.numRok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numRok.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numRok.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numRok.Name = "numRok";
            this.numRok.Size = new System.Drawing.Size(193, 26);
            this.numRok.TabIndex = 7;
            this.numRok.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // lblDataPrzegladu
            // 
            this.lblDataPrzegladu.Location = new System.Drawing.Point(26, 220);
            this.lblDataPrzegladu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPrzegladu.Name = "lblDataPrzegladu";
            this.lblDataPrzegladu.Size = new System.Drawing.Size(129, 31);
            this.lblDataPrzegladu.TabIndex = 8;
            this.lblDataPrzegladu.Text = "Data przeglądu:";
            // 
            // dtpPrzeglad
            // 
            this.dtpPrzeglad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrzeglad.Location = new System.Drawing.Point(167, 216);
            this.dtpPrzeglad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpPrzeglad.Name = "dtpPrzeglad";
            this.dtpPrzeglad.Size = new System.Drawing.Size(192, 26);
            this.dtpPrzeglad.TabIndex = 9;
            // 
            // lblWlasciciel
            // 
            this.lblWlasciciel.Location = new System.Drawing.Point(26, 267);
            this.lblWlasciciel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWlasciciel.Name = "lblWlasciciel";
            this.lblWlasciciel.Size = new System.Drawing.Size(129, 31);
            this.lblWlasciciel.TabIndex = 10;
            this.lblWlasciciel.Text = "Właściciel:";
            // 
            // txtWlasciciel
            // 
            this.txtWlasciciel.Location = new System.Drawing.Point(167, 263);
            this.txtWlasciciel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWlasciciel.Name = "txtWlasciciel";
            this.txtWlasciciel.Size = new System.Drawing.Size(192, 26);
            this.txtWlasciciel.TabIndex = 11;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.LightGreen;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Location = new System.Drawing.Point(26, 333);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(334, 53);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "DODAJ POJAZD";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnGenerujRaport
            // 
            this.btnGenerujRaport.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGenerujRaport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerujRaport.Location = new System.Drawing.Point(26, 400);
            this.btnGenerujRaport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerujRaport.Name = "btnGenerujRaport";
            this.btnGenerujRaport.Size = new System.Drawing.Size(334, 53);
            this.btnGenerujRaport.TabIndex = 13;
            this.btnGenerujRaport.Text = "PODGLĄD RAPORTU";
            this.btnGenerujRaport.UseVisualStyleBackColor = false;
            this.btnGenerujRaport.Click += new System.EventHandler(this.btnGenerujRaport_Click);
            // 
            // btnEksportPdf
            // 
            this.btnEksportPdf.BackColor = System.Drawing.Color.LightCoral;
            this.btnEksportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEksportPdf.Location = new System.Drawing.Point(26, 467);
            this.btnEksportPdf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEksportPdf.Name = "btnEksportPdf";
            this.btnEksportPdf.Size = new System.Drawing.Size(334, 53);
            this.btnEksportPdf.TabIndex = 14;
            this.btnEksportPdf.Text = "EKSPORTUJ DO PDF";
            this.btnEksportPdf.UseVisualStyleBackColor = false;
            this.btnEksportPdf.Click += new System.EventHandler(this.btnEksportPdf_Click);
            // 
            // dgvPojazdy
            // 
            this.dgvPojazdy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPojazdy.Location = new System.Drawing.Point(386, 33);
            this.dgvPojazdy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPojazdy.Name = "dgvPojazdy";
            this.dgvPojazdy.ReadOnly = true;
            this.dgvPojazdy.RowTemplate.Height = 25;
            this.dgvPojazdy.Size = new System.Drawing.Size(643, 573);
            this.dgvPojazdy.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 640);
            this.Controls.Add(this.dgvPojazdy);
            this.Controls.Add(this.btnEksportPdf);
            this.Controls.Add(this.btnGenerujRaport);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtWlasciciel);
            this.Controls.Add(this.lblWlasciciel);
            this.Controls.Add(this.dtpPrzeglad);
            this.Controls.Add(this.lblDataPrzegladu);
            this.Controls.Add(this.numRok);
            this.Controls.Add(this.lblRok);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.txtNrRej);
            this.Controls.Add(this.lblNrRej);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ewidencja Pojazdów";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNrRej;
        private System.Windows.Forms.TextBox txtNrRej;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblRok;
        private System.Windows.Forms.NumericUpDown numRok;
        private System.Windows.Forms.Label lblDataPrzegladu;
        private System.Windows.Forms.DateTimePicker dtpPrzeglad;
        private System.Windows.Forms.Label lblWlasciciel;
        private System.Windows.Forms.TextBox txtWlasciciel;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnGenerujRaport;
        private System.Windows.Forms.Button btnEksportPdf;
        private System.Windows.Forms.DataGridView dgvPojazdy;
    }
}