using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    public class MiClaseGenerica<T>
    {
        public void Mostrar(T parametro)
        {
            Console.WriteLine(parametro.GetType().Name);
        }

        public void OtroMostrar<TLocal>(TLocal parametro)
        {
            Console.WriteLine(parametro.GetType().Name);
        }
    }
}
