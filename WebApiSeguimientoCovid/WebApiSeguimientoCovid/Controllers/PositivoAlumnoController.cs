using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Configuration;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization.Json;
using ClassSeguimientoCovid;

namespace WebApiSeguimientoCovid.Controllers
{
    public class PositivoAlumnoController : ApiController
    {
        Logica_PositivoAlumno pov = new Logica_PositivoAlumno(ConfigurationManager.ConnectionStrings["CadCon"].ConnectionString);
        [HttpGet]
        public DataTable mostrar()
        {
            return pov.Get();
        }

        [Route("api/PositivoAlumno/Consulta")]
        [HttpGet]
        public DataTable combo()
        {
            return pov.Select();
        }

        [HttpPost]
        public string insertar(PositivoAlumno obj)
        {
            return pov.Post(obj); 
        }
    }
}
