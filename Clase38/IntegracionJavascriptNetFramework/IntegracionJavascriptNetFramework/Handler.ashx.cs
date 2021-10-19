using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegracionJavascriptNetFramework
{
    /// <summary>
    /// Descripción breve de Handler
    /// </summary>
    public class Handler : IHttpHandler
    {

        /// <summary>
        /// Puedo usar los handlers para poder hacer peticiones desde javascript
        /// sin recargar la pagina
        /// </summary>
        /// <param name="context"></param>
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hola a todos");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}