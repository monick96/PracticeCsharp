using System;
namespace Sueldo
{
    internal class Program
    {
        static void Main (string [] args)
        {
            //Dadas las horas mensuales trabajadas de un empleado y el valor en pesos de cada hora, calcular el
            //sueldo que se abonará al finalizar el mes.
            double horasMensuales;
            double valorHora;
            double sueldo;

            Console.WriteLine("Ingrese las horas mensuales trabajadas: ");
            horasMensuales= double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su sueldo por hora: ");
            valorHora = double.Parse(Console.ReadLine());

            sueldo = horasMensuales * valorHora;

            Console.WriteLine("Su sueldo es de: $" + sueldo);

        }
    }
}
