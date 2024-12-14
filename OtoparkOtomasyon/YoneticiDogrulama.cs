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
                    string kontrol = "Select * from Yonetici where YoneticiAdi = @YoneticiAdi AND YoneticiSifre = @YoneticiSifre";
                    SqlCommand komut = new SqlCommand(kontrol, baglanti);
                    komut.Parameters.AddWithValue("@YoneticiAdi", YoneticiAdi);
                    komut.Parameters.AddWithValue("@YoneticiSifre", YoneticiSifre);
                    SqlDataReader sdr = komut.ExecuteReader();
                    if (sdr.Read())
                    {
                        YoneticiGiris giris = new YoneticiGiris();
                        giris.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Bilgi Girişi Yaptınız , Lütfen Tekrar Deneyiniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { 
                baglanti.Close();
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
