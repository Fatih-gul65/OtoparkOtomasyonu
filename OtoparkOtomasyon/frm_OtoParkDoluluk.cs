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
    public partial class frm_OtoparkDoluluk : Form
    {
        cs_Baglanti baglanti = new cs_Baglanti();
        cs_OtoparkDoluluk _islemler;
        public frm_OtoparkDoluluk()
        {
            InitializeComponent();

            _islemler = new cs_OtoparkDoluluk(baglanti, otomobilPanel, kamyonetPanel, minibusPanel);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_PersonelGirisi personelGirisi = new frm_PersonelGirisi();
            personelGirisi.Show();
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
                frm_OtoparkDoluluk ac = new frm_OtoparkDoluluk();
                ac.Show();
            }
        }
    }
}
