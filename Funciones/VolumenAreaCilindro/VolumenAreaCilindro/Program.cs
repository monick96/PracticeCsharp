using System;

namespace VolumenAreaCilindro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                8. Se necesita una función que calcule
                y muestre en pantalla el área o el volumen de un 
                cilindro, según se especifique. Para distinguir un caso de otro, 
                además de pasarle por parámetro el radio y la altura, se le pasará 
                el carácter ’a’ (para área) o ’v’ (para el volumen).
            */
            int numero = 5;
            int factorial = CalcularFactorial(numero);
            Console.WriteLine("El factorial de " + numero + " es: " + factorial);

            Console.ReadKey();
        }
        static int CalcularFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * CalcularFactorial(n - 1);
        }
    }
}

