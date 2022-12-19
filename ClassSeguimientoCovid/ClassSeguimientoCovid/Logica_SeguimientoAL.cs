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
    public class Logica_SeguimientoAL
    {
        ConexionBD OpClien_SQL = null;
        public Logica_SeguimientoAL(string CadCon)
        {
            OpClien_SQL = new ConexionBD(CadCon);
        }
        public DataTable Get()
        {
            string m = "";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SeguimientoAL", OpClien_SQL.AbrirConexion(ref m));
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

        public string Post(SeguimientoAL obj)
        {
            string m = "";
            SqlCommand cmd = new SqlCommand($"INSERT INTO SeguimientoAL VALUES({obj.F_PositivoAL},{obj.F_medico},'{obj.Fecha}','{obj.Form_Comunica}','{obj.Reporte}','{obj.Entrevista}','{obj.Extra}')", OpClien_SQL.AbrirConexion(ref m));
            OpClien_SQL.AbrirConexion(ref m);
            int i = cmd.ExecuteNonQuery();
            OpClien_SQL.CerrarConexion();
            if (i == 1)
            {
                return "Insertado";
            }
            else
            {
                return "Fallido";
            }
        }
    }
}

