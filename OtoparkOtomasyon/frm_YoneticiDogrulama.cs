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
    public partial class frm_YoneticiDogrulama : Form
    {
        cs_Baglanti baglanti = new cs_Baglanti();
        public frm_YoneticiDogrulama()
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
                    cs_MesajGoster.Uyari("Lütfen Boş Olan Alanları Doldurunuz");
                }
                else
                {
                    var entities = baglanti.Entity();
                    
                    var yonetici = entities.Yonetici.FirstOrDefault(y => y.YoneticiAdi == YoneticiAdi && y.YoneticiSifre == YoneticiSifre);

                    if (yonetici != null)
                    {
                        frm_YoneticiGiris giris = new frm_YoneticiGiris();
                        giris.Show();
                        this.Close();
                    }
                    else
                    {
                        cs_MesajGoster.Hata("Hatalı Bilgi Girişi Yaptınız , Lütfen Tekrar Deneyiniz !");
                    }                    
                }
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_Anasayfa anasayfa = new frm_Anasayfa();
            anasayfa.Show();
            this.Close();
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = cs_MesajGoster.OnayAl("Uygulamayı kapatmak istiyor musunuz?");

            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                frm_YoneticiDogrulama ac = new frm_YoneticiDogrulama();
                ac.Show();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtYoneticiSifreGiris.UseSystemPasswordChar = !txtYoneticiSifreGiris.UseSystemPasswordChar;

            if (txtYoneticiSifreGiris.UseSystemPasswordChar)
            {
                pictureBox3.Image = Properties.Resources.acikgoz;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.kapaligoz;
            }
        }
    }
}
