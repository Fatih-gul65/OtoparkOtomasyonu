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
    public partial class PersonelDogrula : Form
    {
        Baglanti baglanti = new Baglanti();
        public PersonelDogrula()
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
                    PersonelGirisi personelGirisi = new PersonelGirisi();
                    personelGirisi.Show();
                    this.Close();
                }
                else
                {
                    MesajGoster.Hata("Kullanıcı Adı Veya Şifresi Yanlış \n Lütfen Bilgileri Kontrol Edip Tekrar Deneyin !");
                }
            }
            catch (Exception ex) {
      
                MessageBox.Show("Bir hata ile karşılaşıldı : " + ex.Message);
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();
        }
        private void PersonelDogrula_Load(object sender, EventArgs e)
        {
            txtKullaniciSifreGiris.PasswordChar = '*';
            try {
                var entities = baglanti.Entity();
                bool KullaniciVarMi = entities.PersonelGirisTanimla.Any();

                if (KullaniciVarMi == false)
                {
                    MesajGoster.Bilgi(" Herhangi Bir Kullanıcı Bulunamadı ! \n Yönetici ,Panelden Kullanıcı Tanımlayın Ve Sonra Tekrar Deneyiniz. \n Sayfa Açılacak Fakat Giriş İçin Gerekli Elemanlar Gelmeyecektir. \n Giriş Elemanlarının Gelmesi İçin Yönetici Panelinden Kullanıcı Tanımlayınız !");
                    btnGiris.Visible = false;
                }
                else
                {
                    txtKullaniciAdiGiris.Visible = true;
                    txtKullaniciSifreGiris.Visible = true;
                    lblKullaniciAdi.Visible = true;
                    lblKullaniciSifre.Visible = true;
                    pictureBox3.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MesajGoster.Hata(ex.Message);
            }
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
                PersonelDogrula ac = new PersonelDogrula();
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
