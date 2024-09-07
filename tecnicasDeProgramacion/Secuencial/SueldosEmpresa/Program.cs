using System;
namespace SueldosEmpresa
{
    class Program
    {
        static void Main(string [] args)
        {
            //En una empresa trabajan n empleados cuyos sueldos oscilan entre $10000 y $50000, realizar un
            //programa que lea los sueldos que cobra cada empleado e informe cuántos empleados cobran entre
            //$10000 y $30000 y cuántos cobran más de $30000. Además, el programa deberá informar el importe
            //que gasta la empresa en sueldos al personal.

            float sueldo;
            int cont10MilY30Mil = 0;
            int contMas30Mil = 0;
            float sumaSueldos = 0;

            Console.WriteLine("Ingrese el sueldo mayor a  $10000 y menor a $50000, para terminar ingrese 0: ");
            sueldo = float.Parse(Console.ReadLine());
            
            while(sueldo !=0)
            {
                if(sueldo >= 10000 && sueldo <= 50000)
                {
                    sumaSueldos += sueldo;

                    if(sueldo >= 10000 && sueldo <= 30000)
                    {
                        cont10MilY30Mil ++;
                    }
                    else
                        contMas30Mil ++;

                }
                else
                    Console.WriteLine("Monto incorrecto!");

                Console.WriteLine("Ingrese el sueldo mayor a  $10000 y menor a $50000, para terminar ingrese 0: ");
                sueldo = float.Parse(Console.ReadLine());  
                
            }

            Console.WriteLine("El gasto en sueldos es de $" + sumaSueldos);
            Console.WriteLine(cont10MilY30Mil + " empleados cobran entre $10000 y $30000");
            Console.WriteLine(contMas30Mil + " empleados cobran mas de $30000");

        }
    }
}