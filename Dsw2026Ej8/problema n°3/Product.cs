using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.problema_n_3
{
    public class Product
    {
        public string Description { get; set; }
        public void ModificarDescripcion(string nuevaDesc)
        {
            Description = nuevaDesc;
        }
    }
}
