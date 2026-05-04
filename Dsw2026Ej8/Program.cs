using Dsw2026Ej8.problema_n_2;
using Dsw2026Ej8.problema_n_3;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema3 helper3 = new Problema3();

            Product miProducto = new Product { Description = "Descripción Original" };
            int miNumero = 10;

            string resultado = helper3.CompararCopias(miNumero, miProducto);

            Console.WriteLine($"Resultado del método: {resultado}");
            
        }
    }
}
