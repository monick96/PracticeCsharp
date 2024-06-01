using System;

namespace NumeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*19.  	Escribir una función que indique si un número es primo.
             * Un numero es primo si es divisible solo por uno y por si mismo
             */
            Console.WriteLine("Numeros primos...");
            Console.WriteLine("Ingrese el numero entero a comprobar: ");
            int num = int.Parse(Console.ReadLine());

            if (EsPrimo(num))
            {
                Console.WriteLine($"El numero {num} es primo");
            }
            else
            {
                Console.WriteLine($"El numero {num} no es primo");
            }

            Console.ReadKey(); 

        }

        static bool EsPrimo(int num)
        {
            bool verificacion = true;
            // Los números menores o iguales a 1 no son primos
            if (num <= 1)
                verificacion = false;

            // 2 es el único número primo par
            if (num == 2)
                verificacion = true;

            // Números pares mayores que 2 no son primos
            if (num % 2 == 0)
                verificacion = false;

            // Revisa los números impares desde 3 hasta la mitad del número
            for (int i = 3; i <= (num / 2); i += 2)
            {
                if (num % i == 0)
                    verificacion = false; // Si num es divisible por i, no es primo
            }

            // Si no se encontró ningún divisor, es primo
            return verificacion;
        }
    }
}
