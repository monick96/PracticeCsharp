using System;

namespace ingresoNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 5 números. Calcular e informar el mayor número negativo,
            //promedio de los positivos y cantidad de ceros.
            //Antes de informar, verificar si se ingresaron datos
            //en los respectivos tipos, de lo contrario,
            //informar “No se ingresaron números(tipo)”

            int numInput;
            int mayorNegativo = 0;
            int sumaPositivos = 0;
            int contadorCeros = 0;
            int contadorPositivos = 0;
            int bandera = 1;
            float promedioPositivos = 0;

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("ingrese 5 numeros: ");
                numInput = int.Parse(Console.ReadLine());
                //negativos
                if (numInput < 0)
                {
                    if (bandera == 1)
                    {
                        mayorNegativo = numInput;
                        bandera = 0;
                    }
                    else
                    {
                        if (numInput>mayorNegativo)
                        {
                            mayorNegativo = numInput;
                        }
                    }

                }
                else
                {
                    //positivos
                    if (numInput > 0)
                    {
                        contadorPositivos++;
                        sumaPositivos += numInput;
                    }
                    else
                        contadorCeros++;
                }
                    

            }

            //resultados
            //negativos
            if (bandera == 1)
            {
                Console.WriteLine("No se ingresaron numeros negativos");
            }
            else
            {
                Console.WriteLine("El mayor negativo ingresado fue : " + mayorNegativo);
            }
               

            //positivos
            if (contadorPositivos == 0)
            {
                Console.WriteLine("No se ingresaron numeros positivos");
            }
            else
            {
                promedioPositivos = sumaPositivos/contadorPositivos;
                Console.WriteLine("El promedio de numeros positivos ingresados fue de: " + promedioPositivos);
            }

            //ceros
            if (contadorCeros  == 0)
            {
                Console.WriteLine("No se ingresaron ceros");
            }
            else
                Console.WriteLine("La cantidad de ceros ingresados fue de : " + contadorCeros);

            Console.ReadKey();

        }
    }
}

