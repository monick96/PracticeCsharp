using System;
namespace CalculoMaximo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Diseñar una función que tenga como parámetros dos números,
                y que calcule el máximo.
            */
            int num1;
            int num2;
            int num3 ;
            int[] ints = new int[5];

            Console.WriteLine("Maximo de dos numeros enteros");

            Console.WriteLine("Ingrese el primer numero entero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero entero: ");
            num2 = int.Parse(Console.ReadLine());

            //invocacion de funcion
            int resp = maximo(num1, num2);
            if (resp == 0)
            {
                Console.WriteLine(" Los numeros son iguales");
            }
            else
            {
                Console.WriteLine($"{resp} es mayor");
            }
            //fin punto 3

            ////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Presione enter para continuar al punto 4...");
            Console.WriteLine(" ");
            Console.ReadKey();
            ////////////////////////////////////////////////////////////////////////
            
            //4.  Idem al anterior pero que calcule el máximo de 3 números.
            Console.WriteLine("Maximo de tres numeros enteros");

            Console.WriteLine("Ingrese el primer numero entero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero entero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero entero: ");
            num3 = int.Parse(Console.ReadLine());
            //invocacion de funcion
            int resp2 = maximo3N(num1, num2,num3);
            if (resp2 == 0)
            {
                Console.WriteLine(" Los numeros son iguales");
            }
            else
            {
                Console.WriteLine($"{resp2} es mayor");
            }

            //fin punto 4

            /////////////////////////////////////////////////////////////////////
            Console.WriteLine("Presione enter para continuar al punto 5...");
            Console.WriteLine(" ");
            Console.ReadKey();
            /////////////////////////////////////////////////////////////////////
            //5.  Idem al anterior pero que calcule el máximo de un array de n elementos.
            Console.WriteLine("Maximo de un array");
            // Console.WriteLine(maximo3(ints));
            Console.WriteLine("Maximo de Array de 5 numeros enteros");
         
            Console.WriteLine("Ingrese el primer numero entero: ");
            ints[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero entero: ");
            ints[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero entero: ");
            ints[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto numero entero: ");
            ints[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el quinto numero entero: ");
            ints[4] = int.Parse(Console.ReadLine());

            //invocacion de funcion
            int resp3 = maximoA(ints);
            if (resp3 == 0)
            {
                Console.WriteLine(" Los numeros son iguales");
            }
            else
            {
                Console.WriteLine($"{resp3} es mayor");
            }

            //fin punto 5

            Console.ReadKey();
            
        }

        //declaracion de funciones
        static int maximo(int n1, int n2 ) 
        {
            int result; 
            if ( n1 == n2 ) 
            {
                result = 0;
            }
            else if(n1 > n2)
            {
                result = n1;
            }
            else
            {
                result = n2;
            }

            return result;
        }

        static int maximo3N(int n1, int n2, int n3  ) 
        {
            int result;
            
            if (n1 > n2 && n1 > n3)
            {
                result = n1;
            }
            else if (n2 > n1 && n2 > n3)
            {
                result = n2;
            }
            else if (n3 > n1 && n3 > n2)
            {
                result = n3;
            }
            else
            {
                result = 0;
            }
            return result;
        }

        static int maximoA(int[] arrayNums)
        {
            //la posicion 0 la uso como mi maximo para comparar
            int max = arrayNums[0]; 
            int igualdad = 0;

            for (int i = 1; i < arrayNums.Length; i++)
            {
                if (arrayNums[i] > max )
                {
                    max = arrayNums[i];
                }
                else if (arrayNums[i] == max )
                {
                    igualdad ++;
                }   
            }
            //verificacion de si los numeros son todos iguales en el array
            //resto uno por que al array en posicion cero lo use como bandera para el maximo
            if (igualdad == arrayNums.Length -1)
            {
                max = 0;
            }
            
            return max;
            

            
        }
    }
}
