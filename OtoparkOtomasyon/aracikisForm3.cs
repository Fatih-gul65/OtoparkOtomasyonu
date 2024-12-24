using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class aracikisForm3 : Form
    {

        Baglanti baglanti = new Baglanti();

        public aracikisForm3()
        {
            InitializeComponent();

        }

        private void aracikisForm3_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelGirisi personelGirisi = new PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }

        private void btnUcretHesapla_Click(object sender, EventArgs e)
        {

            try
            {
                var entities = baglanti.Entity();
                string plaka = txtAracPlakasi.Text.Trim();
                string dogrulamaKodu = txtDogrulamaKodu.Text.Trim();

                // Giris kaydı kontrol et
                var girisKaydi = entities.AracGiris
                                        .FirstOrDefault(g => g.Plaka == plaka && g.DogrulamaKodu == dogrulamaKodu);

                if (girisKaydi == null)
                {
                    MessageBox.Show("Bu plakaya ait giriş kaydı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ücret hesaplama
                double saatlikUcret = 20; // Örnek saatlik ücret
                DateTime cikisTarihi = DateTime.Now; // Çıkış anını alıyoruz
                TimeSpan kalinanSure = cikisTarihi - girisKaydi.GirisTarihi;
                double toplamUcret = Math.Ceiling(kalinanSure.TotalHours) * saatlikUcret;

                // Toplam ücreti ekranda göster
                lblTutar.Text = $"{toplamUcret} TL";
                lblKalinanSure.Text = $"{Math.Ceiling(kalinanSure.TotalHours)} saat"; // Kalınan süreyi göster

                // Kullanıcıya bilgi mesajı
                MessageBox.Show($"Toplam Ücret: {toplamUcret} TL", "Ücret Hesaplama", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                var entities = baglanti.Entity();
                string plaka = txtAracPlakasi.Text.Trim();
                string dogrulamaKodu = txtDogrulamaKodu.Text.Trim();

                // Giris kaydı kontrol et
                var girisKaydi = entities.AracGiris
                                        .FirstOrDefault(g => g.Plaka == plaka && g.DogrulamaKodu == dogrulamaKodu);

                if (girisKaydi == null)
                {
                    MessageBox.Show("Bu plakaya ait giriş kaydı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Çıkış işlemi için kaydı oluştur
                DateTime cikisTarihi = DateTime.Now; // Çıkış anı
                decimal? toplamUcret = Convert.ToDecimal(lblTutar.Text.Replace(" TL", ""));


                var aracCikis = new AracCikis
                {
                    Plaka = plaka,
                    CikisTarihi = cikisTarihi,
                    ToplamUcret = toplamUcret,
                    OdemeTuru = rdbtnNakit.Checked ? "Nakit" : "Kredi Kartı",
                    DogrulamaKodu = dogrulamaKodu,
                    GirisID = girisKaydi.GirisID
                };

                // Veritabanına kaydet
                entities.AracCikis.Add(aracCikis);
                // Giriş kaydını sil 
                entities.AracGiris.Remove(girisKaydi);
                entities.SaveChanges();

                MessageBox.Show("Çıkış başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu temizle
                TemizleForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void TemizleForm()
        {
            txtAracPlakasi.Clear();
            txtDogrulamaKodu.Clear();
            lblTutar.Text = "0 TL";
            lblKalinanSure.Text = "0 saat";
            rdbtnNakit.Checked = true;
        }


    }
}
