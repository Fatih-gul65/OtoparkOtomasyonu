using OtoparkOtomasyon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class aracbul : Form
    {
        Baglanti baglanti = new Baglanti();

        public aracbul()
        {
            InitializeComponent();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelGirisi personelGirisi = new PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }

        private void btnAracBul_Click(object sender, EventArgs e)
        {
            string plaka = txtPlaka.Text.Trim(); // Kullanıcıdan alınan plaka

            if (string.IsNullOrEmpty(plaka))
            {
                MessageBox.Show("Lütfen bir plaka girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var entities = baglanti.Entity();
                // Plakaya göre araç arama (case-insensitive)
                var aracgiris = entities.AracGiris
                    .FirstOrDefault(a => a.Plaka.ToLower() == plaka.ToLower());

                if (aracgiris != null)
                {
                    lblAracYeri.Text = $"Şurada: {aracgiris.ParkYeri}";
                }
                else
                {
                    lblAracYeri.Text = "Araç bulunamadı!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
