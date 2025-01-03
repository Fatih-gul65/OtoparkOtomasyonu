using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    internal class YoneticiSifre
    {
        private Baglanti _baglanti;
        private TextBox _txtYoneticiAdi, _txtYoneticiSifre;
        public YoneticiSifre(TextBox txtYoneticiAdi , TextBox txtYoneticiSifre) {
            _baglanti = new Baglanti();
            _txtYoneticiAdi = txtYoneticiAdi;
            _txtYoneticiSifre = txtYoneticiSifre;
        }
        public void Ekle()
        {
            string YoneticiAdi = _txtYoneticiAdi.Text.Trim();
            string YoneticiSifre = _txtYoneticiSifre.Text.Trim();
            try
            {
                if (string.IsNullOrEmpty(YoneticiAdi) || string.IsNullOrEmpty(YoneticiSifre))
                {
                    MesajGoster.Uyari("Lütfen Boş Olan Alanları Doldurunuz");
                }
                else
                {
                    var entities = _baglanti.Entity();                    
                    var yonetici = entities.Yonetici.SingleOrDefault(y => y.YoneticiID == 1);
                    if (yonetici != null)
                    {
                        yonetici.YoneticiAdi = YoneticiAdi;
                        yonetici.YoneticiSifre = YoneticiSifre;
                        entities.SaveChanges();
                        MesajGoster.Bilgi("Yönetici Adınız : " + YoneticiAdi + "\n Yönetici Şifreniz : " + YoneticiSifre + "\n Olarak Güncellenmiştir !");
                        _txtYoneticiAdi.Clear();
                        _txtYoneticiSifre.Clear();
                    }                  
                }
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
        }
    }
}
