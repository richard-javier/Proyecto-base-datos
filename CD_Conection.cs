using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class CD_Conection
    {
        private SqlConnection DB_Connection = new SqlConnection("Server=DESKTOP-L6KQRBL; Database= POE_DB;Integrated Security=true");
        public SqlConnection OpenConnection() 
        {
            if (DB_Connection.State == ConnectionState.Closed)
                DB_Connection.Open();

            return DB_Connection;
        }
        public SqlConnection CloseConnection()
        {
            if (DB_Connection.State == ConnectionState.Open)
                DB_Connection.Close();

            return DB_Connection;
        }

    }
}
