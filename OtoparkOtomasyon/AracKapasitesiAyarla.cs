using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class AracKapasitesiAyarla : Form
    {
        OtoparkOtomasyonEntities2 entities = new OtoparkOtomasyonEntities2();
        public AracKapasitesiAyarla()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            this.Close();
            yoneticiGiris.Show();
        }

        private void AracKapasitesiAyarla_Load(object sender, EventArgs e)
        {

        }

        private void AracKapasitesiniYazdir(string secim)
        {
            var kapasite = entities.AracKapasitesi.FirstOrDefault(x => x.KapasiteID == 1);

            if (kapasite != null)
            {
                // Seçilen araç türüne göre kapasiteyi yazdır
                if (secim == "Otomobil")
                {
                    txtKapasiteAyarla.Text = kapasite.OtomobilKapasitesi.ToString();
                }
                else if (secim == "Kamyonet")
                {
                    txtKapasiteAyarla.Text = kapasite.KamyonetKapasitesi.ToString();
                }
                else if (secim == "Minibüs/Kamyon")
                {
                    txtKapasiteAyarla.Text = kapasite.MinibusKapasitesi.ToString();
                }
            }
        }

        private void KaydetVeyaGuncelle(string secim, int kapasiteDegeri)
        {
            var kontrol = entities.AracKapasitesi.FirstOrDefault(x => x.KapasiteID == 1);

            if (kontrol == null)
            {
                kontrol = new AracKapasitesi();
                kontrol.KapasiteID = 1;
                entities.AracKapasitesi.Add(kontrol);
            }
          
            if (secim == "Otomobil") kontrol.OtomobilKapasitesi = kapasiteDegeri;
            else if (secim == "Kamyonet") kontrol.KamyonetKapasitesi = kapasiteDegeri;
            else if (secim == "Minibüs/Kamyon") kontrol.MinibusKapasitesi = kapasiteDegeri;

            entities.SaveChanges();
            
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string secim = "";
            if (rdbtnOtomobil.Checked) secim = "Otomobil";
            else if (rdbtnKamyonet.Checked) secim = "Kamyonet";
            else if (rdbtnMinibus.Checked) secim = "Minibüs/Kamyon";

            if (string.IsNullOrWhiteSpace(txtKapasiteAyarla.Text) || secim == "")
            {
                MessageBox.Show("Lütfen bir araç türü seçin ve otoparkın seçtiğiniz araç türü için kapasitesini girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else { 
               
                try
                {
                    int kapasiteDegeri = Convert.ToInt32(txtKapasiteAyarla.Text);
                    KaydetVeyaGuncelle(secim, kapasiteDegeri);
                    MessageBox.Show(secim + " Kapasiteniz : " + txtKapasiteAyarla.Text + " Olarak Belirlendi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtKapasiteAyarla.Clear();
                }
                catch(Exception ex) {
                    MessageBox.Show("Bir hata ile karşılaşıldı : " + ex.Message);
                }
            }
        }

        private void txtKapasiteAyarla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rdbtnOtomobil_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnOtomobil.Checked)
            {
                AracKapasitesiniYazdir("Otomobil");
            }
        }

        private void rdbtnKamyonet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnKamyonet.Checked)
            {
                AracKapasitesiniYazdir("Kamyonet");
            }
        }

        private void rdbtnMinibus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnMinibus.Checked)
            {
                AracKapasitesiniYazdir("Minibüs/Kamyon");
            }
        }
    }
}
