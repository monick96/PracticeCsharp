using System;
using System.Runtime.Serialization.Formatters;

namespace OperacionesConArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*26.Escribir una función a la que se le pasa dos arrays, 
             * el número de elementos útiles y que operación se desea realizar: 
             * sumar, restar, multiplicar o dividir (mediante un carácter: ’s’, ’r’, ’m’, ’d’). 
             * La función debe devolver un array con los resultados.
             */
            int[] array1 = {2, 3, 4, 5, 6, 7, 8, 9};
            int[] array2 = {2,0,20,23,24,25,30,12};
            float [] arrayResult;
            char op = 'd';

            arrayResult= OperacionesArray(array1 , array2 ,7, op);

            MostrarArray(arrayResult);


            Console.ReadKey();
        }

        static float[] OperacionesArray(int[] array1, int[] array2, int cantElem, char operacion)
        {
            float[] result = new float[cantElem];
            if (cantElem <= array1.Length && cantElem <= array2.Length)
            { 
                switch (operacion)
                {
                    case 's':

                        for (int i = 0; i < cantElem; i++)
                        {
                            result[i] = array1[i] + array2[i];
                            //descomentar para ver proceso
                            //Msg($"Operación: {array1[i]} + {array2[i]}");
                            //Msg($"{result[i]}");
                        }
                        break;

                    case 'r':

                        for (int i = 0; i < cantElem; i++)
                        {
                            result[i] = array1[i] - array2[i];
                            //descomentar para ver proceso
                            //Msg($"Operación: {array1[i]} - {array2[i]}");
                            //Msg($"{result[i]}");
                        }
                        break;

                    case 'm':

                        for (int i = 0; i < cantElem; i++)
                        {
                            result[i] = array1[i] * array2[i];
                            //descomentar para ver proceso
                            //Msg($"Operación: {array1[i]} * {array2[i]}");
                           // Msg($"{result[i]}");
                        }
                        break;

                    case 'd':

                        for (int i = 0; i < cantElem; i++)
                        {
                            if (array2[i] != 0)
                            {
                                result[i] = (float)array1[i] / (float)array2[i];
                                //descomentar para ver proceso
                                //Msg($"Operación: {array1[i]} / {array2[i]}");
                                //Msg($"{result[i]}");
                            }
                            /*
                            //descomentar para ver posicion errores
                            else
                            {   
                                Msg($"Operación: {array1[i]} / {array2[i]}");
                                Msg("No se puede dividir por cero");
                            }
                            */
                        }
                        break;

                    default:
                        Msg("Opcion de operacion no valida:(");
                        break;
                }
            }
            else
            {
                Msg("La cantidad de elementos supera el tamaño de uno de los array");
            }

           
            return result;
        }

        static void Msg(string msg) 
        {
            Console.WriteLine(msg);
        }

        static void MostrarArray(float[] array) 
        { 
            for (int i = 0; i<array.Length; i++)
                Console.WriteLine(array[i]);
        }

      

    }
}
