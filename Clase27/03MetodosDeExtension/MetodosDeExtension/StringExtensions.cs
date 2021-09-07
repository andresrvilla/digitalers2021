using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtension.Extensiones
{
    public static class StringExtensions
    {
        //cuando se llame a este metodo se va a llamar como:
        // string variable ="unValor";
        // variable.Reverse()
        // y self va a corresponder con "variable"
        public static string Invertir(this string self)
        {
            char[] array = self.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
