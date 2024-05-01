using System;

namespace ParesInpares
{
    class Program
    {
        static void Main(string [] args)
        {
            //Realizar el diagrama y codificación de un programa que ingrese 5 números 
            //y calcule e informe la cantidad de pares y el promedio de los impares.
            int num;
            int contPares = 0;
            float promedioImpares;
            int contadorImpares = 0;
            int sumaImpares = 0;

            for (int i = 1; i < 6; i++)
            {
               Console.WriteLine("Ingrese un numero entero: ");
               num = int.Parse(Console.ReadLine());

               if(num%2==0)
               {
                    contPares ++;
               }
               else
               {
                    contadorImpares ++;
                    sumaImpares += num;
               }

            }
            promedioImpares = ((float)(sumaImpares) / (float)(contadorImpares));

            Console.WriteLine("La cantidad de pares ingresados es de: " + contPares);
            Console.WriteLine("El promedio de numeros impares es de: " + promedioImpares);


        }
    }
}
