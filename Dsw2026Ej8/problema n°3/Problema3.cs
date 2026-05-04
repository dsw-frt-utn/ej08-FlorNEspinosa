using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.problema_n_3
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {        
            int valorCopia = originalValue;

            valorCopia++;

            Product productoCopiado = product;

            productoCopiado.ModificarDescripcion("Descripción Modificada");

            return $"{originalValue}-{valorCopia}-{product.Description}";
        }
    }
}
