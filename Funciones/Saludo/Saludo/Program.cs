using System;
namespace Saludo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 2. Escribir una función que nos salude,
                pasándole un nombre por parámetro. 
                Su salida debe decir por ejemplo ”Hola Aristoteles, ¿cómo estás?”.
            */
            string nombre = "Pedro";

            Console.WriteLine(saludar(nombre));

            Console.ReadKey();
        }
        static string saludar(string nombre)
        {
            return $"Hola  {nombre} , ¿cómo estás?";
        }
    }

}

