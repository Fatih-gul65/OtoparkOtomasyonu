using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class abonelikForm
    {
        private Baglanti _baglanti;
        private ComboBox _cmbAracTuru, _cmbAbonelikSuresi;
        private TextBox _txtAracPlakasi;
        private Label _lblTutar;

        public abonelikForm(Baglanti baglanti, ComboBox cmbAracTuru, ComboBox cmbAbonelikSuresi, TextBox txtAracPlakasi, Label lblTutar)
        {
            _baglanti = baglanti;
            _cmbAracTuru = cmbAracTuru;
            _cmbAbonelikSuresi = cmbAbonelikSuresi;
            _txtAracPlakasi = txtAracPlakasi;
            _lblTutar = lblTutar;
        }
        public void yukle()
        {
            // Araç türlerini doldur
            _cmbAracTuru.Items.AddRange(new string[] { "Otomobil", "Minibüs", "Kamyonet" });

            // Abonelik sürelerini doldur
            _cmbAbonelikSuresi.Items.AddRange(new string[] { "1 Ay", "3 Ay", "6 Ay", "12 Ay" });
        }
        public void fiyatGoster()
        {
            string aracTuru = _cmbAracTuru.SelectedItem?.ToString();
            string abonelikSuresi = _cmbAbonelikSuresi.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(aracTuru) || string.IsNullOrEmpty(abonelikSuresi))
            {
                MessageBox.Show("Lütfen araç türünü ve abonelik süresini seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int fiyat = 0;

            // Fiyat belirleme
            if (aracTuru == "Otomobil")
            {
                if (abonelikSuresi == "1 Ay") fiyat = 100;
                else if (abonelikSuresi == "3 Ay") fiyat = 250;
                else if (abonelikSuresi == "6 Ay") fiyat = 450;
                else if (abonelikSuresi == "12 Ay") fiyat = 800;
            }
            else if (aracTuru == "Minibüs")
            {
                if (abonelikSuresi == "1 Ay") fiyat = 150;
                else if (abonelikSuresi == "3 Ay") fiyat = 400;
                else if (abonelikSuresi == "6 Ay") fiyat = 700;
                else if (abonelikSuresi == "12 Ay") fiyat = 1200;
            }
            else if (aracTuru == "Kamyonet")
            {
                if (abonelikSuresi == "1 Ay") fiyat = 200;
                else if (abonelikSuresi == "3 Ay") fiyat = 500;
                else if (abonelikSuresi == "6 Ay") fiyat = 900;
                else if (abonelikSuresi == "12 Ay") fiyat = 1600;
            }

            _lblTutar.Text = fiyat.ToString() + " TL";
        }

        public void kaydet()
        {
            string plaka = _txtAracPlakasi.Text.Trim();
            string aracTuru = _cmbAracTuru.SelectedItem?.ToString();
            string abonelikSuresi = _cmbAbonelikSuresi.SelectedItem?.ToString();
            string tutarStr = _lblTutar.Text.Replace(" TL", "");

            if (string.IsNullOrEmpty(plaka) || string.IsNullOrEmpty(aracTuru) || string.IsNullOrEmpty(abonelikSuresi) || string.IsNullOrEmpty(tutarStr))
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fiyatı int'e dönüştür
            int tutar;
            if (!int.TryParse(tutarStr, out tutar))
            {
                MessageBox.Show("Geçersiz tutar!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Abonelik başlangıç ve bitiş tarihlerini hesapla
            DateTime baslangicTarihi = DateTime.Now;
            DateTime bitisTarihi = baslangicTarihi;

            // Abonelik süresine göre bitiş tarihini belirleme (if-else ile)
            if (abonelikSuresi == "1 Ay")
            {
                bitisTarihi = baslangicTarihi.AddMonths(1);
            }
            else if (abonelikSuresi == "3 Ay")
            {
                bitisTarihi = baslangicTarihi.AddMonths(3);
            }
            else if (abonelikSuresi == "6 Ay")
            {
                bitisTarihi = baslangicTarihi.AddMonths(6);
            }
            else if (abonelikSuresi == "12 Ay")
            {
                bitisTarihi = baslangicTarihi.AddYears(1);
            }

            try
            {
                var entities = _baglanti.Entity();
                // AboneUcret tablosunda geçerli bir ücret ile eşleşen satırı almak
                var aboneUcret = entities.AboneUcret.FirstOrDefault(u => u.AboneUcreti == tutar);
                if (aboneUcret == null)
                {
                    MessageBox.Show("Geçerli bir ücret bulunamadı! Lütfen ücret tablosunu kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Entity Framework üzerinden tabloya ekleme işlemi
                var yeniAbonelik = new Abonelikler
                {
                    AbonePlaka = plaka,
                    AbonelikBaslangicTarihi = baslangicTarihi,
                    AbonelikBitisTarihi = bitisTarihi,
                    AbonelikTipi = aracTuru,
                    AboneUcret = aboneUcret
                };

                entities.Abonelikler.Add(yeniAbonelik);
                entities.SaveChanges();

                MessageBox.Show("Abonelik başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
