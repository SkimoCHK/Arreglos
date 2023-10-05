using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Clases
{
    public class Problemas
    {

        public void MostrarNumeroArreglo()
        {


            int[] numeros = { 1, 2, 3, 4, 5 };



            for (int x = 0; x <= 4; x++)
            {
                Console.WriteLine(numeros[x]);

            }

        }

        public void IngresarNumeroArreglo()
        {
            int[] numeros = new int[5];


            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine($"Ingrese el valor {x + 1}");
                numeros[x] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Los numeros que ingresaste son");
            for (int x = 0; x < 5; x++)
            {

                Console.WriteLine(numeros[x]);
            }



        }

        public void MediaNumeros()
        {
            int[] numeros = new int[10];


            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine($"Ingrese el valor {x + 1}");
                numeros[x] = Convert.ToInt32(Console.ReadLine());

            }
            int suma = 0;
            for (int x = 0; x < 10; x++)
            {

                suma += numeros[x];

            }
            int media = suma / numeros.Length;
            Console.WriteLine($"La media de los numeros ingreados es {media}");


        }

        public void CrearArray(int longitud, int multiplo)
        {
            if (longitud <= 0)
            {
                Console.WriteLine("La longitud debe ser mayor que 0 loco");
                return;
            }

            int[] multiplos = new int[longitud];

            for (int x = 0; x < multiplos.Length; x++)
            {
                multiplos[x] = multiplo * (x + 1);
            }

            Console.WriteLine("Los multiplos del número ingresado son:");
            foreach (int numero in multiplos)
            {
                Console.WriteLine(numero);
            }
        }



    }
}
