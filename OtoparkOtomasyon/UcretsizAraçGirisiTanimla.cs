using System;

using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class UcretsizAraçGirisiTanimla : Form
    {
        public UcretsizAraçGirisiTanimla()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            this.Close();
            yoneticiGiris.Show();
        }

        private void UcretsizAraçGirisiTanimla_Load(object sender, EventArgs e)
        {

        }
    }
}
