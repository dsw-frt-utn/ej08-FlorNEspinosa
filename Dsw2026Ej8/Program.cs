using Dsw2026Ej8.problema_n_2;
using Dsw2026Ej8.problema_n_3;
using Dsw2026Ej8.problema_n_4;
using Dsw2026Ej8.problema_n_5;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema5 problema5 = new Problema5();

            Sale ventaMinorista = new RetailSale(1000m);
            Sale ventaMayorista = new WholesaleSale(1000m);

            decimal resultado1 = problema5.ObtenerImporteFinal(ventaMinorista);
            decimal resultado2 = problema5.ObtenerImporteFinal(ventaMayorista);

            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
        }
    }
}
