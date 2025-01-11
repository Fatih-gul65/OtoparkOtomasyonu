using OtoparkOtomasyon;
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
    public partial class frm_AracBul : Form
    {
        cs_Baglanti baglanti = new cs_Baglanti();
        cs_AracBul _islemler;
        public frm_AracBul()
        {
            InitializeComponent();
            _islemler = new cs_AracBul(baglanti, txtPlaka, lblAracYeri);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_PersonelGirisi personelGirisi = new frm_PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }
        private void btnAracBul_Click_1(object sender, EventArgs e)
        {
            _islemler.aracBul();
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
                frm_AracBul ac = new frm_AracBul();
                ac.Show();
            }
        }
    }
}
