using System;
using System.Linq;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class frm_AracUcretDuzenle : Form
    {
        private cs_AracUcretDuzenle _islemler;

        int AracID = 0;
        string aracTuru = "";
        public frm_AracUcretDuzenle()
        {
            InitializeComponent();
            _islemler = new cs_AracUcretDuzenle(txt_0_3_Saat, txt_3_6_Saat, txt_6_24_Saat, txt_24_SaatUzeri);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_YoneticiGiris geri = new frm_YoneticiGiris();
            geri.Show();
            this.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _islemler.Ekle(AracID, aracTuru);
        }
        private void rdbtnOtomobil_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnOtomobil.Checked)
            {
                AracID = 1;
                aracTuru = "Otomobil";
                _islemler.UcretYazdir(AracID);
            }
        }
        private void rdbtnKamyonet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnKamyonet.Checked)
            {
                AracID = 2;
                aracTuru = "Kamyonet";
                _islemler.UcretYazdir(AracID);
            }
        }
        private void rdbtnMinibus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnMinibus.Checked)
            {
                AracID = 3;
                aracTuru = "Minibüs/Kamyon";
                _islemler.UcretYazdir(AracID);
            }
        }
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if ((!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) || (txtBox.Text.Length >= 10 && e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }
        private void AracUcretDuzenle_Load(object sender, EventArgs e)
        {
            txt_0_3_Saat.KeyPress += txtBox_KeyPress;
            txt_3_6_Saat.KeyPress += txtBox_KeyPress;
            txt_6_24_Saat.KeyPress += txtBox_KeyPress;
            txt_24_SaatUzeri.KeyPress += txtBox_KeyPress;
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
                frm_AracUcretDuzenle ac = new frm_AracUcretDuzenle();
                ac.Show();
            }
        }
    }
}
