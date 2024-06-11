using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaArray28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*28.Crear una función que devuelva la suma de un array.*/
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 55 };

            Console.WriteLine(SumarElementosArray(nums));
            Console.ReadKey();
        }

        //funcion que recibe un array de enteros, los suma y devuelve el resultado 
        static int SumarElementosArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
