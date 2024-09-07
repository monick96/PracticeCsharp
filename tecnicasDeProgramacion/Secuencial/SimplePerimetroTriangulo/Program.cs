using System;

namespace perimetroTriangulo 
{
    internal class Program 
    {
        static void Main (string [] args)
        {
            //Elaborar un algoritmo que lea los 3 lados de un triángulo cualquiera y calcule su perímetro
            //considerando A, B y C como lados.
            float ladoA;
            float ladoB;
            float ladoC;
            float perimetro;

            Console.WriteLine("Ingrese  el valos del lado A del triangulo: ");
            ladoA = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el ladoB del triangulo: ");
            ladoB = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el lado C del triangulo: ");
            ladoC = float.Parse(Console.ReadLine());

            perimetro = ladoA + ladoB  + ladoC;

            Console.WriteLine("El Perimetro del triangulo es: " + perimetro);
            
            
        }
    }
}
