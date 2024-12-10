using System;

using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class PersonelTanimla : Form
    {
        public PersonelTanimla()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            this.Close();
            yoneticiGiris.Show();
        }

        private void PersonelTanimla_Load(object sender, EventArgs e)
        {

        }
    }
}
