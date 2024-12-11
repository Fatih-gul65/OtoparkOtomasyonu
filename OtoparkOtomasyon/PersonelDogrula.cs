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
        OtoparkOtomasyonEntities entities = new OtoparkOtomasyonEntities();
        public PersonelDogrula()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            

                var kullanici = entities.PersonelGirisTanimla.FirstOrDefault(x => x.KullaniciAdi == txtKullaniciAdiGiris.Text && x.KullaniciSifre == txtKullaniciSifreGiris.Text);
                if (kullanici != null) {
                    PersonelGirisi personelGirisi = new PersonelGirisi();
                    personelGirisi.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şifresi Yanlış \n Lütfen Bilgileri Kontrol Edip Tekrar Deneyin !" , "Hata" , MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            bool KullaniciVarMi = entities.PersonelGirisTanimla.Any();

            if (KullaniciVarMi == false)
            {
                MessageBox.Show("Herhangi Bir Kullanıcı Bulunamadı ! \n Yönetici ,Panelden Kullanıcı Tanımlayın Ve Sonra Tekrar Deneyiniz. \n Sayfa Açılacak Fakat Giriş İçin Gerekli Elemanlar Gelmeyecektir. \n Giriş Elemanlarının Gelmesi İçin Yönetici Panelinden Kullanıcı Tanımlayınız !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGiris.Visible = false;
            }
            else
            {
                // Eğer Kayıtlı Kullanıcı Varsa Label Ve TextBox'ları göster
                txtKullaniciAdiGiris.Visible = true;
                txtKullaniciSifreGiris.Visible = true;
                lblKullaniciAdi.Visible = true;
                lblKullaniciSifre.Visible = true;
            }
        }
    }
}
