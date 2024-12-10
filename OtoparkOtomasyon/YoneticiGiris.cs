using System;

using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
            

        }

        private void btnUcretDuzenle_Click(object sender, EventArgs e)
        {
            btnAracUcretiDuzenle.Visible = true;
            btnAboneUcretiDuzenle.Visible=true;
        }

        private void btnAracUcretiDuzenle_Click(object sender, EventArgs e)
        {
            AracUcretDuzenle AracUcretiDuzenle = new AracUcretDuzenle();
            AracUcretiDuzenle.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiDogrulama yoneticiDogrulama = new YoneticiDogrulama();
            this.Close();
            yoneticiDogrulama.Show();
        }

        private void btnAboneUcretiDuzenle_Click(object sender, EventArgs e)
        {
            AboneUcretDuzenle aboneUcretDuzenle = new AboneUcretDuzenle();
            aboneUcretDuzenle.Show();
            this.Close();
        }

        private void btnAracKapasitesiAyarla_Click(object sender, EventArgs e)
        {
            AracKapasitesiAyarla aracKapasitesiAyarla = new AracKapasitesiAyarla();
            aracKapasitesiAyarla.Show();
            this.Hide();
        }

        private void btnPersonelTanimla_Click(object sender, EventArgs e)
        {
            PersonelTanimla personelTanimla = new PersonelTanimla();
            personelTanimla.Show();
            this.Hide();
        }

        private void btnKullaniciSifreDegistir_Click(object sender, EventArgs e)
        {
            KullaniciSifreDegistir kullaniciSifreDegistir = new KullaniciSifreDegistir();
            kullaniciSifreDegistir.Show();
            this.Hide();
        }

        private void btnUcretsizAracGirisi_Click(object sender, EventArgs e)
        {
            UcretsizAraçGirisiTanimla ucretsizAraçGirisiTanimla = new UcretsizAraçGirisiTanimla();
            ucretsizAraçGirisiTanimla.Show();
            this.Hide();
        }

        private void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            RaporOlustur raporOlustur = new RaporOlustur();
            raporOlustur.Show();
            this.Hide();
        }

        private void YoneticiGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
