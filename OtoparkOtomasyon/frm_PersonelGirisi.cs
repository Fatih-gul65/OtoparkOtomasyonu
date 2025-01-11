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
    public partial class frm_PersonelGirisi : Form
    {
        public frm_PersonelGirisi()
        {
            InitializeComponent();
        }
        private void btnAracGiris_Click_1(object sender, EventArgs e)
        {
            frm_AracGiris form2 = new frm_AracGiris();
            form2.Show();
            this.Close();
        }
        private void btnAracCikis_Click_1(object sender, EventArgs e)
        {
            frm_AracCikis form3 = new frm_AracCikis();
            form3.Show();
            this.Close();
        }
        private void btnOtoparkDoluluk_Click_1(object sender, EventArgs e)
        {
            frm_OtoparkDoluluk form4 = new frm_OtoparkDoluluk();
            form4.Show();
            this.Close();
        }
        private void btnAracBul_Click_1(object sender, EventArgs e)
        {
            frm_AracBul form5 = new frm_AracBul();
            form5.Show();
            this.Close();
        }
        private void btnAboneEkle_Click_1(object sender, EventArgs e)
        {
            frm_Abonelik form6 = new frm_Abonelik();
            form6.Show();
            this.Close();
        }
        private void btnAboneListele_Click_1(object sender, EventArgs e)
        {
            frm_AboneListele form7 = new frm_AboneListele();
            form7.Show();
            this.Close();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_PersonelDogrula personeldogrula = new frm_PersonelDogrula();
            personeldogrula.Show();
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
                frm_PersonelGirisi ac = new frm_PersonelGirisi();
                ac.Show();
            }
        }
    }   
}
