using System;

using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class AracKapasitesiAyarla : Form
    {
        public AracKapasitesiAyarla()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            this.Close();
            yoneticiGiris.Show();
        }

        private void AracKapasitesiAyarla_Load(object sender, EventArgs e)
        {

        }
    }
}
