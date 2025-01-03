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
    public partial class aracbul : Form
    {
        Baglanti baglanti = new Baglanti();
        aracBulForm _islemler;
        public aracbul()
        {
            InitializeComponent();
            _islemler = new aracBulForm(baglanti, txtPlaka, lblAracYeri);
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelGirisi personelGirisi = new PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }
        private void btnAracBul_Click_1(object sender, EventArgs e)
        {
            _islemler.aracBul();
        }
    }
}
