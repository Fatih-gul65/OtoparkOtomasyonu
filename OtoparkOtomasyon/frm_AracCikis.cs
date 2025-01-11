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
    public partial class frm_AracCikis : Form
    {
        cs_AracCikis _islemler;
        cs_Baglanti baglanti = new cs_Baglanti();
        public frm_AracCikis()
        {
            InitializeComponent();
            _islemler = new cs_AracCikis(baglanti, txtAracPlakasi, txtDogrulamaKodu, lblTutar, lblKalinanSure, rdbtnNakit,rdbtnKrediKart);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_PersonelGirisi personelGirisi = new frm_PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }
        private void btnUcretHesapla_Click_1(object sender, EventArgs e)
        {
            _islemler.Hesapla();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _islemler.Kaydet();
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
                frm_AracCikis ac = new frm_AracCikis();
                ac.Show();
            }
        }
    }
}
