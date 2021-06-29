using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    interface IGuardable
    {
        string NombreArchivo { get; set; }

        void Guardar();
    }
}
