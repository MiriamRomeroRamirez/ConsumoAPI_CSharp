using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using WebApiSeguimientoCovid.App_Start;

namespace WebApiSeguimientoCovid
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            config.EnableCors(new AccessPolicyCors()); 

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //Agregar el formatter for json
            config.Formatters.JsonFormatter.MediaTypeMappings.Add(
                new QueryStringMapping("type", "json",
                new MediaTypeHeaderValue("application/json")));

            //Agregar el formatter for json
            config.Formatters.XmlFormatter.MediaTypeMappings.Add(
                new QueryStringMapping("type", "xml",
                new MediaTypeHeaderValue("application/xml")));
        }
    }
}
