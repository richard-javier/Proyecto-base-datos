using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_GetData
    {
        private CD_Conection db_connection = new CD_Conection();
        SqlDataReader dataReader;
        DataTable dataTable = new DataTable();
        SqlCommand sqlCommand = new SqlCommand();
        public DataTable ConsultaCiudadPorProvincia(string provincia)
        {
            string consulta = "SELECT * FROM Ciudades WHERE Provincia ='" + provincia + "'";
            DataTable tabla = new DataTable();
            return tabla;
        }
    }
}
