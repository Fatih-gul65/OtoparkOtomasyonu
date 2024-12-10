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
    public partial class aracikisForm3 : Form
    {

       

        public aracikisForm3()
        {
            InitializeComponent();
           
        }

        private void aracikisForm3_Load(object sender, EventArgs e)
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
