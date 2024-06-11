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
            int n;

            Console.WriteLine("Ingrese un numero : ");
            n = int.Parse(Console.ReadLine());

            //invocacion funcion mensaje
            Console.WriteLine("Funcion");
            Console.WriteLine(mensaje(n));

            //lamado procedimiento mensaje
            Console.WriteLine("Procedimiento");
            mensajeP(n);
            Console.ReadKey();
        }
        
        //funcion mensaje
        static string mensaje(int n)
        {
            string msj = "";
            for (int i = 1; i <= n; i++)
            {
                msj += "Modulo ejecutandose \n";
            }
            return msj;
            
        }
        
        //procedimiento
        static void mensajeP(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine( "Modulo ejecutandose");
            }
            
        }
    }
}
