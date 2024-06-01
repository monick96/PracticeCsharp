using System;

namespace potencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*20.  	Escribir una función que reciba los parámetros a y n; 
             * y calcule la potencia n de a -->(a  n).
            */
            int a;
            int n;
            Console.WriteLine("Potencia de a");

            Console.WriteLine("Ingrese el valor de a...");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de n, el valor de la potencia...");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(PotenciaDeN(a,n));
            Console.ReadKey();
        }

        static int PotenciaDeN(int a, int n) 
        {
            int result = a;

            for(int i = 2; i <= n; i ++)
            {
                result *= a;
            }
             return result;
        }
    }
}
