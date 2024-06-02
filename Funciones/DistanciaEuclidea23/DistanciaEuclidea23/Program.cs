using System;

namespace DistanciaEuclidea23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*23.  	Escribir una función que calcule la distancia 
             * euclídea entre dos puntos del plano. Tener en cuenta que 
             * la función debe recibir 4 parámetros: las 2 coordenadas 
             * del primer punto y las 2 coordenadas del segundo punto.
             * d= raiz2((x2-x1)2+(y2-y1)2)
             */
            //A=(1,2) y B = (4, 6)
            //Console.WriteLine(CalcularDistanciaEuclidea(1,2,4,6));
            float x1;
            float y1;
            float x2;
            float y2;
            float r;

            Console.WriteLine("Distancia Euclidea entre 2 puntos...");

            Console.WriteLine("Ingrese valor para x1: ");
            x1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese valor para y1: ");
            y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese valor para x2: ");
            x2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese valor para y2: ");
            y2 = float.Parse(Console.ReadLine());

            r =CalcularDistanciaEuclidea(x1,y1,x2,y2);

            Console.WriteLine($"La distancia entre ({x1},{y1}) y ({x2},{y2}) es {r}");

            Console.ReadKey();
        }

        static float CalcularDistanciaEuclidea(float x1, float y1, float x2, float y2)
        {
            float result;

            result = (float) Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2 - y1,2));

            return result;
        }
    }
}
