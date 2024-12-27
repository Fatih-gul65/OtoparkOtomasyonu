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
        private RadioButton _rdbtnNakit, _rdbtnKrediKart;
        private int carpan;
        private DateTime baslangicTarihi = DateTime.Now;
        private DateTime bitisTarihi;

        public abonelikForm(Baglanti baglanti, ComboBox cmbAracTuru, ComboBox cmbAbonelikSuresi, TextBox txtAracPlakasi, RadioButton rdbtnNakit, RadioButton rdbtnKrediKart, Label lblTutar)
        {
            _baglanti = baglanti;
            _cmbAracTuru = cmbAracTuru;
            _cmbAbonelikSuresi = cmbAbonelikSuresi;
            _txtAracPlakasi = txtAracPlakasi;
            _rdbtnNakit = rdbtnNakit;
            _rdbtnKrediKart = rdbtnKrediKart;
            _lblTutar = lblTutar;
        }

        public void yukle()
        {
            _cmbAracTuru.Items.AddRange(new string[] { "Otomobil", "Kamyonet", "Minibüs / Kamyon" });

            _cmbAbonelikSuresi.Items.AddRange(new string[] { "1 Ay", "2 Ay", "3 Ay", "4 Ay", "5 Ay", "6 Ay", "7 Ay", "8 Ay", "9 Ay", "10 Ay", "11 Ay", "12 Ay" });
        }

        public void CmbSureSecim(string abonelikSuresi)
        {
            abonelikSuresi = _cmbAbonelikSuresi.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(abonelikSuresi))
            {
                carpan = 0;

                switch (abonelikSuresi)
                {
                    case "1 Ay":
                        carpan = 1;
                        break;
                    case "2 Ay":
                        carpan = 2;
                        break;
                    case "3 Ay":
                        carpan = 3;
                        break;
                    case "4 Ay":
                        carpan = 4;
                        break;
                    case "5 Ay":
                        carpan = 5;
                        break;
                    case "6 Ay":
                        carpan = 6;
                        break;
                    case "7 Ay":
                        carpan = 7;
                        break;
                    case "8 Ay":
                        carpan = 8;
                        break;
                    case "9 Ay":
                        carpan = 9;
                        break;
                    case "10 Ay":
                        carpan = 10;
                        break;
                    case "11 Ay":
                        carpan = 11;
                        break;
                    case "12 Ay":
                        carpan = 12;
                        break;
                    default:
                        MesajGoster.Hata("Geçersiz abonelik süresi.");
                        return;
                }
            }
        }

        public void fiyatGoster()
        {
            string aracTuru = _cmbAracTuru.SelectedItem?.ToString();
            string aboneSuresi = _cmbAbonelikSuresi.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(aracTuru) || string.IsNullOrEmpty(aboneSuresi))
            {
                MesajGoster.Uyari("Lütfen araç türünü ve abonelik süresini seçin!");
                return;
            }
            
            if (aracTuru == "Otomobil")
            {
                var Kayit = _baglanti.Entity().AboneUcret.FirstOrDefault(u => u.AboneAracTuru == "Otomobil");
                if (Kayit != null)
                {
                    decimal fiyatOtomobil = 0;
                    decimal fiyat = Kayit.AboneUcreti.GetValueOrDefault();
                    CmbSureSecim(aboneSuresi);

                    fiyatOtomobil = fiyat * carpan;
                    _lblTutar.Text = fiyatOtomobil.ToString() + " TL";
                }
            }
            if (aracTuru == "Kamyonet")
            {
                var Kayit = _baglanti.Entity().AboneUcret.FirstOrDefault(u => u.AboneAracTuru == "Kamyonet");
                if (Kayit != null) {

                    decimal fiyatKamyonet = 0;
                    decimal fiyat = Kayit.AboneUcreti.GetValueOrDefault();
                    CmbSureSecim(aboneSuresi);
                    fiyatKamyonet = fiyat * carpan;
                    _lblTutar.Text = fiyatKamyonet.ToString() + " TL";
                }
            }
            if (aracTuru == "Minibüs / Kamyon")
            {
                var Kayit = _baglanti.Entity().AboneUcret.FirstOrDefault(u => u.AboneAracTuru == "Minibüs / Kamyon");
                if (Kayit != null)
                {
                    decimal fiyatMinibus = 0;
                    decimal fiyat = Kayit.AboneUcreti.GetValueOrDefault();
                    CmbSureSecim(aboneSuresi);
                    fiyatMinibus = fiyat * carpan;
                    _lblTutar.Text = fiyatMinibus.ToString() + " TL";
                }
            }            
        }
        public void kaydet()
        {
            string AboneTipi = "";
            string plaka = _txtAracPlakasi.Text.Trim();
            string aracTuru = _cmbAracTuru.SelectedItem?.ToString();
            string abonelikSuresi = _cmbAbonelikSuresi.SelectedItem?.ToString();
            string tutarStr = _lblTutar.Text.Replace("TL" , " ");

            if (!_rdbtnNakit.Checked && !_rdbtnKrediKart.Checked)
            {
                MesajGoster.Uyari("Lütfen bir ödeme yöntemi seçin!");
                return;
            }

            string odemeTuru = _rdbtnNakit.Checked ? "Nakit" : "Banka / Kredi Kartı";

            if (string.IsNullOrEmpty(plaka) || string.IsNullOrEmpty(aracTuru) || string.IsNullOrEmpty(abonelikSuresi) || string.IsNullOrEmpty(tutarStr))
            {
                MesajGoster.Uyari("Lütfen tüm bilgileri eksiksiz doldurun ve 'Fiyat Göster' butonuna tıkladıktan sonra kaydetme işlemini tamamlayın!");
                return;
            } 

            decimal tutar = 0;
            tutar = Convert.ToDecimal(tutarStr);

            if (carpan > 0 && carpan <= 11)
            {
                bitisTarihi = baslangicTarihi.AddMonths(carpan);
                AboneTipi = carpan + " Aylık";
            }
            else if (carpan == 12)
            {
                bitisTarihi = baslangicTarihi.AddYears(1);
                AboneTipi = "1 Yıllık";
            }
            else
            {
                MesajGoster.Hata("Geçersiz abonelik süresi.");
            }

            try
            {
                var entities = _baglanti.Entity();
                int aboneUcret = entities.AboneUcret
                          .Where(u => u.AboneAracTuru == aracTuru)
                          .Select(u => u.AboneUcretID)
                          .FirstOrDefault();

                int aboneUcretID = entities.AboneUcret
                          .Where(u => u.AboneAracTuru == aracTuru)
                          .Select(u => u.AboneUcretID)
                          .FirstOrDefault();

                if (aboneUcret == 0)
                {
                    MesajGoster.Hata("Geçerli bir ücret bulunamadı! Lütfen ücret tablosunu kontrol edin.");
                    return;
                }

                var yeniAbonelik = new Abonelikler
                {
                    AbonePlaka = plaka,
                    AbonelikBaslangicTarihi = baslangicTarihi,
                    AbonelikBitisTarihi = bitisTarihi,
                    AbonelikUcreti = tutar,
                    AbonelikTipi = AboneTipi,
                    AboneUcretID = aboneUcretID,
                    OdemeYontemi = odemeTuru
                };

                entities.Abonelikler.Add(yeniAbonelik);
                entities.SaveChanges();

                MesajGoster.Bilgi("Abonelik başarıyla kaydedildi!");
            }
            catch (Exception ex)
            {
                MesajGoster.Hata($"Hata: {ex.Message}");
            }
        
        }
    }
}
