using System;


namespace ElDobleDe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             7. Armar una función que muestre en pantalla 
             el doble del valor que se le pasa como parámetro.
            */
            int num = 5;

            Console.WriteLine(Doble(num));
            Console.ReadKey();

        }

        static string Doble(int num) 
        {
            string result;
            result = (num * 2) + $" es el doble de {num}";
            return result;
        }
    }
}
