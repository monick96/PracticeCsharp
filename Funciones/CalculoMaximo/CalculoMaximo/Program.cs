using System;


namespace CalculoMaximo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                3.  Diseñar una función que tenga
                como parámetros dos números,
                y que calcule el máximo.
            */
            int num1 = 5;
            int num2 = 6;
            int num3 = 7;
            int[] ints = new int[] { num1, num2, num3, 50, 20, 30, 60, 100, 12, 58 };

            Console.WriteLine("Maximo de dos numeros");
            Console.WriteLine(maximo(num1,num2));

            Console.WriteLine("Maximo de tres numeros");
            Console.WriteLine(maximo1(num1,num2,num3));

            Console.WriteLine("Maximo de un array");
            Console.WriteLine(maximo3(ints));

            Console.ReadKey();
            
        }
        static string maximo(int n1, int n2 ) 
        {
            string result = ""; 
            if ( n1 > n2 ) 
            {
                result = $"El numero {n1}, es mayor que {n2}";
            }
            else
            {
                result = $"El numero {n2}, es mayor que {n1}";
            }
            return result;
        }

        static string maximo1(int n1, int n2, int n3  ) 
        {
            string result = "";
            if (n1 > n2 && n1 > n3)
            {
                result = $"El numero {n1}, es mayor que {n2} y que {n3}";
            }
            else if (n2 > n1 && n2 > n3)
            {
                result = $"El numero {n2}, es mayor que {n1}  y que {n3}";
            }
            else
            {
                result = $"El numero {n3}, es mayor que {n1}  y que {n2}";
            }
            return result;
        }

        static string maximo3(int[] arrayNums)
        {
            int max = arrayNums[0];

            string result = "";

            for (int i = 1; i < arrayNums.Length; i++)
            {
                if (arrayNums[i] > max )
                {
                    result = $"El numero {arrayNums[i]}, es el mayor";
                }
                
            }
            
            return result;
        }
    }
}
