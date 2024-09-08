using System;


namespace MinimoComunMultiplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*El mínimo común múltiplo (MCM) 
             * es el menor número que es múltiplo de dos o más números.
             * MCM(a,b) = (a*b)/MCD(a,b)
             * 
             * 15. Escribir una función que calcule el mínimo común múltiplo de dos números.
             * 16. Escribir una función que calcule el mínimo común múltiplo de tres números. 
             * 17.  Escribir una función que calcule el mínimo común múltiplo de los números 
             * contenidos en un array.
            */
            /*
            Console.WriteLine("MCM entre dos numeros: ");
            Console.WriteLine(MCMdosN(12, 8));

            Console.WriteLine("MCM entre tres numeros: ");
            Console.WriteLine(MCMtresN(18, 24, 12));



            Console.WriteLine("MCM de un array ");
            int[] arrayNums = { 12, 18, 5, 30 };
            Console.WriteLine(MCMarray(arrayNums));

            Console.ReadKey();
            */
            Menu();


        }

        // Función para calcular el MCM de un array de números
        static int MCMarray(int[] nums)
        {
            //calculo el mcm de los dos primeros numeros
            int mcm = MCMdosN(nums[0], nums[1]);

            //inicio el for en 2 para calcular el resto 
            //del array
            for (int i = 2; i < nums.Length; i++)
            {
                mcm = MCMdosN(mcm, nums[i]);
            }
            return mcm;

        }

        // Función para calcular el MCM de tres números
        static int MCMtresN(int n1, int n2, int n3)
        {

            //saco el mcm de los primeros dos
            int mcm = MCMdosN(n1, n2);
            //uso el resultado anterior de mcm para sacar
            //el mcm con el 3er numero
            mcm = MCMdosN(mcm, n3);

            return mcm;
        }
        // Función para calcular el MCM de dos números
        static int MCMdosN(int n1, int n2)
        {
            //obtengo el mcd
            int mcd = MCDdosN(n1, n2);

            //multiplico ambos numeros y los divido por su mcd
            int mcm = (n1 * n2) / mcd;

            return mcm;
        }

        //mcd por algoritmo de Euclides
        static int MCDdosN(int num1, int num2)
        {
            int mcd = 0;
            //verificar que no se divida por cero
            if (num1 == 0 || num2 == 0)
            {

                return -1; // Valor que indica error
            }
            while (num2 != 0)
            {
                int temp = num2; // Guarda el valor de num2 
                num2 = num1 % num2; // Calcula el residuo
                num1 = temp; // Actualiza num1 con el valor de num2
                mcd = num1;
            }
            return mcd; // Cuando num2 es 0, num1 es el MCD
        }

        static void Menu()
        {
            bool activeMenu = true;

            while (activeMenu)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Calcular MCM entre dos números");
                Console.WriteLine("2. Calcular MCM entre tres números");
                Console.WriteLine("3. Calcular MCM de un array de números");
                Console.WriteLine("4. Salir");

                int opcion = int.Parse(Console.ReadLine());

                ///varibles
                int num1;
                int num2;
                int num3;
                int arrayT;
                int[] nums;
                int result;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("MCM entre dos numeros");
                        Console.WriteLine("Ingrese el primer numero");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero");
                        num2 = int.Parse(Console.ReadLine());

                        result = MCMdosN(num1, num2);

                        Console.WriteLine($"El MCM de {num1} y {num2} es: {result}");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("MCM entre tres numeros");
                        Console.WriteLine("Ingrese el primer numero");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero");
                        num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el tercer numero");
                        num3 = int.Parse(Console.ReadLine());

                        result = MCMtresN(num1, num2, num3);

                        Console.WriteLine($"El MCM de {num1}, {num2} y {num3} es: {result}");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("MCM de un array numeros");
                        Console.WriteLine("Ingrese el tamaño que quiere darle al array: ");
                        arrayT = int.Parse(Console.ReadLine());
                        nums = new int[arrayT];

                        for (int i = 0; i < nums.Length; i++)
                        {
                            Console.WriteLine($"Ingrese el numero para la posicion {i + 1}");
                            nums[i] = int.Parse(Console.ReadLine());
                        }

                        result = MCMarray(nums);

                        Console.WriteLine($"El MCM del array es: {result}");
                        Console.ReadKey();
                        break;
                    case 4:
                        activeMenu = false; // Sale del menú y termina el programa
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }
                if (activeMenu)
                {
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadKey();
                }
            }

        }

    }   

}

