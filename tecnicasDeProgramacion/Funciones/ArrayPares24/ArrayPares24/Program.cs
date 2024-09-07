using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPares24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 24.Escribir una función a la que se le pasa como parámetro 
             * un array que debe rellenar. Se leerá por teclado una serie 
             * de números: guardar en el array solo los pares e ignorar los impares.
             * También hay que devolver la cantidad de impares ignorados.
             */
            int[] nums;
            int arrayT;
            int cantIgnorado;

            Console.WriteLine("Ingrese el tamaño que quiere darle al array: ");
            arrayT = int.Parse(Console.ReadLine());
            nums = new int[arrayT];

            //rellenar array y devolver cant ignorados(impares)
            cantIgnorado = RelllenarArrayPares(ref nums);

            //mostrar ignorados
            Console.WriteLine($"Se ignoraron {cantIgnorado} numeros ");
            //mostrar array
            MostrarArray(nums);

            Console.ReadKey();

        }
        
        //funciones
        static int RelllenarArrayPares(ref int[] nums)
        {
            int cont = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero para la posicion {i + 1}");
                int num = int.Parse(Console.ReadLine());
                if (Espar(num))
                {
                    nums[i] = num;
                }
                else
                {
                    cont++;
                }

            }

            return cont;
        }

        static void MostrarArray(int[] array)
        {
            int contCero = 0;
            Console.WriteLine("Los valores del array son : ");

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] != 0)
                {
                    Console.WriteLine(array[i]);
                }
                else
                {
                    contCero++;
                }
            }

            if(contCero == array.Length)
                Console.WriteLine("No se ingresaron numeros pares");

        }
      
        static bool Espar(int n)
        {
            bool par = false;

            if (n%2 == 0)
            {
                par = true;
            }

            return par;
        }
    }
}
