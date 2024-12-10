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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            YoneticiDogrulama yonetici = new YoneticiDogrulama();
            yonetici.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            PersonelDogrula personeldogrula = new PersonelDogrula();
            personeldogrula.Show();
            this.Hide();
        }
    }
}
