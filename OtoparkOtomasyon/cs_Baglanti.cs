using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OtoparkOtomasyon
{
    internal class cs_Baglanti
    {
        public OtoparkOtomasyonEntities1 Entity()
        {
            return new OtoparkOtomasyonEntities1();
        }
        public SqlConnection SqlBaglanti()
        {
            return new SqlConnection(@"Data Source=FATIH\SQLEXPRESS;Initial Catalog=OtoparkOtomasyon;Integrated Security=True;");
        }
    }
}
