using System;

namespace SecuenciaConjeturaCollatz32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*32.Escribir una función que dado un número natural,
             * escriba por pantalla su secuencia de la Conjetura de Collatz 
             * y que devuelva la longitud o cantidad de pasos que tiene 
             * hasta llegar al primer 1.*/

            /*1.Empieza con cualquier número entero positivo.
              *2.Si es par, divídelo entre 
              *3. Si es impar, multiplícalo por 3 y súmale 1.
               *4.Repite el proceso con el número obtenido.
                *La conjetura dice que siempre llegarás a 1, sin importar con qué número empieces.*/

            uint num;

            num = 10;

            Console.WriteLine(CantidadPasoSecuenciaCollatz(num));
        }
        static uint CantidadPasoSecuenciaCollatz(uint num)
        {
            uint cantPasos = 0;

            while (num > 1) 
            {
                if (num % 2 == 0) 
                {
                    num = num / 2;
                    cantPasos++;
                    Msg($"paso {cantPasos} es: {num} ");
                }
                else
                {
                    num = num * 3 + 1;
                    cantPasos++;
                    Msg($"paso {cantPasos} es: {num} ");
                }

            }

            return cantPasos;
        }

        static void Msg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
