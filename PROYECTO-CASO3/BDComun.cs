using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PROYECTO_CASO3
{
    class BDComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=PROYECTO_PROGRAMACION;Integrated Security=True");
            
            return Conn;
        }
    }
}
