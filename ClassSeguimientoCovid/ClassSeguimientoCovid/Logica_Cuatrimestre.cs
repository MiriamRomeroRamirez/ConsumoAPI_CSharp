using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace ClassSeguimientoCovid
{
    public class Logica_Cuatrimestre
    {
        ConexionBD OpClien_SQL = null;
        public Logica_Cuatrimestre(string CadCon)
        {
            OpClien_SQL = new ConexionBD(CadCon);
        }
        public DataTable Get()
        {
            string m = "";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cuatrimestre", OpClien_SQL.AbrirConexion(ref m));
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }
    }
}

