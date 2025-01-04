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
    public partial class otoparkdolulukForm6 : Form
    {
        Baglanti baglanti = new Baglanti();
        otoParkDolulukForm _islemler;
        public otoparkdolulukForm6()
        {
            InitializeComponent();

            _islemler = new otoParkDolulukForm(baglanti, otomobilPanel, kamyonetPanel, minibusPanel);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelGirisi personelGirisi = new PersonelGirisi();
            personelGirisi.Show();
            this.Close();
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
                otoparkdolulukForm6 ac = new otoparkdolulukForm6();
                ac.Show();
            }
        }
    }
}
