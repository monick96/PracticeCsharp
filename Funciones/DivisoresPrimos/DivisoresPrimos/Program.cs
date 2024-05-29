using System;


namespace DivisoresPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             10. Crear una función a la que se le pasa un número entero y
            devuelve la cantidad de divisores primos que tiene.
             */
            int num;

            Console.WriteLine("Ingrese un entero: ");
            num = int.Parse(Console.ReadLine());

            int result = ObtenerCantDivisoresPrimos(num);
            Console.WriteLine($"El número {num} tiene {result} divisores primos.");
           
            Console.WriteLine(" Presione enter para pasar al siguiente punto...");
            Console.ReadKey();
            //fin punto 10

            /////////////////////////////////////////////////////////////////////////////
            /*11.  Crear una función a la que se le pasa un número entero 
             * y devuelve un array con los divisores primos de dicho número.*/
            ///////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Ingrese un entero: ");
            num = int.Parse(Console.ReadLine());

            int [] resultArray = obtenerArrayDivPrimos(num);

            Console.WriteLine($"El número {num} tiene Los siguientes divisores primos: ");
            for (int i = 0;i<resultArray.Length; i++)
            {
                if (resultArray[i] != 0)
                    Console.WriteLine(resultArray[i]);
            }

            Console.ReadKey();
        }

        // declaracion funcion
        static int ObtenerCantDivisoresPrimos(int num)
        {

            // Declara un array para almacenar los divisores de 'num', con tamaño máximo de 'num / 2'
            int[] div = new int[num / 2];

            // Inicializa el índice para el array de divisores
            int position = 0;

            // Contador para los divisores primos
            int contDivPrimo = 0;

            // Encuentra divisores

            // Añade el propio número si es mayor que 1
            // (caso del número primo divisible solo x si mismo)
            if (num > 1)
            {
                div[position] = num;
                position++;
            }

            for (int i = 2; i <= num / 2; i++)
            {
                // Si 'i' es un divisor de 'num'
                if (num % i == 0)
                {
                    // Almacena 'i' en el array de divisores
                    div[position] = i;

                    // Incrementa la posición del array
                    position++;
                }
            }

            // Verifica si los divisores son primos
            //i < position porque position tiene el tamaño del array con valores
            for (int i = 0; i < position; i++)
            {
                if (EsPrimo(div[i]))
                {
                    // Incrementa el contador de divisores primos
                    contDivPrimo++;
                }
            }

            // Retorna el total de divisores primos encontrados
            return contDivPrimo;

        
        }
        
        static int[] obtenerArrayDivPrimos(int num)
        {   //array a retornar tamaño n/2
            int[] arrayPrimo = new int[num / 2];

            // Declara un array para almacenar los divisores de
            // 'num', con tamaño máximo de 'num / 2'
            int[] div = new int[num / 2];

            int position = 0;

            // Añade el propio número si es mayor que 1
            // (caso del número primo divisible solo x si mismo)
            if (num > 1)
            {
                div[position] = num;
                position++;
            }

            for (int i = 2; i <= num / 2; i++)
            {
                // Si 'i' es un divisor de 'num'
                if (num % i == 0)
                {
                    // Almacena 'i' en el array de divisores
                    div[position] = i;

                    // Incrementa la posición del array
                    position++;
                }
            }

            // Verifica si los divisores son primos
            //i < position porque position tiene el tamaño del array con valores
            for(int i = 0; i < position;i ++)
            {
                if (EsPrimo(div[i]))
                {
                    arrayPrimo[i]= div[i];
                }
            }
            return arrayPrimo;
        }

       
        
        static bool EsPrimo(int num)
        {
            bool verificacion = true;
            // Los números menores o iguales a 1 no son primos
            if (num <= 1) 
                verificacion = false;

            // 2 es el único número primo par
            if (num == 2) 
                verificacion = true;

            // Números pares mayores que 2 no son primos
            if (num % 2 == 0) 
                verificacion = false; 

            // Revisa los números impares desde 3 hasta la mitad del número
            for (int i = 3; i <= (num/2); i += 2)
            {
                if (num % i == 0) 
                    verificacion = false; // Si num es divisible por i, no es primo
            }

            // Si no se encontró ningún divisor, es primo
            return verificacion; 
        }

    }
}
            
           


