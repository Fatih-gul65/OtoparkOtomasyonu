using System;
using System.Data.Entity;
using System.Linq;
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
        private bool _hesaplandiMi;

        public aracCikisForm(Baglanti baglanti, TextBox txtAracPlakasi, TextBox txtDogrulamaKodu, Label lblTutar, Label lblKalinanSure, RadioButton rdbtnNakit, RadioButton rdbtnKrediKart)
        {
            _baglanti = baglanti;
            _txtAracPlakasi = txtAracPlakasi;
            _txtDogrulamaKodu = txtDogrulamaKodu;
            _lblTutar = lblTutar;
            _lblKalinanSure = lblKalinanSure;
            _rdbtnNakit = rdbtnNakit;
            _rdbtnKrediKart = rdbtnKrediKart;
            _hesaplandiMi = false;
        }

        public void TemizleForm()
        {
            _txtAracPlakasi.Clear();
            _txtDogrulamaKodu.Clear();
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

                if (entities.AracCikis.Any(c => c.Plaka == plaka && c.DogrulamaKodu == dogrulamaKodu))
                {
                    MesajGoster.Hata("Bu plakaya ait çıkış işlemi zaten yapılmış!");
                    return;
                }

                var girisKaydi = entities.AracGiris.FirstOrDefault(g => g.Plaka == plaka && g.DogrulamaKodu == dogrulamaKodu);
                if (girisKaydi == null)
                {
                    MesajGoster.Hata("Bu plakaya ait giriş kaydı bulunamadı!");
                    return;
                }

                if (!_rdbtnNakit.Checked && !_rdbtnKrediKart.Checked)
                {
                    MesajGoster.Uyari("Lütfen bir ödeme türü seçiniz!");
                    return;
                }
                // Ücretsiz Giriş Kontrolü
                if (entities.UcretsizGiris.Any(u => u.Plaka == plaka))
                {
                    MesajGoster.Bilgi("Bu Araç Ücretsiz Giriş Listesinde, Ücretsiz Çıkış.");
                    _lblTutar.Text = "0 TL";
                    _lblKalinanSure.Text = $"{Math.Ceiling((DateTime.Now - girisKaydi.GirisTarihi).TotalHours)} saat";
                    _hesaplandiMi = true;
                    return;
                }
                var aracTuru = girisKaydi.AracTuru;
                var ucretTarifesi = entities.AracUcretleri.FirstOrDefault(u => u.AracTuru == aracTuru);
                if (ucretTarifesi == null)
                {
                    MesajGoster.Hata("Ücret tarifesi bulunamadı!");
                    return;
                }

                TimeSpan kalinanSure = DateTime.Now - girisKaydi.GirisTarihi;
                double toplamSaat = Math.Ceiling(kalinanSure.TotalHours);
                decimal toplamUcret = HesaplaUcret(toplamSaat, ucretTarifesi);

                _lblTutar.Text = $"{toplamUcret} TL";
                _lblKalinanSure.Text = $"{Math.Ceiling(kalinanSure.TotalHours)} saat";

                // Tarihi ve saati dikkate alarak biten abonelikleri kontrol ediyoruz
                var bitenAbonelik = entities.Abonelikler
                    .Where(a => a.AbonePlaka == plaka &&
                                a.AbonelikBitisTarihi <= DateTime.Now) // Süresi bitmiş aboneleri seç
                    .FirstOrDefault();

                // Abonelik durumu kontrol ediliyor
                if (bitenAbonelik != null)
                {
                    MesajGoster.Bilgi("Süresi Dolmuş Abonelik. Normal Ücret.");
                }
                else
                {
                    // Araç hâlâ abone mi?
                    var aktifAbonelik = entities.Abonelikler
                        .Where(a => a.AbonePlaka == plaka &&
                                    a.AbonelikBitisTarihi > DateTime.Now) // Süresi bitmemiş aboneler
                        .FirstOrDefault();

                    if (aktifAbonelik != null)
                    {
                        MesajGoster.Bilgi("Abone Araç, Ücretsiz Çıkış.");
                        _lblTutar.Text = "0 TL";
                        _lblKalinanSure.Text = $"{Math.Ceiling(kalinanSure.TotalHours)} saat";
                        _hesaplandiMi = true;
                        return;
                    }
                }

                _hesaplandiMi = true;
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }

        private decimal HesaplaUcret(double toplamSaat, AracUcretleri ucretTarifesi)
        {
            if (toplamSaat <= 3)
                return Convert.ToDecimal(ucretTarifesi.AracUcret03);
            if (toplamSaat <= 6)
                return Convert.ToDecimal(ucretTarifesi.AracUcret36);
            if (toplamSaat <= 24)
                return Convert.ToDecimal(ucretTarifesi.AracUcret61);

            int gunSayisi = (int)Math.Ceiling(toplamSaat / 24.0);
            return gunSayisi * Convert.ToDecimal(ucretTarifesi.AracUcretBirGunUzeri);
        }

        public void Kaydet()
        {
            try
            {
                if (!_hesaplandiMi)
                {
                    MesajGoster.Uyari("Lütfen önce ücreti hesaplayınız!");
                    return;
                }

                var entities = _baglanti.Entity();
                string plaka = _txtAracPlakasi.Text.Trim();
                string dogrulamaKodu = _txtDogrulamaKodu.Text.Trim();

                var girisKaydi = entities.AracGiris.FirstOrDefault(g => g.Plaka == plaka && g.DogrulamaKodu == dogrulamaKodu);
                if (girisKaydi == null)
                {
                    MesajGoster.Hata("Bu plakaya ait giriş kaydı bulunamadı!");
                    return;
                }

                var ucretTarifesi = entities.AracUcretleri.FirstOrDefault(u => u.AracTuru == girisKaydi.AracTuru);
                if (ucretTarifesi == null)
                {
                    MesajGoster.Hata("Ücret tarifesi bulunamadı!");
                    return;
                }
                // Abone ve Ücretsiz Giriş ID'lerini sorgula
                var aboneKaydi = entities.Abonelikler
                    .FirstOrDefault(a => a.AbonePlaka == plaka && a.AbonelikBitisTarihi > DateTime.Now);
                var ucretsizGirisKaydi = entities.UcretsizGiris.FirstOrDefault(u => u.Plaka == plaka);

                var aracCikis = new AracCikis
                {
                    Plaka = plaka,
                    CikisTarihi = DateTime.Now,
                    ToplamUcret = Convert.ToDecimal(_lblTutar.Text.Replace(" TL", "")),
                    OdemeTuru = _rdbtnNakit.Checked ? "Nakit" : "Kredi Kartı",
                    DogrulamaKodu = dogrulamaKodu,
                    GirisID = girisKaydi.GirisID,
                    AracUcretID = ucretTarifesi.AracUcretID,
                    AboneID = aboneKaydi?.AboneID,
                    UcretsizGirisID = ucretsizGirisKaydi?.UcretsizGirisID
                };


                entities.AracCikis.Add(aracCikis);

                var parkYeri = entities.ParkYeri.FirstOrDefault(a => a.ParkYeri1 == girisKaydi.ParkYeri);
                if (parkYeri != null)
                {
                    entities.ParkYeri.Remove(parkYeri);
                }

                entities.SaveChanges();
                MesajGoster.Bilgi("Çıkış başarıyla kaydedildi!");

                TemizleForm();
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
    }
}
