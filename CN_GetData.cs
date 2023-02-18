using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using System.Runtime.CompilerServices;

namespace CapaNegocio
{
    public class CN_GetData
    {
        //Creando un objecto de la capa de datos
        private CD_GetData objectCD = new CD_GetData();
        //Metodo de conexion con la capa de datos
        private DataTable CN_ShowData()
        {
            DataTable mytable = new DataTable();
            return mytable;
        }
        public DataTable CN_GetProvincia() 
        {
            String sql_text = "select * from tb_provincia";
            DataTable dataRetorno = new DataTable();
            dataRetorno = CN_ShowData();
            return dataRetorno;
        }
        public DataTable CN_GetCiudad(int p_id_provincia)
        {
            String sql_text = "select * from tb_provincia id_provincia= " + p_id_provincia.ToString();
            DataTable dataRetorno = new DataTable();
            dataRetorno = CN_ShowData();
            return dataRetorno;
        }
        public DataTable CN_GetComboProvincia()
        {
            string consulta = "SELECT DISTINCT Provincia FROM Ciudad ORDER BY Provincia";
            DataTable tabla = new DataTable();
            return tabla;
        }
    }
}
