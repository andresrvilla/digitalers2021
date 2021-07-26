using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiPaginaPresentacion.Clases
{
    [Serializable]
    public class Comentario
    {
        public string Nombre { get; set; }

        public string Texto { get; set; }
    }
}