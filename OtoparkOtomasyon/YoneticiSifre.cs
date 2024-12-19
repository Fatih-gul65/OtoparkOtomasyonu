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
            SqlConnection con = null;
            try
            {                
                con = _baglanti.SqlBaglanti();

                if (YoneticiAdi == "" || YoneticiSifre == "")
                {
                    MesajGoster.Uyari("Lütfen Boş Olan Alanları Doldurunuz");
                }
                else
                {
                    con.Open();
                    string guncelle = "update Yonetici SET YoneticiAdi = @YoneticiAdi , YoneticiSifre = @YoneticiSifre where YoneticiID = 1";
                    SqlCommand komut = new SqlCommand(guncelle, con);
                    komut.Parameters.AddWithValue("@YoneticiAdi", YoneticiAdi);
                    komut.Parameters.AddWithValue("@YoneticiSifre", YoneticiSifre);
                    int sonuc = komut.ExecuteNonQuery();

                    if (sonuc == 1)
                    {
                        MesajGoster.Bilgi("Yönetici Adınız : " + YoneticiAdi + "\n Yönetici Şifreniz : " + YoneticiSifre + "\n Olarak belirlenmiştir !");
                        _txtYoneticiAdi.Clear();
                        _txtYoneticiSifre.Clear();
                    }
                    else
                    {
                        MesajGoster.Hata("Güncelleme tamamlanamadı");
                    }
                }
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }       
    }
}
