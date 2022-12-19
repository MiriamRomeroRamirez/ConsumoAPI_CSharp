using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassSeguimientoCovid
{
    public class ConexionBD
    {
        private string cadconexion;
        public ConexionBD(string cadenaDB)
        {
            cadconexion = cadenaDB;
        }

        public SqlConnection AbrirConexion(sqlco conexion, ref string mensaje)
        {
            conexion.ConnectionString = conex;
            try
            {
                conexion.Open();
                mensaje = "Conexión abierta CORRECTAMENTE";
            }
            catch (Exception r)
            {
                conexion = null;
                mensaje = "ERROR" + r.Message;
            }
            return conexion;
        }
        public SqlConnection CerrarConexion()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.Close();
            return conexion;
        }

        public SqlDataReader ConsultaReader(string querySQL, SqlConnection cnAb, ref string msj)
        {
            SqlCommand carrito = null;
            SqlDataReader contenedor = null;

            if (cnAb == null)
            {
                msj = "No hay conexión a la BD";
                contenedor = null;
            }
            else
            {
                carrito = new SqlCommand();
                carrito.CommandText = querySQL;
                carrito.Connection = cnAb;
                try
                {
                    contenedor = carrito.ExecuteReader();
                    msj = "Consulta correcta DataReader";
                }
                catch (Exception a)
                {
                    contenedor = null;
                    msj = "Error: " + a.Message;
                }
            }
            return contenedor;
        }
    }
}
