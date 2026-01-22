using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace EwidencjaPojazdow
{
    public partial class Form1 : Form
    {
        private List<Pojazd> listaPojazdow = new List<Pojazd>();

        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNrRej.Text)) return;

            listaPojazdow.Add(new Pojazd
            {
                NrRejestracyjny = txtNrRej.Text,
                Marka = txtMarka.Text,
                Model = txtModel.Text,
                RokProdukcji = (int)numRok.Value,
                DataPrzegladu = dtpPrzeglad.Value,
                Wlasciciel = txtWlasciciel.Text
            });

            dgvPojazdy.DataSource = null;
            dgvPojazdy.DataSource = listaPojazdow;
            WyczyscPola();
        }

        private void WyczyscPola()
        {
            txtNrRej.Clear(); txtMarka.Clear(); txtModel.Clear(); txtWlasciciel.Clear();
            numRok.Value = 2024; dtpPrzeglad.Value = DateTime.Now;
        }

        private void btnGenerujRaport_Click(object sender, EventArgs e)
        {
            var dane = PobierzDaneDoRaportu();
            if (dane.Count == 0) return;

            Form okno = new Form { Text = "Podgląd raportu", Size = new System.Drawing.Size(800, 600) };
            ReportViewer rv = new ReportViewer { Dock = DockStyle.Fill };

            string rdlcPath = Path.Combine(Application.StartupPath, "RaportPojazdy.rdlc");
            rv.LocalReport.ReportPath = rdlcPath;
            rv.LocalReport.DataSources.Add(new ReportDataSource("DataSetRaportu", dane));

            okno.Controls.Add(rv);
            rv.RefreshReport();
            okno.Show();
        }

        private void btnEksportPdf_Click(object sender, EventArgs e)
        {
            var dane = PobierzDaneDoRaportu();
            if (dane.Count == 0) return;

            try
            {
                LocalReport lr = new LocalReport();
                lr.ReportPath = Path.Combine(Application.StartupPath, "RaportPojazdy.rdlc");
                lr.DataSources.Add(new ReportDataSource("DataSetRaportu", dane));

                byte[] pdf = lr.Render("PDF");

                SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF (*.pdf)|*.pdf", FileName = "Raport.pdf" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sfd.FileName, pdf);
                    MessageBox.Show("Zapisano pomyślnie!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Błąd: " + ex.Message); }
        }

        private List<Pojazd> PobierzDaneDoRaportu()
        {
            var wynik = listaPojazdow.Where(p =>
                p.DataPrzegladu.Month == DateTime.Now.Month &&
                p.DataPrzegladu.Year == DateTime.Now.Year).ToList();

            if (wynik.Count == 0) MessageBox.Show("Brak pojazdów do przeglądu w tym miesiącu.");
            return wynik;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}