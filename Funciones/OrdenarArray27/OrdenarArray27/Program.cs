using System;


namespace OrdenarArray27
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] ints = {60,10,5,2,6,9,8,58};

            MostrarArray(OrdenarArrayInsercion(ints));
            Console.ReadKey();
        }


        static int[] OrdenarArrayInsercion(int[] array)
        {
            //inicio el for en la 2da posicion del array
            for (int i = 1; i < array.Length; i++)
            {
                int elementoActual = array[i];//elemento a ordenar

                int poscionOrdenada = i-1;//ult posicion ordenada

                //muevo los mayores que el elemeto actual a la derecha
                while (poscionOrdenada >= 0 && array[poscionOrdenada] > elementoActual)
                {
                    //inserto el mayor elemento en la posicion siguiente de la actual
                    array[poscionOrdenada + 1] = array[poscionOrdenada];

                    //restamos para que recorra el array hacia la izq y compare
                    // y para afuera sumarle 1 y colocar el elemnto actual, si fuera necesario
                    poscionOrdenada--;
                }

                //inserto el elemento actual en la posicion correcta
                array[poscionOrdenada + 1] = elementoActual;

            }
            return array;
        }

        static void MostrarArray(int[] array)
        {
            for(int i = 0; i < array.Length; i ++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
