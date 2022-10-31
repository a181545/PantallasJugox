using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PruebaForms1
{
    class ConexionBD
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn =  new SqlConnection(@"Data Source=.; Initial Catalog=Prueba_Forms1; Integrated security=true");
            cn.Open();
            return cn;
        }
    }
}
