using Dsw2026Ej8.problema_n_2;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema2 helper2 = new Problema2();

            string resumen1 = helper2.CrearResumenVenta(500, "Monitor 24''", 2, 120000m);
            Console.WriteLine($"Venta 1: {resumen1}");
            string resumen2 = helper2.CrearResumenVenta(501, "Mouse Gamer", 0, 15000m);
            Console.WriteLine($"Venta 2: {resumen2}");


        }
    }
}
