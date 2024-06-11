using System;


namespace OrdenarArray27
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] ints = {60,10,5,2,6,9,8,58};


            MostrarArray(OrdenarArrayInsercion(ints));

            Console.WriteLine("");
            MostrarArray(OrdenarArrayBurbuja(ints));

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

        static int[] OrdenarArrayBurbuja(int[] array)
        { 
            //for que recorre el array
            for(int recorrido = 1 ;recorrido < array.Length;recorrido ++)
            {   
                //bucle interno que reccore el array y compara los elementos de a dos  
                for(int i = 0; i < array.Length - recorrido; i++)
                {
                    //compara si el elemento actual es mayor al que sigue
                    if (array[i] > array[i+1])
                    {
                        //si es true, intercambia
                        int tempVar = array[i]; //guarda el elemento actual
                        array[i] = array[i+1]; //mueve el menor elemento a la izquierda
                        array[i+1] = tempVar; //asigna el elemento actual ala siguiente posicion,
                                              //dezplaza hacia la derecha

                    }
                }
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
