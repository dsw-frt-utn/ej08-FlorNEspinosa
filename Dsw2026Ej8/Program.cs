using Dsw2026Ej8.problema_n_2;
using Dsw2026Ej8.problema_n_3;
using Dsw2026Ej8.problema_n_4;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema4 problema4 = new Problema4();

            double resultado1 = problema4.CalcularPromedio(8, null, 10);
            Console.WriteLine(resultado1);

            double resultado2 = problema4.CalcularPromedio(null, null, null);
            Console.WriteLine(resultado2);

            double resultado3 = problema4.CalcularPromedio(8, -1, 20);
            Console.WriteLine(resultado3);
        }
    }
}
