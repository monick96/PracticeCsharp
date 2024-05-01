using System;
namespace MitadAnio
{
    class Program
    {
        static void Main(string [] args)
        {
            //Elaborar un algoritmo que permita indicar si el mes ingresado 
            //pertenece a la primera o segunda mitad del año.
            int mes;

            Console.WriteLine("Ingrese el numero del mes: ");
            mes = int.Parse(Console.ReadLine());

            if(mes>= 1 && mes <=6)
            {
                Console.WriteLine(mes + " Corrresponde a la primera mitad del año");
            }
            else if(mes>6 && mes <= 12)
            {
                Console.WriteLine(mes + " Corrresponde a la segunda mitad del año");
            }
            else
                Console.WriteLine(mes + ", no es un mes valido");
        }
    }
}