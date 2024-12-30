using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class aracBulForm
    {
        private Baglanti _baglanti;
        private TextBox _txtPlaka;
        private Label _lblAracYeri;

        public aracBulForm(Baglanti baglanti, TextBox txtPlaka, Label lblAracYeri)
        {
            _baglanti = baglanti;
            _txtPlaka = txtPlaka;
            _lblAracYeri = lblAracYeri;
        }
        public void aracBul()
        {
            try
            {
                var entities = _baglanti.Entity();
                string plaka = _txtPlaka.Text.Trim(); // Kullanıcıdan alınan plaka

                if (string.IsNullOrEmpty(plaka))
                {
                    MesajGoster.Uyari("Lütfen bir plaka girin!");
                    return;
                }
                // Önce araç çıkış yapmış mı kontrol edelim
                var aracCikisKontrol = entities.AracCikis.FirstOrDefault(c => c.Plaka.ToLower() == plaka.ToLower());
                if (aracCikisKontrol != null)
                {
                    MesajGoster.Uyari("Bu araç çıkış yapmış.");
                    return;
                }
                // Plakaya göre aracın bilgilerini alıyoruz
                var arac = entities.AracGiris.FirstOrDefault(a => a.Plaka.ToLower() == plaka.ToLower());

                if (arac == null)
                {
                    MesajGoster.Uyari("Araç bulunamadı!");
                    return;
                }

                // Araç türüne göre harfi belirlemek için switch kullanımı
                string harf = "";
                switch (arac.AracTuru)
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

                // Araçla ilişkili park yeri bilgisine erişim
                var parkyeriBul = entities.AracGiris
                    .FirstOrDefault(k => k.ParkYeri == arac.ParkYeri);

                if (parkyeriBul != null)
                {
                    // Park yeri bilgisi ve harfi birleştirip ekranda göstermek
                    string parkYeri = $"{harf}{parkyeriBul.ParkYeri}"; // Örneğin: A5, B2 vb.
                    _lblAracYeri.Text = $"Şurada: {parkYeri}";
                }
                else
                {
                    _lblAracYeri.Text = "Araç için park yeri bilgisi bulunamadı!";
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı gösterimi
                MesajGoster.Hata(ex.Message);
            }
        }



    }
}
