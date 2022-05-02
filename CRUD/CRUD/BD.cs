using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace CRUD
{
    internal class BD
    {
        public static SqlConnection Conexion()
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=RegistroEmpleados;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
