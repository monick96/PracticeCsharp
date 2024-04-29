using System;
namespace SueldoOperario
{
    class Program
    {
        static void Main(string [] args)
        {
            //Calcular el sueldo de un operario, ingresando la cantidad de horas trabajadas 
            //y el valor que gana por hora. Si trabaja más de 40 hs, 
            //las horas extras se pagan a razón de $1,50 el valor de la hora.
            float horasTrabajadas;
            float valorHora;
            float sueldo;
            float valorHorasExtras = 1.50f;
            float sueldoHorasExtras;

            Console.WriteLine("Ingrese las horas trabajadas: ");
            horasTrabajadas = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingese el valor por hora de su salario: ");
            valorHora = float.Parse(Console.ReadLine());

            if(horasTrabajadas>40)
            {
                sueldoHorasExtras = (horasTrabajadas -40) * valorHorasExtras;
                sueldo = (40 * valorHora) + sueldoHorasExtras;
                Console.WriteLine("Su sueldo es de $" + sueldo);
            }
            else
            {
                sueldo = horasTrabajadas * valorHora;
                Console.WriteLine("Su sueldo es de $" + sueldo);
            }
        }
    }
}
