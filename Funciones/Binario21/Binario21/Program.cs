using System;

namespace Binario21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*21.   Escribir una función que muestre en binario un número entre 0 y 255.*/
            RandomNumBinario();
            Console.ReadKey();
        }

        //funciones
        static void RandomNumBinario()
        {
            byte[] numBinario = new byte[8];

            Random random = new Random(); 

            for (byte i = 0; i < numBinario.Length; i++)
            {
                numBinario[i] = (byte)random.Next(2);

            }

            for (byte i = 0;i < numBinario.Length;i++)
            {
                Console.Write(numBinario[i]);
            }   

        }

       

    }

}
