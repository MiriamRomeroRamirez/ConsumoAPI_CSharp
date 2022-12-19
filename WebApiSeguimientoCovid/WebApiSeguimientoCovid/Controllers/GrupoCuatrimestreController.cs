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
    public class GrupoCuatrimestreController : ApiController
    {
        Logica_GrupoCuatrimestre grupo = new Logica_GrupoCuatrimestre(ConfigurationManager.ConnectionStrings["CadCon"].ConnectionString);

        [HttpGet]
        public DataTable mostrar()
        {
            DataTable obj = grupo.Get();
            return obj;
        }
        [HttpPost]
        public string insertar(GrupoCuatrimestre obj)
        {
            return grupo.Post(obj);
        }
    }
}
