using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class frm_KullaniciSifreDegistir : Form
    {
        cs_YoneticiSifre _islemler;
        public frm_KullaniciSifreDegistir()
        {
            InitializeComponent();
            _islemler = new cs_YoneticiSifre(txtYoneticiAdi, txtYoneticiSifre);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_YoneticiGiris yoneticiGiris = new frm_YoneticiGiris();
            yoneticiGiris.Show();
            this.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _islemler.Ekle();
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
                frm_KullaniciSifreDegistir ac = new frm_KullaniciSifreDegistir();
                ac.Show();
            }
        }
    }
}
