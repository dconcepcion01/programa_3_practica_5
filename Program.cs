using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_3_practica_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("AREGLO DE SUMA Y PROMEDIO DE LOS NUMEROS : ");
            int sumaNumero = 0;
            double promedio;
            Console.WriteLine(" Desordenados = { 9, 15, 1, 14, 8, 7, 6, 5 }"); 
            int [] numeros = { 9,15,1,14,8,7,6,5};
            Array.Sort(numeros);
            //Array.Reverse(numeros);
            Console.WriteLine("Ordenado Acendente");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i].ToString());
             
            }
            
            for (int i = 0; i < numeros.Length; i++)
            {
                sumaNumero = sumaNumero + numeros[i];

            }
            promedio = sumaNumero / numeros.Length;
            Console.WriteLine("*---------------------------*");
            Console.WriteLine("La suma de los numeros es : " + sumaNumero);
            Console.WriteLine("El promedio de los numeros es :  " + promedio);

            Console.ReadKey();

        }
    }
}
