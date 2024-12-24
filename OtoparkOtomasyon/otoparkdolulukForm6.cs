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
    public partial class otoparkdolulukForm6 : Form
    {
        Baglanti baglanti = new Baglanti();

        public otoparkdolulukForm6()
        {
            InitializeComponent();

        }

        private void otoparkdolulukForm6_Load(object sender, EventArgs e)
        {
            GuncelleDoluluk();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelGirisi personelGirisi = new PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }

        public void GuncelleDoluluk()
        {
            try
            {
                var entities = baglanti.Entity();
                // AracGiris tablosundaki kayıtları sayıyoruz
                var aracGirisSayisi = entities.AracGiris.Count();

                // Otopark kapasitesini öğreniyoruz
                var otopark = entities.OtoparkDurumu.FirstOrDefault();

                if (otopark != null)
                {
                    // Kapasiteyi nullable int'den int'e dönüştürüyoruz
                    int kapasite = otopark.KapasiteID.HasValue ? otopark.KapasiteID.Value : 0;

                    // Dolu alanları belirliyoruz
                    int doluAlanlar = aracGirisSayisi;

                    // Boş alanları hesaplıyoruz
                    int bosAlanlar = kapasite - doluAlanlar;

                    // Labellere bu verileri yazıyoruz
                    lblDoluAlan.Text = $"Dolu Alan: {doluAlanlar} araç";
                    lblBosAlan.Text = $"Boş Alan: {bosAlanlar} araç";

                    // Kapasiteyi de yazmak isterseniz
                    lblKapasite.Text = $"Toplam Kapasite: {kapasite} araç";
                }
                else
                {
                    MessageBox.Show("Otopark kapasitesi bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }


    }
}
