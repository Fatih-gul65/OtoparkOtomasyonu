using System;
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


        public aracCikisForm(Baglanti baglanti,TextBox txtAracPlakasi, TextBox txtDogrulamaKodu, Label lblTutar, Label lblKalinanSure, RadioButton rdbtnNakit )
        {
            _baglanti = baglanti;
            _txtAracPlakasi = txtAracPlakasi;
            _txtDogrulamaKodu = txtDogrulamaKodu;
            _lblTutar = lblTutar;
            _lblKalinanSure = lblKalinanSure;
            _rdbtnNakit = rdbtnNakit;

        }
        public void TemizleForm()
        {
            _txtAracPlakasi.Text="";
            _txtDogrulamaKodu.Text="";
            _lblTutar.Text = "0 TL";
            _lblKalinanSure.Text = "0 saat";
            _rdbtnNakit.Checked = true;
        }
        public void Hesapla()
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

                // Ücret hesaplama
                double saatlikUcret = 20; // Örnek saatlik ücret
                DateTime cikisTarihi = DateTime.Now; // Çıkış anını alıyoruz
                TimeSpan kalinanSure = cikisTarihi - girisKaydi.GirisTarihi;
                double toplamUcret = Math.Ceiling(kalinanSure.TotalHours) * saatlikUcret;

                // Toplam ücreti ekranda göster
                _lblTutar.Text = $"{toplamUcret} TL";
                _lblKalinanSure.Text = $"{Math.Ceiling(kalinanSure.TotalHours)} saat"; // Kalınan süreyi göster
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
                    GirisID = girisKaydi.GirisID
                };

                // Veritabanına kaydet
                entities.AracCikis.Add(aracCikis);
                // Giriş kaydını sil 
                entities.AracGiris.Remove(girisKaydi);
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
