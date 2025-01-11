using System;

using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class frm_YoneticiGiris : Form
    {
        public frm_YoneticiGiris()
        {
            InitializeComponent();
        }
        private void btnUcretDuzenle_Click(object sender, EventArgs e)
        {
            btnAracUcretiDuzenle.Visible = !btnAracUcretiDuzenle.Visible;
            btnAboneUcretiDuzenle.Visible= !btnAboneUcretiDuzenle.Visible;
        }
        private void btnAracUcretiDuzenle_Click(object sender, EventArgs e)
        {
            frm_AracUcretDuzenle AracUcretiDuzenle = new frm_AracUcretDuzenle();
            AracUcretiDuzenle.Show();
            this.Close();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_YoneticiDogrulama yoneticiDogrulama = new frm_YoneticiDogrulama();
            this.Close();
            yoneticiDogrulama.Show();
        }
        private void btnAboneUcretiDuzenle_Click(object sender, EventArgs e)
        {
            frm_AboneUcretDuzenle aboneUcretDuzenle = new frm_AboneUcretDuzenle();
            aboneUcretDuzenle.Show();
            this.Close();
        }
        private void btnAracKapasitesiAyarla_Click(object sender, EventArgs e)
        {
            frm_KapasiteAyarla aracKapasitesiAyarla = new frm_KapasiteAyarla();
            aracKapasitesiAyarla.Show();
            this.Close();
        }
        private void btnPersonelTanimla_Click(object sender, EventArgs e)
        {
            frm_PersonelTanimla personelTanimla = new frm_PersonelTanimla();
            personelTanimla.Show();
            this.Close();
        }
        private void btnKullaniciSifreDegistir_Click(object sender, EventArgs e)
        {
            frm_KullaniciSifreDegistir kullaniciSifreDegistir = new frm_KullaniciSifreDegistir();
            kullaniciSifreDegistir.Show();
            this.Close();
        }
        private void btnUcretsizAracGirisi_Click(object sender, EventArgs e)
        {
            frm_UcretsizAracGiris ucretsizAraçGirisiTanimla = new frm_UcretsizAracGiris();
            ucretsizAraçGirisiTanimla.Show();
            this.Close();
        }
        private void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            frm_Rapor raporOlustur = new frm_Rapor();
            raporOlustur.Show();
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
                frm_YoneticiGiris ac = new frm_YoneticiGiris();
                ac.Show();
            }
        }
    }
}
