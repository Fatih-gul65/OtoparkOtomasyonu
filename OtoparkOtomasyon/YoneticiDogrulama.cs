using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoparkOtomasyon
{
    public partial class YoneticiDogrulama : Form
    {
        public YoneticiDogrulama()
        {
            InitializeComponent();           
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string YoneticiAdi = txtYoneticiAdiGiris.Text.Trim();
            string YoneticiSifre = txtYoneticiSifreGiris.Text.Trim();
            SqlConnection con = null;
            try
            {
                Baglanti baglanti  = new Baglanti();

                con = baglanti.SqlBaglanti();

                if (YoneticiAdi == "" || YoneticiSifre == "")
                {
                    MesajGoster.Uyari("Lütfen Boş Olan Alanları Doldurunuz");
                }
                else
                {
                    con.Open();
                    string kontrol = "Select * from Yonetici where YoneticiAdi = @YoneticiAdi AND YoneticiSifre = @YoneticiSifre";
                    SqlCommand komut = new SqlCommand(kontrol, con);
                    komut.Parameters.AddWithValue("@YoneticiAdi", YoneticiAdi);
                    komut.Parameters.AddWithValue("@YoneticiSifre", YoneticiSifre);
                    SqlDataReader sdr = komut.ExecuteReader();
                    if (sdr.Read())
                    {
                        YoneticiGiris giris = new YoneticiGiris();
                        YoneticiDogrulama sayfa = new YoneticiDogrulama();
                        giris.Show();
                        sayfa.Close();
                    }
                    else
                    {
                        MesajGoster.Hata("Hatalı Bilgi Girişi Yaptınız , Lütfen Tekrar Deneyiniz !");
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
            
            
            

            
            
            
            
            
            
           
            
        

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void YoneticiDogrulama_Load(object sender, EventArgs e)
        {

        }
    }
}
