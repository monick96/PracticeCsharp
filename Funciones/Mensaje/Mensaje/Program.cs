using System;
/*
 1. Armar una función, a la que se le pase 
como parámetro un número N,
y muestre por pantalla N veces el mensaje:
“Módulo ejecutándose”.
 */
namespace Mensaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            Console.WriteLine(mensaje(n));
            Console.ReadKey();
        }
        static string mensaje(int n)
        {
            string msj = "";
            for (int i = 1; i <= n; i++)
            {
                msj += "Modulo ejecutandose ";
            }
            return msj;
            
        }
    }
}
