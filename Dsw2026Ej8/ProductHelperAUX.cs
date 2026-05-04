using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        private string ObtenerEtiquetaFormateada(long code, string descrption, decimal price)
        {
            return $"[{code}] {descrption} - {price:C}";
        }
    }
}
