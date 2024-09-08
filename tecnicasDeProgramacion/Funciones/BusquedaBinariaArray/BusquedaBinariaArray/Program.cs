using System;



namespace BuscarEnArray25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 25.Escribir una función a la que se le pasa un array de enteros 
             * y un número. Debe buscar el número en el array e indicar si se encuentra o no.
             */
            ///array ordenado
            int[] arrayInts = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            
            int posicion = busquedaBinariaArrayInt(arrayInts, 20);

            if (posicion != -1)
            {
                Console.WriteLine($"El numero se encuentra en la posicion {posicion}");
            }
            else
            {
                Console.WriteLine("el numero no se encuentra en el array");
            }

            Console.ReadKey();
        }


        static int busquedaBinariaArrayInt(int[] array, int num)
        {
            int inicio = 0;
            int final = array.Length - 1;
            int medio = 0;

            while (inicio <= final)
            {
                medio = (inicio + final) / 2;
                if (array[medio] == num)
                {
                    //retorno la posicion del elemento si coincide
                    return medio;
                }
                else if (array[medio] > num)
                {   
                    //si el numero buscado es menor al elemento obtenido 
                    //ajusto la busqueda hacia la izquierda
                    final = medio - 1;
                }
                else
                {   
                    //si elemento encontrado es menor ajusto la busqueda hacia la derecha
                    inicio = medio + 1;
                }
            }

            //si no se encuentra el numero devuelvo -1
            return -1;
        }

    }
}
