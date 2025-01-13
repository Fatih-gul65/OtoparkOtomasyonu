using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class frm_PersonelDogrula : Form
    {
        cs_Baglanti baglanti = new cs_Baglanti();
        public frm_PersonelDogrula()
        {
            InitializeComponent();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var entities = baglanti.Entity();

                bool kullanici = entities.PersonelGirisTanimla.Any(x => x.KullaniciAdi == txtKullaniciAdiGiris.Text && x.KullaniciSifre == txtKullaniciSifreGiris.Text);
                if (kullanici)
                {
                    frm_PersonelGirisi personelGirisi = new frm_PersonelGirisi();
                    personelGirisi.Show();
                    this.Close();
                }
                else
                {
                    cs_MesajGoster.Hata("Kullanıcı Adı Veya Şifresi Yanlış \n Lütfen Bilgileri Kontrol Edip Tekrar Deneyin !");
                }
            }
            catch (Exception ex) {
      
                cs_MesajGoster.Hata(ex.Message);
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_Anasayfa anasayfa = new frm_Anasayfa();
            anasayfa.Show();
            this.Close();
        }
        private void PersonelDogrula_Load(object sender, EventArgs e)
        {
            txtKullaniciSifreGiris.PasswordChar = '*';
            try
            {
                var entities = baglanti.Entity();
                bool KullaniciVarMi = entities.PersonelGirisTanimla.Any();

                if (KullaniciVarMi == false)
                {
                    cs_MesajGoster.Bilgi(" Herhangi Bir Kullanıcı Bulunamadı !\n Giriş Elemanlarının Gelmesi İçin Yönetici Panelinden Kullanıcı Tanımlayınız !");
                }
                else
                {
                    btnGiris.Visible = true;
                    txtKullaniciAdiGiris.Visible = true;
                    txtKullaniciSifreGiris.Visible = true;
                    lblKullaniciAdi.Visible = true;
                    lblKullaniciSifre.Visible = true;
                    pictureBox3.Visible = true;
                }
            }
            catch (Exception ex)
            {
                cs_MesajGoster.Hata(ex.Message);
            }
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
                frm_PersonelDogrula ac = new frm_PersonelDogrula();
                ac.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtKullaniciSifreGiris.PasswordChar == '*')
            {
                txtKullaniciSifreGiris.PasswordChar = '\0';
                pictureBox3.Image = Properties.Resources.acikgoz;
            }
            else
            {
                txtKullaniciSifreGiris.PasswordChar = '*';
                pictureBox3.Image = Properties.Resources.kapaligoz;
            }
        }
    }
}
