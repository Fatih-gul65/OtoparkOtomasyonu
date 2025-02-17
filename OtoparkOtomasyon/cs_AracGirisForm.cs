﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class cs_AracGirisForm
    {
        private cs_Baglanti _baglanti;
        private TextBox _txtPlaka, _txtTelefonNo;
        private ComboBox _cmbAracTuru;
        private Label _lblDogrulamaKodu, _lblParkYeri;
        private Random _rnd = new Random();
        private Dictionary<string, int> _aracTuruKapasiteleri = new Dictionary<string, int>();

        public cs_AracGirisForm(cs_Baglanti baglanti, TextBox txtPlaka, TextBox txtTelefonNo, ComboBox cmbAracTuru, Label lblDogrulamaKodu, Label lblParkYeri)
        {
            _baglanti = baglanti;
            _txtPlaka = txtPlaka;
            _txtTelefonNo = txtTelefonNo;
            _cmbAracTuru = cmbAracTuru;
            _lblDogrulamaKodu = lblDogrulamaKodu;
            _lblParkYeri = lblParkYeri;
        }
        public void yukle()
        {
            _cmbAracTuru.Items.Clear();

            // Araç türleri ComboBox'a ekleniyor
            _cmbAracTuru.Items.AddRange(new[] { "Otomobil", "Minibüs/Kamyon", "Kamyonet" });

            _lblDogrulamaKodu.Text = _rnd.Next(1000, 9999).ToString();
            _cmbAracTuru.SelectedIndexChanged += CmbAracTuru_SelectedIndexChanged;

            // Araç kapasitelerini yükle
            Task.Run(AraçKapasiteleriniYukle);
        }
        private async Task AraçKapasiteleriniYukle()
        {
            var aracKapasiteleri = await Task.Run(() => _baglanti.Entity().AracKapasitesi.ToList());

            _aracTuruKapasiteleri.Clear(); // Önce dictionary'yi temizle
            foreach (var aracKapasitesi in aracKapasiteleri)
            {
                _aracTuruKapasiteleri["Otomobil"] = aracKapasitesi.OtomobilKapasitesi ?? -1;
                _aracTuruKapasiteleri["Minibüs/Kamyon"] = aracKapasitesi.MinibusKapasitesi ?? -1;
                _aracTuruKapasiteleri["Kamyonet"] = aracKapasitesi.KamyonetKapasitesi ?? -1;
            }
        }
        private void CmbAracTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entities = _baglanti.Entity();
            if (_cmbAracTuru.SelectedItem == null)
            {
                _lblParkYeri.Text = "Seçim yapılmadı";
                return;
            }

            string aracTuru = _cmbAracTuru.SelectedItem.ToString();
            string harf = "";
            // Araç türüne göre harfi belirlemek için switch kullanımı
            switch (aracTuru)
            {
                case "Otomobil":
                    harf = "A";
                    break;
                case "Minibüs/Kamyon":
                    harf = "C";
                    break;
                case "Kamyonet":
                    harf = "B";
                    break;
            }

            if (!_aracTuruKapasiteleri.TryGetValue(aracTuru, out int kapasite) || kapasite == -1)
            {
                _lblParkYeri.Text = "Kapasite bilgisi bulunamadı.";
                return;
            }
            // Dolu park yerlerini kontrol et ve boş park yeri olup olmadığını kontrol et
            int mevcutKapasite = kapasite - entities.ParkYeri.Count(a => a.ParkYeri1.StartsWith(harf));

            if (mevcutKapasite <= 0)
            {
                // Kapasite dolmuşsa kullanıcıya bilgi ver
                _lblParkYeri.Text = "Kapasite dolmuş, boş park yeri yok!";
                return;
            }
            string parkYeri;
            do
            {
                parkYeri = $"{harf}{_rnd.Next(1, kapasite + 1)}";
            } while (entities.ParkYeri.Any(a => a.ParkYeri1 == parkYeri));

            _lblParkYeri.Text = parkYeri;
        }
        public void TemizleForm()
        {
            _txtPlaka.Clear();
            _txtTelefonNo.Clear();
            _cmbAracTuru.SelectedIndex = -1;
            _lblDogrulamaKodu.Text = string.Empty;
            _lblParkYeri.Text = string.Empty;
        }
        public async void kaydet()
        {
            try
            {
                var entities = _baglanti.Entity();

                if (
                    string.IsNullOrWhiteSpace(_txtPlaka.Text) ||
                    _cmbAracTuru.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(_txtTelefonNo.Text) ||
                    string.IsNullOrWhiteSpace(_lblDogrulamaKodu.Text) ||
                    string.IsNullOrWhiteSpace(_lblParkYeri.Text))
                {
                    cs_MesajGoster.Uyari("Lütfen tüm zorunlu alanları doldurunuz.");
                    return;
                }

                var plaka = _txtPlaka.Text.Trim().ToUpper();

                if (!cs_PlakaKontrolu.PlakaKontrol(plaka))
                {
                    throw new Exception("Plaka formatı geçersiz.");
                }

                if (!_aracTuruKapasiteleri.TryGetValue(_cmbAracTuru.SelectedItem.ToString(), out int kapasite) || kapasite == -1)
                {
                    cs_MesajGoster.Uyari("Seçilen araç türü için kapasite bilgisi bulunamadı.");
                    return;
                }
                // Mevcut kapasiteyi kontrol et
                string aracTuru = _cmbAracTuru.SelectedItem.ToString();
                string harf = "";
                switch (aracTuru)
                {
                    case "Otomobil":
                        harf = "A";
                        break;
                    case "Minibüs/Kamyon":
                        harf = "C";
                        break;
                    case "Kamyonet":
                        harf = "B";
                        break;
                    default:
                        throw new InvalidOperationException("Geçersiz araç türü.");
                }

                int mevcutKapasite = kapasite - entities.ParkYeri.Count(a => a.ParkYeri1.StartsWith(harf));
                if (mevcutKapasite <= 0)
                {
                    cs_MesajGoster.Uyari("Kapasite dolmuş, yeni araç eklenemez.");
                    return;
                }
                if (entities.AracGiris.Any(x => x.Plaka == _txtPlaka.Text && !entities.AracCikis.Any(c => c.Plaka == x.Plaka)))
                {
                    cs_MesajGoster.Uyari("Bu plaka zaten var. Lütfen başka bir plaka seçiniz.");
                    return;
                }

                DateTime tarihGiris = DateTime.Now;

                AracGiris yeniKayit = new AracGiris
                {
                    Plaka = _txtPlaka.Text.Trim().ToUpper(),
                    AracTuru = _cmbAracTuru.SelectedItem.ToString(),
                    TelefonNo = Convert.ToInt32(_txtTelefonNo.Text),
                    DogrulamaKodu = _lblDogrulamaKodu.Text,
                    ParkYeri = _lblParkYeri.Text,
                    GirisTarihi = tarihGiris
                };

                entities.AracGiris.Add(yeniKayit);

                cs_MesajGoster.Bilgi("Araç başarıyla kaydedildi!");

                entities.ParkYeri.Add(new ParkYeri
                {
                    ParkYeri1 = _lblParkYeri.Text
                });

                entities.SaveChanges();

                TemizleForm();
                await Task.Delay(1000);
                yukle();
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
        }
    }
}
