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
    public class Logica_PositivoAlumno
    {
        ConexionBD OpClien_SQL = null;
        public Logica_PositivoAlumno(string CadCon)
        {
            OpClien_SQL = new ConexionBD(CadCon);
        }
        public DataTable Get()
        {
            string m = "";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PositivoAlumno", OpClien_SQL.AbrirConexion(ref m));
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

        public DataTable Select()
        {
            string m = "";
            SqlDataAdapter da = new SqlDataAdapter("select ID_posAl, Matricula, Extra, Riesgo from PositivoAlumno inner join Alumno on ID_Alumno = F_Alumno", OpClien_SQL.AbrirConexion(ref m));
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
        public string Post(PositivoAlumno obj)
        {
            
        string m = "";
            SqlCommand cmd = new SqlCommand($"INSERT INTO PositivoAlumno VALUES('{obj.FechaConfirmado}','{obj.Comprobacion}','{obj.Antecendentes}','{obj.Riesgo}'," +
                $"{obj.NumContagio},'{obj.Extra}',{obj.F_Alumno})", OpClien_SQL.AbrirConexion(ref m)); 
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

