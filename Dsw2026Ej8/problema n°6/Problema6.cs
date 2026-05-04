using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.problema_n_6
{
    public class Problema6
    {
        public string NormalizarCodigoProducto(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return "Sin codigo";
            }
            return code.ToProductCode();
        }
    }
}
