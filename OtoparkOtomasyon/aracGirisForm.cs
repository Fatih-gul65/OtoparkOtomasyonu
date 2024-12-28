using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class aracGirisForm
    {
        private Baglanti _baglanti;
        private TextBox _txtMusteriAdi, _txtMusteriSoyadi, _txtPlaka, _txtTelefonNo;
        private ComboBox _cmbAracTuru;
        private Label _lblDogrulamaKodu, _lblParkYeri;
        private Random _rnd = new Random();
        private Dictionary<string, int> _aracTuruKapasiteleri = new Dictionary<string, int>();




        public aracGirisForm(Baglanti baglanti, TextBox txtMusteriAdi, TextBox txtMusteriSoyadi, TextBox txtPlaka, TextBox txtTelefonNo, ComboBox cmbAracTuru, Label lblDogrulamaKodu, Label lblParkYeri)
        {
            _baglanti = baglanti;
            _txtMusteriAdi = txtMusteriAdi;
            _txtMusteriSoyadi = txtMusteriSoyadi;
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
                _aracTuruKapasiteleri["Otomobil"] = aracKapasitesi.OtomobilKapasitesi ?? 0;
                _aracTuruKapasiteleri["Minibüs/Kamyon"] = aracKapasitesi.MinibusKapasitesi ?? 0;
                _aracTuruKapasiteleri["Kamyonet"] = aracKapasitesi.KamyonetKapasitesi ?? 0;
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

            if (!_aracTuruKapasiteleri.TryGetValue(aracTuru, out int kapasite))
            {
                _lblParkYeri.Text = "Kapasite bilgisi bulunamadı.";
                return;
            }

            string parkYeri;
            do
            {
                parkYeri = $"{harf}{_rnd.Next(1, kapasite + 1)}";
            } while (entities.AracKapasitesi.Any(a => a.ParkYeri == parkYeri));


            _lblParkYeri.Text = parkYeri;
        }

        public void TemizleForm()
        {
            _txtMusteriAdi.Clear();
            _txtMusteriSoyadi.Clear();
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

                if (string.IsNullOrWhiteSpace(_txtMusteriAdi.Text) ||
                    string.IsNullOrWhiteSpace(_txtMusteriSoyadi.Text) ||
                    string.IsNullOrWhiteSpace(_txtPlaka.Text) ||
                    _cmbAracTuru.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(_txtTelefonNo.Text) ||
                    string.IsNullOrWhiteSpace(_lblDogrulamaKodu.Text) ||
                    string.IsNullOrWhiteSpace(_lblParkYeri.Text))
                {
                    MesajGoster.Uyari("Lütfen tüm zorunlu alanları doldurunuz.");
                    return;
                }

                int parkYeri = int.Parse(_lblParkYeri.Text.Substring(1));

                if (entities.AracGiris.Any(x => x.Plaka == _txtPlaka.Text))
                {
                    MesajGoster.Uyari("Bu plaka  zaten var. Lütfen başka bir plaka seçiniz.");
                    return;
                }

                DateTime tarihGiris = DateTime.Now;

                AracGiris yeniKayit = new AracGiris
                {
                    MusteriAdi = _txtMusteriAdi.Text,
                    MusteriSoyadi = _txtMusteriSoyadi.Text,
                    Plaka = _txtPlaka.Text.Trim().ToUpper(),
                    AracTuru = _cmbAracTuru.SelectedItem.ToString(),
                    TelefonNo = Convert.ToInt32(_txtTelefonNo.Text),
                    DogrulamaKodu = _lblDogrulamaKodu.Text,
                    ParkYeri = parkYeri,
                    GirisTarihi = tarihGiris
                };

                entities.AracGiris.Add(yeniKayit);

                MesajGoster.Bilgi("Araç başarıyla kaydedildi!");

                entities.AracKapasitesi.Add(new AracKapasitesi
                {
                    ParkYeri = _lblParkYeri.Text
                });

                entities.SaveChanges();

                TemizleForm();
                await Task.Delay(1000);
                yukle();
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
    }
}
