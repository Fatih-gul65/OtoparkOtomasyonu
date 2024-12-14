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
    public partial class AboneUcretDuzenle : Form
    {
        OtoparkOtomasyonEntities entities = new OtoparkOtomasyonEntities();
        public AboneUcretDuzenle()
        {
            InitializeComponent();
        }

        int AUcretID = 0;
        string AracTuru = "";

        private void UcretYazdir(int aucretID)
        {
            var Yazdir = entities.AboneUcret.FirstOrDefault(x => x.AboneUcretID == aucretID);
            if (Yazdir != null)
            {
                txtAboneUcreti.Text = Yazdir.AboneUcret1.ToString();

            }
            else
            {
                txtAboneUcreti.Clear();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris geri = new YoneticiGiris();
            geri.Show();
            this.Hide();
        }

        private void rdbtnOtomobil_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnOtomobil.Checked)
            {
                AUcretID = 1;
                AracTuru = "Otomobil";
                UcretYazdir(AUcretID);
            }
        }

        private void rdbtnKamyonet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnKamyonet.Checked)
            {
                AUcretID = 2;
                AracTuru = "Kamyonet";
                UcretYazdir(AUcretID);
            }
        }

        private void rdbtnMinibus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnMinibus.Checked)
            {
                AUcretID = 3;
                AracTuru = "Minibüs / Kamyon";
                UcretYazdir(AUcretID);
            }
        }

        private void AboneUcretDuzenle_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (AUcretID == 0 || string.IsNullOrWhiteSpace(txtAboneUcreti.Text))
            {
                MessageBox.Show("Lütfen bir araç türü seçin ve abone ücretini girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    var aboneUcret = entities.AboneUcret.FirstOrDefault(x => x.AboneUcretID == AUcretID);

                    if (aboneUcret != null)
                    {
                        aboneUcret.AboneUcret1 = Convert.ToDecimal(txtAboneUcreti.Text.Trim());
                        entities.SaveChanges();
                        MessageBox.Show("Abone ücreti başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        AboneUcret Ekle = new AboneUcret();

                        Ekle.AboneUcretID = AUcretID;
                        Ekle.AboneAracTuru = AracTuru;
                        Ekle.AboneUcret1 = Convert.ToDecimal(txtAboneUcreti.Text.Trim());
                        Ekle.AboneSuresi = 30;

                        entities.AboneUcret.Add(Ekle);
                        entities.SaveChanges();
                        MessageBox.Show("Yeni abone ücreti başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı : " + ex.Message);
                }
            }


        }
    }
}
