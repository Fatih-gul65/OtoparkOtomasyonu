using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OtoparkOtomasyon
{
    internal class Baglanti
    {
        public OtoparkOtomasyonEntities3 Entity()
        {
            return new OtoparkOtomasyonEntities3();
        }
        public SqlConnection SqlBaglanti()
        {
            return new SqlConnection(@"Data Source=FATIH\SQLEXPRESS;Initial Catalog=OtoparkOtomasyon;Integrated Security=True;");
        }
    }
}
