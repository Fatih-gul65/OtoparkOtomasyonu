using System;
using System.Linq;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class AracUcretDuzenle : Form
    {
        OtoparkOtomasyonEntities2 entities = new OtoparkOtomasyonEntities2();
        int AracID = 0;
        string aracTuru = "";
        public AracUcretDuzenle()
        {
            InitializeComponent();
        }

        // text box ların içini dolduran fonksiyon yazıldı
        private void UcretYazdir(int aracID)
        {
            var Yazdir = entities.AracUcretleri.FirstOrDefault(x => x.AracUcretID == aracID);
            if (Yazdir != null)
            {
                txt_0_3_Saat.Text = Yazdir.AracUcret03.ToString();
                txt_3_6_Saat.Text = Yazdir.AracUcret36.ToString();
                txt_6_24_Saat.Text = Yazdir.AracUcret61.ToString();
                txt_24_SaatUzeri.Text = Yazdir.AracUcretBirGunUzeri.ToString();
            }
            else
            {
                txt_0_3_Saat.Clear();
                txt_3_6_Saat.Clear();
                txt_6_24_Saat.Clear();
                txt_24_SaatUzeri.Clear();
            }
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris geri = new YoneticiGiris();
            geri.Show();
            this.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (AracID == 0 || string.IsNullOrWhiteSpace(txt_0_3_Saat.Text) ||
                string.IsNullOrWhiteSpace(txt_3_6_Saat.Text) ||
                string.IsNullOrWhiteSpace(txt_6_24_Saat.Text) ||
                string.IsNullOrWhiteSpace(txt_24_SaatUzeri.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun ve araç türünü seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else {

                try { 
                    if (AracID == 1 || AracID == 2 || AracID == 3) { 
                        var aracUcret = entities.AracUcretleri.FirstOrDefault(x => x.AracUcretID == AracID);
                        if (aracUcret != null) {
                            aracUcret.AracUcret03 = Convert.ToDecimal((txt_0_3_Saat.Text.Trim()));
                            aracUcret.AracUcret36 = Convert.ToDecimal((txt_3_6_Saat.Text.Trim()));
                            aracUcret.AracUcret61 = Convert.ToDecimal((txt_6_24_Saat.Text.Trim()));
                            aracUcret.AracUcretBirGunUzeri = Convert.ToDecimal((txt_24_SaatUzeri.Text.Trim()));

                            entities.SaveChanges();
                            MessageBox.Show("Ücretler başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            AracUcretleri Ekle = new AracUcretleri();
                            Ekle.AracUcretID = AracID;
                            Ekle.AracUcret03 = Convert.ToDecimal((txt_0_3_Saat.Text.Trim()));
                            Ekle.AracUcret36 = Convert.ToDecimal((txt_3_6_Saat.Text.Trim()));
                            Ekle.AracUcret61 = Convert.ToDecimal((txt_6_24_Saat.Text.Trim()));
                            Ekle.AracUcretBirGunUzeri = Convert.ToDecimal((txt_24_SaatUzeri.Text.Trim()));
                            Ekle.AracTuru = aracTuru;
                            entities.AracUcretleri.Add(Ekle);
                            entities.SaveChanges();
                            MessageBox.Show("Yeni ücret kaydı başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz araç türü seçildi. Lütfen geçerli bir araç türü seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı : " + ex.Message);
                }
            }
        }

        // Radio butonlarından hangisi seçilirse ona ait bilgiler text box lara dolduruldu eğer kayıt yoksa text box lar temizlendi 
        private void rdbtnOtomobil_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnOtomobil.Checked)
            {
                AracID = 1;
                aracTuru = "Otomobil";
                UcretYazdir(AracID);
            }
        }

        private void rdbtnKamyonet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnKamyonet.Checked)
            {
                AracID = 2;
                aracTuru = "Kamyonet";
                UcretYazdir(AracID);
            }
        }

        private void rdbtnMinibus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnMinibus.Checked)
            {
                AracID = 3;
                aracTuru = "Minibüs/Kamyon";
                UcretYazdir(AracID);
            }
        }
        
    }
}
