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
            Console.ReadKey();
        }

        //funcion
        static int ObtenerCantDivisoresPrimos(int num)
        {

            // Declara un array para almacenar los divisores de 'num', con tamaño máximo de 'num / 2'
            int[] div = new int[num / 2];

            // Inicializa el índice para el array de divisores
            int position = 0;

            // Contador para los divisores primos
            int contDivPrimo = 0;

            // Encuentra divisores

            // Añade el propio número si es mayor que 1 (caso del número primo divisible solo x si mismo)
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
            //i<position porque position tiene el tamaño del array con valores
            for (int i = 0; i < position; i++)
            {
                // Inicializa la bandera 'esPrimo' como verdadera
                bool esPrimo = true;

                // Si el divisor es 2, es primo
                if (div[i] == 2)
                {
                    // Incrementa el contador de divisores primos
                    contDivPrimo++;

                    // Continua con el siguiente divisor
                    //continue salta a la siguiente iteracion
                    continue;
                }

                // Si el divisor es par y mayor que 2, no es primo
                if (div[i] % 2 == 0)
                {
                    // Continua con el siguiente divisor
                    //salta a la siguiente iteracion
                    continue;
                }

                // Verifica la primalidad del divisor para los números impares
                for (int j = 3; j < div[i] / 2; j += 2)
                {
                    // Si 'j' es un divisor de 'div[i]'
                    if (div[i] % j == 0)
                    {
                        // Marca 'div[i]' como no primo
                        esPrimo = false;
                        // Sale del bucle
                        break;
                    }
                }

                // Si 'esPrimo' sigue siendo verdadero, 'div[i]' es primo
                if (esPrimo)
                {
                    // Incrementa el contador de divisores primos
                    contDivPrimo++;
                }
            }

            // Retorna el total de divisores primos encontrados
            return contDivPrimo;

        
        }

    }
}
            
           


