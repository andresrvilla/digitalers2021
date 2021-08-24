using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Comentario
    {
        public string Nombre { get; set; }

        public string Texto { get; set; }
    }
}
