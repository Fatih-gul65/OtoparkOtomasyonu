using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class cs_Abonelik
    {
        private cs_Baglanti _baglanti;
        private ComboBox _cmbAracTuru, _cmbAbonelikSuresi;
        private TextBox _txtAracPlakasi;
        private Label _lblTutar , _lblOtomobilAbone, _lblKamyonetAbone , _lblMinibusAbone;
        private RadioButton _rdbtnNakit, _rdbtnKrediKart;
        private int carpan;
        private DateTime baslangicTarihi = DateTime.Now;
        private DateTime bitisTarihi;

        public cs_Abonelik(cs_Baglanti baglanti, ComboBox cmbAracTuru, ComboBox cmbAbonelikSuresi, TextBox txtAracPlakasi, RadioButton rdbtnNakit, RadioButton rdbtnKrediKart, Label lblTutar, Label lblOtomobilAbone,
            Label lblKamyonetAbone , Label lblMinibusAbone)
        {
            _baglanti = baglanti;
            _cmbAracTuru = cmbAracTuru;
            _cmbAbonelikSuresi = cmbAbonelikSuresi;
            _txtAracPlakasi = txtAracPlakasi;
            _rdbtnNakit = rdbtnNakit;
            _rdbtnKrediKart = rdbtnKrediKart;
            _lblTutar = lblTutar;
            _lblOtomobilAbone = lblOtomobilAbone;
            _lblKamyonetAbone = lblKamyonetAbone;
            _lblMinibusAbone = lblMinibusAbone;
        }
        public void yukle()
        {
            _cmbAracTuru.Items.AddRange(new string[] { "Otomobil", "Kamyonet", "Minibüs / Kamyon" });

            _cmbAbonelikSuresi.Items.AddRange(new string[] { "1 Ay", "2 Ay", "3 Ay", "4 Ay", "5 Ay", "6 Ay", "7 Ay", "8 Ay", "9 Ay", "10 Ay", "11 Ay", "1 Yıl" });
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
                    case "1 Yıl":
                        carpan = 12;
                        break;
                    default:
                        cs_MesajGoster.Hata("Geçersiz abonelik süresi.");
                        return;
                }
            }
        }
        public void fiyatGoster()
        {
            string aracTuru = _cmbAracTuru.SelectedItem?.ToString();
            string aboneSuresi = _cmbAbonelikSuresi.SelectedItem?.ToString();
            try { 
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
                    else
                    {
                        _lblTutar.Text = "0 TL";
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
                    else
                    {
                        _lblTutar.Text = "0 TL";
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
                    else
                    {
                        _lblTutar.Text = "0 TL";
                    }
                }
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
        }
        public void PlakaKontrol(string plaka)
        {
            plaka = plaka.ToUpper();

            if (!cs_PlakaKontrolu.PlakaKontrol(plaka))
            {
                throw new Exception("Plaka formatı geçersiz.");
            }
        }
        public void kaydet()
        {
            string AboneTipi = "";
            string plaka = _txtAracPlakasi.Text.Trim();
            string aracTuru = _cmbAracTuru.SelectedItem?.ToString();
            string abonelikSuresi = _cmbAbonelikSuresi.SelectedItem?.ToString();
            string tutarStr = _lblTutar.Text.Replace("TL" , " ");

            if (string.IsNullOrEmpty(aracTuru) || string.IsNullOrEmpty(abonelikSuresi))
            {
                cs_MesajGoster.Uyari("Lütfen araç türünü ve abonelik süresini seçin!");
                return;
            }

            if (!_rdbtnNakit.Checked && !_rdbtnKrediKart.Checked)
            {
                cs_MesajGoster.Uyari("Lütfen bir ödeme yöntemi seçin!");
                return;    
            }

            string odemeTuru = _rdbtnNakit.Checked ? "Nakit" : "Banka / Kredi Kartı";

            if (string.IsNullOrEmpty(plaka) || string.IsNullOrEmpty(aracTuru) || string.IsNullOrEmpty(abonelikSuresi) || string.IsNullOrEmpty(tutarStr))
            {
                cs_MesajGoster.Uyari("Lütfen tüm bilgileri eksiksiz doldurun!");
                return;
            }

            decimal tutar = 0;
            tutar = Convert.ToDecimal(tutarStr);

            if (carpan > 0 && carpan <= 11)
            {
                bitisTarihi = baslangicTarihi.AddMonths(carpan);
                AboneTipi = carpan + " Ay";
            }
            else if (carpan == 12)
            {
                bitisTarihi = baslangicTarihi.AddYears(1);
                AboneTipi = "1 Yıl";
            }
            else
            {
                cs_MesajGoster.Hata("Geçersiz abonelik süresi.");
            }

            try
            {
                PlakaKontrol(plaka);
                var entities = _baglanti.Entity();

                var mevcutAbonelik = entities.Abonelikler
                    .Where(abone => abone.AbonePlaka == plaka && abone.AbonelikBitisTarihi >= DateTime.Now)
                    .FirstOrDefault();

                if (mevcutAbonelik != null)
                {
                    cs_MesajGoster.Uyari("Bu plakaya ait abonelik hizmeti devam etmektedir!");
                    return;
                }

                int aboneUcret = entities.AboneUcret
                          .Where(u => u.AboneAracTuru == aracTuru)
                          .Select(u => u.AboneUcretID)
                          .FirstOrDefault();

                if (aboneUcret == 0)
                {
                    cs_MesajGoster.Hata("Seçilen araç türü için geçerli bir ücret bulunamadı! Lütfen ücret tablosunu kontrol edin.");
                    return;
                }

                var yeniAbonelik = new Abonelikler
                {
                    AbonePlaka = plaka,
                    AbonelikBaslangicTarihi = baslangicTarihi,
                    AbonelikBitisTarihi = bitisTarihi,
                    AbonelikUcreti = tutar,
                    AbonelikTipi = AboneTipi,
                    AboneUcretID = aboneUcret,
                    OdemeYontemi = odemeTuru
                };
                entities.Abonelikler.Add(yeniAbonelik);
                entities.SaveChanges();
                cs_MesajGoster.Bilgi("Abonelik başarıyla kaydedildi!");
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }      
        }
        public void AboneUcretGoster()
        {
            try
            {
                var entities = _baglanti.Entity();
                var otomobilUcret = entities.AboneUcret
                    .Where(a => a.AboneAracTuru == "Otomobil")
                    .Select(a => a.AboneUcreti)
                    .FirstOrDefault();

                var kamyonetUcret = entities.AboneUcret
                    .Where(a => a.AboneAracTuru == "Kamyonet")
                    .Select(a => a.AboneUcreti)
                    .FirstOrDefault();

                var minibusUcret = entities.AboneUcret
                    .Where(a => a.AboneAracTuru == "Minibüs / Kamyon")
                    .Select(a => a.AboneUcreti)
                    .FirstOrDefault();

                _lblOtomobilAbone.Text = otomobilUcret.HasValue ? otomobilUcret.Value.ToString("C") : "Ücret bulunamadı";
                _lblKamyonetAbone.Text = kamyonetUcret.HasValue ? kamyonetUcret.Value.ToString("C") : "Ücret bulunamadı";
                _lblMinibusAbone.Text = minibusUcret.HasValue ? minibusUcret.Value.ToString("C") : "Ücret bulunamadı";
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
        }
    }
}
