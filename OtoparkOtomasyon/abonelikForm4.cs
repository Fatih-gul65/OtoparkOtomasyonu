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
    public partial class abonelikForm4 : Form
    {
        

        public abonelikForm4()
        {
            InitializeComponent();
            
        }

        private void abonelikForm4_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            PersonelGirisi personelGirisi = new PersonelGirisi();
            personelGirisi.Show();
            this.Close();
        }

       
    }
}
