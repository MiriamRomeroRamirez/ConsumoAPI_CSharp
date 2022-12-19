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
    public class SeguimientoALController : ApiController
    {
        Logica_SeguimientoAL pov = new Logica_SeguimientoAL(ConfigurationManager.ConnectionStrings["CadCon"].ConnectionString);
        [HttpGet]
        public DataTable mostrar()
        {
            return pov.Get();
        }
        [HttpPost]
        public string insertar(SeguimientoAL obj)
        {
            return pov.Post(obj);
        }
    }
}
