using System;
namespace Personas
{
    class Program 
    {
        static void Main(string [] args)
        {
            //Se ingresan Número de documento, edad, y sexo (F o M) de un conjunto de personas. Este conjunto de datos
            // finaliza al ingresar el Número de documento 0 (inexistente).
            // Se pide:

            //     a. ¿Cuántas personas tienen más de 40 años?

            //     b. Cantidad de hombres y cantidad de mujeres.

            //     c. Promedio de edades..
            int documento;
            int edad;
            char sexo;
            int contMas40 = 0;
            int contM = 0;
            int contF = 0;
            int sumaEdad = 0;
            float promedioEdades;
            //promedioEdades = sumaEdad/(contadorF +contaforM)
            
            Console.WriteLine("Ingrese el documento o use 0 (cero) para terminar: ");
            documento= int.Parse(Console.ReadLine());

            while(documento != 0)
            {
                Console.WriteLine("Ingrese el sexo de la persona, 'f' o 'm': ");
                sexo= char.Parse(Console.ReadLine());

                while(sexo != 'f' && sexo != 'm')
                {
                    Console.WriteLine("Valor incorrecto, ingrese 'f' o 'm': ");
                    sexo = char.Parse(Console.ReadLine());
                }

                if(sexo == 'm')
                {
                    contM ++;
                }
                else
                contF ++;

                Console.WriteLine("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());

                sumaEdad += edad;

                if(edad>40)
                {
                    contMas40 ++;
                }
                
                Console.WriteLine("Ingrese el documento o use 0 (cero) para terminar: ");
                documento = int.Parse(Console.ReadLine());
            }

            promedioEdades = sumaEdad/ (contF+contM);
            Console.WriteLine( contMas40 + " personas tienen mas de 40 años");
            Console.WriteLine( contF + " personas eran del sexo femenino");
            Console.WriteLine( contF + " personas eran del sexo femenino");
            Console.WriteLine( promedioEdades+ " años fue el promedio de edades de las personas");

        }
        
    }
}
