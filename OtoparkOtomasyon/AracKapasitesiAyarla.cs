using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class AracKapasitesiAyarla : Form
    {
        KapasiteAyarla _islemler;
        public AracKapasitesiAyarla()
        {
            InitializeComponent();
            _islemler = new KapasiteAyarla(rdbtnOtomobil, rdbtnKamyonet, rdbtnMinibus, txtKapasiteAyarla);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            this.Close();
            yoneticiGiris.Show();
        }       
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _islemler.Ekle();
        }
        private void txtKapasiteAyarla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (txtKapasiteAyarla.Text.Length >= 10 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void rdbtnOtomobil_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnOtomobil.Checked)
            {
                _islemler.AracKapasitesiniYazdir("Otomobil");
            }
        }
        private void rdbtnKamyonet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnKamyonet.Checked)
            {
                _islemler.AracKapasitesiniYazdir("Kamyonet");
            }
        }
        private void rdbtnMinibus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnMinibus.Checked)
            {
                _islemler.AracKapasitesiniYazdir("Minibüs/Kamyon");
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
                AracKapasitesiAyarla ac = new AracKapasitesiAyarla();
                ac.Show();
            }
        }
    }
}
