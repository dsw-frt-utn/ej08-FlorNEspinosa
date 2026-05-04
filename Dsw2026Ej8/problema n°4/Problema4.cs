using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.problema_n_4
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int suma = 0;
            int cantidad = 0;

            if (EsNotaValida(nota1))
            {
                suma += nota1.Value;
                cantidad++;
            }

            if (EsNotaValida(nota2))
            {
                suma += nota2.Value;
                cantidad++;
            }

            if (EsNotaValida(nota3))
            {
                suma += nota3.Value;
                cantidad++;
            }

            if (cantidad == 0)
            {
                return 0;
            }

            return (double)suma / cantidad;
        }
        private bool EsNotaValida(int? nota)
        {
            return nota.HasValue && nota.Value >= 0 && nota.Value <= 10;
        }
    }
}