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
    public partial class aracgirisForm2 : Form
    {

        

        public aracgirisForm2()
        {
            InitializeComponent();
            
        }

        private void aracgirisForm2_Load(object sender, EventArgs e)
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
