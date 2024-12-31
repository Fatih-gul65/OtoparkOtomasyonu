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
        public OtoparkOtomasyonEntities Entity()
        {
            return new OtoparkOtomasyonEntities();
        }
        public SqlConnection SqlBaglanti()
        {
            return new SqlConnection(@"Data Source=VIEWSONIC\SQLEXPRESS;Initial Catalog=OtoparkOtomasyon;Integrated Security=True;");
        }
    }
}
