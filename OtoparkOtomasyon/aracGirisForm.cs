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
            // Araç türleri ComboBox'a ekleniyor
            _cmbAracTuru.Items.Add("Otomobil");
            _cmbAracTuru.Items.Add("Minibüs");
            _cmbAracTuru.Items.Add("Kamyonet");

            // Doğrulama kodu oluştur
            Random rnd = new Random();
            int dogrulamaKodu = rnd.Next(1000, 9999); // 4 haneli kod
            _lblDogrulamaKodu.Text = dogrulamaKodu.ToString();

            // Park yeri numarası örneği
            _lblParkYeri.Text = "P" + rnd.Next(1, 100); // Örneğin: P23
        }
        public void TemizleForm()
        {
            _txtMusteriAdi.Text = "";
            _txtMusteriSoyadi.Text = "";
            _txtPlaka.Text = "";
            _txtTelefonNo.Text = "";
            _cmbAracTuru.SelectedIndex = -1; // ComboBox'u sıfırla
           
        }
        

        public void kaydet()
        {
            try
            {
                var entities = _baglanti.Entity();
                // Zorunlu alanların kontrolü
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



                // Park yeri numarasını kontrol et
                int parkYeri;
                if (!int.TryParse(_lblParkYeri.Text.Substring(1), out parkYeri))
                {
                    MesajGoster.Hata("Park yeri geçerli bir sayı olmalıdır.");
                    return;
                }

                var mevcutParkYeri = entities.AracGiris.FirstOrDefault(x => x.ParkYeri == parkYeri);

                if (mevcutParkYeri != null)
                {
                    MesajGoster.Uyari("Bu park yeri zaten dolu. Lütfen başka bir park yeri seçiniz.");
                    return;
                }
                // Tarih verisini al ve datetime türünde ayarla
                DateTime tarihGiris = DateTime.Now; // Mevcut tarih

                // Yeni araç girişi oluştur
                AracGiris yeniKayit = new AracGiris
                {
                    MusteriAdi = _txtMusteriAdi.Text,
                    MusteriSoyadi = _txtMusteriSoyadi.Text,
                    Plaka = _txtPlaka.Text.Trim().ToUpper(),
                    AracTuru = _cmbAracTuru.SelectedItem.ToString(),
                    TelefonNo = Convert.ToInt32(_txtTelefonNo.Text),  // Telefon numarasını string olarak kaydediyoruz
                    DogrulamaKodu = _lblDogrulamaKodu.Text,
                    ParkYeri = parkYeri,  // Park yerini string olarak kaydediyoruz
                    GirisTarihi = tarihGiris // Burada tarih verisini datetime türüyle kaydediyoruz
                };

                // Veriyi veritabanına ekle
                entities.AracGiris.Add(yeniKayit);
                entities.SaveChanges();

                MesajGoster.Bilgi("Araç başarıyla kaydedildi!");

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
