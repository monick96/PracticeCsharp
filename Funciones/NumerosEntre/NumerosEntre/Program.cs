using System;
namespace NumerosEntre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                6. Se necesita crear una función a la que se le pasan
                por parámetro dos enteros y muestra todos los números 
                comprendidos entre ellos, inclusive.
             */
            int num1 = 5; 
            int num2 = 8;

            Console.WriteLine($"Los numeros entre {num1} y {num2} son: ");

            Console.WriteLine(numerosEntre(num1,num2));

            Console.ReadKey();

        }

        static string numerosEntre(int n1, int n2)
        {
            string result = "";

            if (n1 <= n2) 
            {
                for (int i = n1; i <= n2; i++)
                {
                    result += i + " ";
                }
                
            }
            else
            {
                result = " El numero de inicio debe ser menor o igual al numero 2 o numero final";
            }

            return result;
        }
    }
}
