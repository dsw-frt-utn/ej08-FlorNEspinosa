namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper helper = new ProductHelper();

            long code = 777;
            string description = "gomitas";
            decimal price = 1200.50m;

            String resultado = helper.ObtenerEtiquetaProducto(code, description, price);

            Console.WriteLine(resultado);
        }
    }
}
