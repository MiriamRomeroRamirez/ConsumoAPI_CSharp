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
    public class Logica_GrupoCuatrimestre
    {
        ConexionBD OpClien_SQL = null;
        public Logica_GrupoCuatrimestre(string CadCon)
        {
            OpClien_SQL = new ConexionBD(CadCon);
        }
        public DataTable Get()
        {
            string m = "";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GrupoCuatrimestre", OpClien_SQL.AbrirConexion(ref m));
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null; 
            }
        }

        public List<GrupoCuatrimestre> lista()
        {
            string consulta = "select Id_GruCuat, F_ProgEd, F_Grupo, F_Cuatri, Turno, Modalidad, Extra from GrupoCuatrimestre";
            SqlDataReader contenedor = null;
            SqlConnection cntemp = null;
            List<GrupoCuatrimestre> misobjs = new List<GrupoCuatrimestre>();
            string m = "";
            cntemp = OpClien_SQL.AbrirConexion(ref m);
            contenedor = OpClien_SQL.ConsultaReader(consulta, cntemp, ref m);

            if (contenedor != null)
            {
                while (contenedor.Read())
                {
                    misobjs.Add(
                        new GrupoCuatrimestre
                        {
                            Id_GruCuat = (int)contenedor[0],
                            F_ProgEd = (int)contenedor[1],
                            F_Grupo = (short)contenedor[2],
                            F_Cuatri = (short)contenedor[3],
                            Turno = (string)contenedor[4],
                            Modalidad = (string)contenedor[5],
                            Extra = (string)contenedor[6]
                        }
                        );
                }
            }
            return misobjs;
        }
        public string Post(GrupoCuatrimestre obj)
        {
            string m = "";
            SqlCommand cmd = new SqlCommand($"INSERT INTO GrupoCuatrimestre VALUES({obj.F_ProgEd},{obj.F_Grupo},{obj.F_Cuatri},'{obj.Turno}','{obj.Modalidad}','{obj.Extra}')", OpClien_SQL.AbrirConexion(ref m));
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

