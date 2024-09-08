using System;

namespace NumerosAmigos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 18. Escribir una función que indique si dos números
             * enteros positivos son amigos. Dos números son amigos, 
             * cuando la suma de los divisores propios de cada uno es igual al otro número.
             */
            ushort num1;
            ushort num2;

            Console.WriteLine("Numeros Amigos:");
            Console.WriteLine(" Ingrese el primer numero...");
            num1 = ushort.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese el primer numero...");
            num2 = ushort.Parse(Console.ReadLine());
            //con valores que se ingreso por consola
            NumerosAmigos(num1,num2);

            //con valores por defecto comprobados que son amigos
            Console.WriteLine(" ");
            Console.WriteLine("pero... ");
            NumerosAmigos();
            Console.ReadKey();
        }
        
        static void NumerosAmigos (ushort num1 = 284, ushort num2 =220)
        {
            //obttengo el array de divisores del numero 1
            ushort[] arrayDivNum1 = ObtenerArrayDivisores(num1);

            //obttengo el array de divisores del numero 2
            ushort[] arrayDivNum2 = ObtenerArrayDivisores(num2);

            //sumo el array de divisores
            int sumaArray1 = SumarElementosArray(arrayDivNum1);

            int sumaArray2 = SumarElementosArray(arrayDivNum2);

            //comparo y devuelvo por consola
            if(sumaArray1 == num2 && sumaArray2 == num1)
            {
                Console.WriteLine($"Los numeros {num1} y {num2} son amigos :)");
            }
            else 
            {
                //Console.WriteLine($" la suma de divisores del {num1} es: {sumaArray1}");
                //Console.WriteLine($" la suma de divisores del {num2} es: {sumaArray2}");
                Console.WriteLine("No son amigos :(");
            }
        }

        //funcion para obtener array de divisores
        static ushort[] ObtenerArrayDivisores(ushort num )
        {
            ushort[] result = new ushort[num/2];
            int posicion = 0;
            for (ushort i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    result[posicion] = i;
                }
                    
                posicion++;
            }
            return result;
        }
        
        //funcion que recibe un array de numeros, los suma y devuelve el resultado como un entero
        static int SumarElementosArray(ushort[] array) 
        { 
            int sum = 0;
            for(ushort i = 0; i<array.Length; i ++)
            { 
                sum += array[i]; 
            }
            return sum;
        }
    }
}
