using Arreglos.Clases;

namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problemas problemas = new Problemas();

            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1. Mostrar números en el arreglo");
            Console.WriteLine("2. Ingresar números en el arreglo");
            Console.WriteLine("3. Calcular la media de números");
            Console.WriteLine("4. Crear un arreglo de múltiplos");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    problemas.MostrarNumeroArreglo();
                    break;

                case 2:
                    problemas.IngresarNumeroArreglo();
                    break;

                case 3:
                    problemas.MediaNumeros();
                    break;

                case 4:
                    Console.WriteLine("Ingrese la longitud del arreglo:");
                    int longitud = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el número para generar múltiplos:");
                    int multiplo = Convert.ToInt32(Console.ReadLine());
                    problemas.CrearArray(longitud, multiplo);
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}