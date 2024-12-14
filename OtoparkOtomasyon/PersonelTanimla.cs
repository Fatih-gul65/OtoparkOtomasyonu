using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class PersonelTanimla : Form
    {
        OtoparkOtomasyonEntities entities = new OtoparkOtomasyonEntities();

        public PersonelTanimla()
        {
            InitializeComponent();
            
            
        }
        private void tumKayitlariGoster()
        {
            var personeller = entities.PersonelGirisTanimla.ToList();
            datagridPersonelTanimla.DataSource = personeller;
            datagridPersonelTanimla.ClearSelection();
            KutulariBosalt();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            this.Close();
            yoneticiGiris.Show();
        }
        private void PersonelTanimla_Load(object sender, EventArgs e)
        {
            tumKayitlariGoster();
        }
        private void KutulariBosalt()
        {
            txtKullaniciID.Clear();
            txtKullaniciAdi.Clear();
            txtKullaniciSifre.Clear();
        }
        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtKullaniciAdi.Text.Trim()) || string.IsNullOrEmpty(txtKullaniciSifre.Text.Trim()))
                {
                    MessageBox.Show("Lütfen Boş Olan Alanları Doldurunuz","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {

                    bool kullaniciVarMi = entities.PersonelGirisTanimla.Any(x => x.KullaniciAdi == txtKullaniciAdi.Text.Trim());

                    if (kullaniciVarMi) {
                        MessageBox.Show("Bu Kullanıcı Adına Sahip Başka Bir Kayıt Bulunmaktadır \n Başka Bir Kullanıcı Adı Belirleyiniz Veya Varolan Kullanıcıyı Güncelleyiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        PersonelGirisTanimla Ekle = new PersonelGirisTanimla();
                        Ekle.KullaniciAdi = txtKullaniciAdi.Text.Trim();
                        Ekle.KullaniciSifre = txtKullaniciSifre.Text.Trim();
                        Ekle.TanimlanmaTarihi = DateTime.Now;
                        entities.PersonelGirisTanimla.Add(Ekle);
                        entities.SaveChanges();
                        MessageBox.Show("Kayıt Eklendi" ,"Bilgi", MessageBoxButtons.OK , MessageBoxIcon.Information);
                        tumKayitlariGoster();
                    }
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Bir hata ile karşılaşıldı : " + ex.Message);  
            }
        }

        private void datagridPersonelTanimla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatır = datagridPersonelTanimla.SelectedCells[0].RowIndex;
            txtKullaniciID.Text = datagridPersonelTanimla.Rows[secilenSatır].Cells[0].Value.ToString();
            txtKullaniciAdi.Text = datagridPersonelTanimla.Rows[secilenSatır].Cells[1].Value.ToString();
            txtKullaniciSifre.Text = datagridPersonelTanimla.Rows[secilenSatır].Cells[2].Value.ToString();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            try { 
            int KullaniciId = Convert.ToInt32(txtKullaniciID.Text);
            var kullanici = entities.PersonelGirisTanimla.Find(KullaniciId);
            entities.PersonelGirisTanimla.Remove(kullanici);
            entities.SaveChanges();
            MessageBox.Show("Seçili Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tumKayitlariGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı : " + ex.Message);
            }
        }

        private void btnSecilenKullaniciyiGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int KullaniciId = Convert.ToInt32(txtKullaniciID.Text);
                var kullanici = entities.PersonelGirisTanimla.Find(KullaniciId);

                if (kullanici.KullaniciAdi == txtKullaniciAdi.Text && kullanici.KullaniciSifre == txtKullaniciSifre.Text)
                {
                    MessageBox.Show("Güncelleme İşlemi Başarısız. \n Girilen Bilgiler İle Mevcut Bilgiler Aynıdır !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtKullaniciAdi.Text == "" || txtKullaniciSifre.Text == "")
                    {
                        MessageBox.Show("Lütfen Boş Olan Alanları Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        bool kullaniciVarMi = entities.PersonelGirisTanimla.Any(x => x.KullaniciAdi == txtKullaniciAdi.Text && x.KullaniciID != KullaniciId);
                        if (kullaniciVarMi)
                        {
                            MessageBox.Show("Güncelleme İşlemi Başarısız! \n Bu Kullanıcı Adına Sahip Başka Bir Kayıt Bulunmaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            kullanici.KullaniciAdi = txtKullaniciAdi.Text;
                            kullanici.KullaniciSifre = txtKullaniciSifre.Text;
                            entities.SaveChanges();
                            MessageBox.Show("Seçili Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tumKayitlariGoster();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı : " + ex.Message);
            }
        }
    }
}
