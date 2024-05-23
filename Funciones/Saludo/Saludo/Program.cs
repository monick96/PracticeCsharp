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
            string nombre;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            //invocacion funcion saludar()
            Console.WriteLine("Funcion");
            Console.WriteLine(saludar(nombre));

            //invocacion procedimiento saludar()
            Console.WriteLine("Procedimiento");
            saludarP(nombre)

            Console.ReadKey();
        }
        //funcion saludar
        //la función Saludar retorna un valor(el saludo) al Main,
        
        static string saludar(string nombre)
        {
            return $"Hola  {nombre}, ¿cómo estás?";
        }
        
        //procedimiento saludar
        //es invocada desde el main donde recibe por argumento el nombre
        //e imprime directamente el saludo por la consola sin volver a pasar por el main
        static void saludarP(string nombre)
        {
            Console.WriteLine($"Hola  {nombre}, ¿cómo estás?");
        }
    }

}

