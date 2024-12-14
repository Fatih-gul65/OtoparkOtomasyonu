using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class KullaniciSifreDegistir : Form
    {
        public KullaniciSifreDegistir()
        {
            InitializeComponent();
        }



        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            yoneticiGiris.Show();
            this.Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // yonetici adı ve şifresi değiştirildi
            string YoneticiAdi = txtYoneticiAdi.Text.Trim();
            string YoneticiSifre = txtYoneticiSifre.Text.Trim();
            SqlConnection baglanti = new SqlConnection(@"Data Source=FATIH\SQLEXPRESS;Initial Catalog=OtoparkOtomasyon;Integrated Security=True;");
            try
            {
                if (YoneticiAdi == "" || YoneticiSifre == "")
                {
                    MessageBox.Show("Lütfen Boş Olan Alanları Doldurunuz");
                }
                else
                {
                    baglanti.Open();
                    string guncelle = "update Yonetici SET YoneticiAdi = @YoneticiAdi , YoneticiSifre = @YoneticiSifre where YoneticiID = 1";
                    SqlCommand komut = new SqlCommand(guncelle, baglanti);
                    komut.Parameters.AddWithValue("@YoneticiAdi", YoneticiAdi);
                    komut.Parameters.AddWithValue("@YoneticiSifre", YoneticiSifre);
                    int sonuc = komut.ExecuteNonQuery();
                    
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Yönetici Adınız : "+ YoneticiAdi + "\n Yönetici Şifreniz : " + YoneticiSifre + "\n Olarak belirlenmiştir !" , "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("Güncelleme tamamlanamadı" ,"Hata" ,MessageBoxButtons.OK , MessageBoxIcon.Error);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void KullaniciSifreDegistir_Load(object sender, EventArgs e)
        {

        }
    }
}
