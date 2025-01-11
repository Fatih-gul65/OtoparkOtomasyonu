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
        Baglanti baglanti = new Baglanti();
        public YoneticiDogrulama()
        {
            InitializeComponent();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string YoneticiAdi = txtYoneticiAdiGiris.Text.Trim();
            string YoneticiSifre = txtYoneticiSifreGiris.Text.Trim();
            try
            {
                if (YoneticiAdi == "" || YoneticiSifre == "")
                {
                    MesajGoster.Uyari("Lütfen Boş Olan Alanları Doldurunuz");
                }
                else
                {
                    var entities = baglanti.Entity();
                    
                    var yonetici = entities.Yonetici.FirstOrDefault(y => y.YoneticiAdi == YoneticiAdi && y.YoneticiSifre == YoneticiSifre);

                    if (yonetici != null)
                    {
                        YoneticiGiris giris = new YoneticiGiris();
                        giris.Show();
                        this.Close();
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
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MesajGoster.OnayAl("Uygulamayı kapatmak istiyor musunuz?");

            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                YoneticiDogrulama ac = new YoneticiDogrulama();
                ac.Show();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtYoneticiSifreGiris.PasswordChar == '*')
            {
                txtYoneticiSifreGiris.PasswordChar = '\0';
                pictureBox3.Image = Properties.Resources.acikgoz;
            }
            else
            {
                txtYoneticiSifreGiris.PasswordChar = '*';
                pictureBox3.Image = Properties.Resources.kapaligoz;
            }
        }
        private void YoneticiDogrulama_Load(object sender, EventArgs e)
        {
            txtYoneticiSifreGiris.PasswordChar = '*';
        }
    }
}
