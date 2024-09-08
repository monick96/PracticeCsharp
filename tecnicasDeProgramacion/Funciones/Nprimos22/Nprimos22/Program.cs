using System;
namespace Nprimos22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*22.  	Escribir una función que sume los n primeros números impares.*/
            uint n;
            uint result;

            Console.WriteLine("Ingrese un entero");
            n = uint.Parse(Console.ReadLine());

            result = sumarPrimos(n);

            Console.WriteLine($"La suma de los {n} primeros numeros primos es: {result}" );

            Console.ReadLine();
        }

        //funcion
        static uint sumarPrimos(uint n) 
        {
            uint sum = 0;

            for(uint i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                    sum+=i;
            }
            
            return sum;
        }
    }
}
