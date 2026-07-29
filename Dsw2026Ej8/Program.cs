using Dsw2026Ej8.problema_n_2;
using Dsw2026Ej8.problema_n_3;
using Dsw2026Ej8.problema_n_4;
using Dsw2026Ej8.problema_n_5;
using Dsw2026Ej8.problema_n_6;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema5 problema5 = new Problema5();
            Sale ventaMinorista = new RetailSale(1000m);
            Sale ventaMayorista = new WholesaleSale(1000m);
            Console.WriteLine($"RetailSale: {problema5.ObtenerImporteFinal(ventaMinorista)}");
            Console.WriteLine($"WholesaleSale: {problema5.ObtenerImporteFinal(ventaMayorista)}");

            Problema6 problema6 = new Problema6();
            string codigoEjemplo = " ab 123 x ";
            string resultado1 = problema6.NormalizarCodigoProducto(codigoEjemplo);
            Console.WriteLine($"Prueba Ejemplo: {resultado1}");
        }
    }
}
