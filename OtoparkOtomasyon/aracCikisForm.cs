﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class aracCikisForm
    {
        private Baglanti _baglanti;
        private TextBox _txtAracPlakasi;
        private TextBox _txtDogrulamaKodu;
        private Label _lblTutar;
        private Label _lblKalinanSure;
        private RadioButton _rdbtnNakit;
        private RadioButton _rdbtnKrediKart;
        private bool _hesaplandiMi = false; // Başlangıçta false


        public aracCikisForm(Baglanti baglanti, TextBox txtAracPlakasi, TextBox txtDogrulamaKodu, Label lblTutar, Label lblKalinanSure, RadioButton rdbtnNakit, RadioButton rdbtnKrediKart)
        {
            _baglanti = baglanti;
            _txtAracPlakasi = txtAracPlakasi;
            _txtDogrulamaKodu = txtDogrulamaKodu;
            _lblTutar = lblTutar;
            _lblKalinanSure = lblKalinanSure;
            _rdbtnNakit = rdbtnNakit;
            _rdbtnKrediKart = rdbtnKrediKart;
        }
        public void TemizleForm()
        {
            _txtAracPlakasi.Text = "";
            _txtDogrulamaKodu.Text = "";
            _lblTutar.Text = "0 TL";
            _lblKalinanSure.Text = "0 saat";
            _rdbtnNakit.Checked = true;
            _hesaplandiMi = false;
        }
        public void Hesapla()
        {
            try
            {
                var entities = _baglanti.Entity();
                string plaka = _txtAracPlakasi.Text.Trim();
                string dogrulamaKodu = _txtDogrulamaKodu.Text.Trim();

                // Ödeme türü seçimi kontrolü
                if (!_rdbtnNakit.Checked && !_rdbtnKrediKart.Checked)
                {
                    MesajGoster.Uyari("Lütfen bir ödeme türü seçiniz!");
                    return;
                }
                // Giris kaydı kontrol et
                var girisKaydi = entities.AracGiris
                                        .FirstOrDefault(g => g.Plaka == plaka && g.DogrulamaKodu == dogrulamaKodu);

                if (girisKaydi == null)
                {
                    MesajGoster.Hata("Bu plakaya ait giriş kaydı bulunamadı!");
                    return;
                }
                // Çıkış kaydı kontrolü
                var cikisKaydi = entities.AracCikis.FirstOrDefault(c => c.Plaka == plaka && c.DogrulamaKodu == dogrulamaKodu);
                if (cikisKaydi != null)
                {
                    MesajGoster.Hata("Bu plakaya ait çıkış işlemi zaten yapılmış!");
                    return;
                }
             
              
                var aracTuru = girisKaydi.AracTuru;
                var UcretTarifesi = entities.AracUcretleri.FirstOrDefault(u => u.AracTuru == aracTuru);
                DateTime cikisTarihi = DateTime.Now;
                TimeSpan kalinanSure = cikisTarihi - girisKaydi.GirisTarihi;
                double toplamSaat = Math.Ceiling(kalinanSure.TotalHours);
                decimal ToplamUcret = 0;

                if (toplamSaat <= 3)
                {
                    ToplamUcret = Convert.ToDecimal(UcretTarifesi.AracUcret03);
                }
                else if (toplamSaat > 3 && toplamSaat <= 6)
                {
                    ToplamUcret = Convert.ToDecimal(UcretTarifesi.AracUcret36);
                }
                else if (toplamSaat > 6 && toplamSaat <= 24)
                {
                    ToplamUcret = Convert.ToDecimal(UcretTarifesi.AracUcret61);
                }
                else
                {
                    int gunSayisi = (int)Math.Ceiling(toplamSaat / 24.0);
                    ToplamUcret = gunSayisi * Convert.ToDecimal(UcretTarifesi.AracUcretBirGunUzeri);
                }



                _lblTutar.Text = $"{ToplamUcret} TL";
                _lblKalinanSure.Text = $"{Math.Ceiling(kalinanSure.TotalHours)} saat"; // Kalınan süreyi göster

                // Hesaplama başarılı, kontrol değişkenini true yap
                _hesaplandiMi = true;
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }

        }
        public void Kaydet()
        {

            try
            {
                var entities = _baglanti.Entity();
                string plaka = _txtAracPlakasi.Text.Trim();
                string dogrulamaKodu = _txtDogrulamaKodu.Text.Trim();

                // Giris kaydı kontrol et
                var girisKaydi = entities.AracGiris
                                        .FirstOrDefault(g => g.Plaka == plaka && g.DogrulamaKodu == dogrulamaKodu);

                if (girisKaydi == null)
                {
                    MesajGoster.Hata("Bu plakaya ait giriş kaydı bulunamadı!");
                    return;
                }
                // Hesaplama yapılmış mı kontrolü
                if (!_hesaplandiMi)
                {
                    MesajGoster.Uyari("Lütfen önce ücreti hesaplayınız!");
                    return;
                }
                

                var UcretTarifesi = entities.AracUcretleri.FirstOrDefault(u => u.AracTuru == girisKaydi.AracTuru);

                if (UcretTarifesi == null)
                {
                    MesajGoster.Hata("ücret tarifesi bulunamadı!");
                    return;
                }
                // Çıkış işlemi için kaydı oluştur
                DateTime cikisTarihi = DateTime.Now; // Çıkış anı
                decimal? toplamUcret = Convert.ToDecimal(_lblTutar.Text.Replace(" TL", ""));


                var aracCikis = new AracCikis
                {
                    Plaka = plaka,
                    CikisTarihi = cikisTarihi,
                    ToplamUcret = toplamUcret,
                    OdemeTuru = _rdbtnNakit.Checked ? "Nakit" : "Kredi Kartı",
                    DogrulamaKodu = dogrulamaKodu,
                    GirisID = girisKaydi.GirisID,
                    AracUcretID = UcretTarifesi.AracUcretID
                };

                // Veritabanına kaydet
                entities.AracCikis.Add(aracCikis);

                // Araç türüne göre harfi belirlemek için switch kullanımı
                string harf = "";
                switch (girisKaydi.AracTuru)
                {
                    case "Otomobil":
                        harf = "A";  // Otomobil türü için A harfi
                        break;
                    case "Minibüs/Kamyon":
                        harf = "C";  // Minibüs/Kamyon türü için C harfi
                        break;
                    case "Kamyonet":
                        harf = "B";  // Kamyonet türü için B harfi
                        break;
                }

                // Park yerini aldık
                string parkYeri = girisKaydi.ParkYeri.ToString();

                // Park yerinin tam kodunu oluşturuyoruz (örneğin A1, B2, vb.)


                parkYeri = $"{harf}{parkYeri}";

                // Dolu park yerleri listesinden bu park yerini kaldırıyoruz
                var silinecek = entities.AracKapasitesi.FirstOrDefault(a => a.ParkYeri == parkYeri);
                if (silinecek != null)
                {
                    entities.AracKapasitesi.Remove(silinecek);
                    entities.SaveChanges();
                }
                // Park yeri artık boşaldı
                //Giriş kaydını sil 
                //entities.AracGiris.Remove(girisKaydi);
                entities.SaveChanges();

                MesajGoster.Bilgi("Çıkış başarıyla kaydedildi!");

                // Formu temizle
                TemizleForm();
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }

        }


    }

}
