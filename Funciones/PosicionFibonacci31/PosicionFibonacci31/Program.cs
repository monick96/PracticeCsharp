using System;

namespace PosicionFibonacci31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*31.Escribir una función que devuelva el número de la posición Fibonacci.*/
            /**/
            int num;
            Console.WriteLine("valor de la posicion Fibonacci");
            Console.WriteLine("Ingrese la posicion: ");
            num = int.Parse(Console.ReadLine());
            int[] arrayResult = SecuenciaFibonacci(num);

            Console.WriteLine($"El valor de la posicion {num}, es: {arrayResult[num]} ");
            Console.ReadKey();
        }

        static int[] SecuenciaFibonacci(int n) 
        {
            //sumamos uno a la posicion por que el conteo inicia en cero
            int[] secuenciaResult = new int[n + 1];
            
            //inicializo las pociciones 0 y 1
            secuenciaResult[0] = 0;
            secuenciaResult[1] = 1;

            //para las siguintes posiciones sumo las dos ultimas en bucle
            //hasta llegar a la posicion solicitada
            for (int i = 2; i < secuenciaResult.Length; i++)
            {
                secuenciaResult[i] = secuenciaResult[i - 1] + secuenciaResult[i - 2];
            }

            return secuenciaResult;
        }
    }
}
