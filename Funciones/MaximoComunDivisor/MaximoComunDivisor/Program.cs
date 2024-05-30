using System;

namespace MaximoComunDivisor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * El máximo común divisor (MCD) es el mayor número que divide 
             * exactamente a dos o más números sin dejar residuo.
             
             * 12. Escribir una función que calcule el máximo común divisor de dos números. 
             * 13. Escribir una función que calcule el máximo común divisor de tres números
             * 14. Escribir una función que calcule el máximo 
             * común divisor de los números contenidos en un array
            */
            /*
            int num1;
            int num2;
            int num3;
            int arrayT;
            int[] nums;
            
            Console.WriteLine("MCD entre dos numeros");
            Console.WriteLine("Ingrese el primer numero");
            num1= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            int result = MCDdosN(num1,num2);

            Console.WriteLine(result);
            
            ///fin punto 12
            //////////////////////////////////////////////////////////////////
            Console.WriteLine("ENTER para el siguiente punto...");

            Console.ReadKey();
            ///////////////////////////////////////////////////////////////////////
            Console.WriteLine("MCD entre tres numeros");
            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero");
            num3 = int.Parse(Console.ReadLine());

            int result2 = MCDtresN(num1, num2, num3);

            Console.WriteLine(result2);
            ///fin punto 13
            //////////////////////////////////////////////////////////////////
            Console.WriteLine("ENTER para el siguiente punto...");

            Console.ReadKey();
            ///////////////////////////////////////////////////////////////////////
            Console.WriteLine("MCD array numeros");
            Console.WriteLine("Ingrese el tamaño que quiere darle al array: ");
            arrayT = int.Parse(Console.ReadLine());
            nums = new int[arrayT];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero para la posicion {i+1}");
                nums[i] = int.Parse(Console.ReadLine());
            }

            int result3 = MCDn(nums);

            Console.WriteLine(result3);
            Console.ReadKey();
            */
           Menu();
         

        }
        /// funciones 
        static void Menu()
        {
            bool activeMenu = true;
            while (activeMenu)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Calcular MCD entre dos números");
                Console.WriteLine("2. Calcular MCD entre tres números");
                Console.WriteLine("3. Calcular MCD de un array de números");
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
                        Console.WriteLine("MCD entre dos numeros");
                        Console.WriteLine("Ingrese el primer numero");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero");
                        num2 = int.Parse(Console.ReadLine());

                        result = MCDdosN(num1, num2);

                        Console.WriteLine($"El MCD de {num1} y {num2} es: {result}");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("MCD entre tres numeros");
                        Console.WriteLine("Ingrese el primer numero");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo numero");
                        num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el tercer numero");
                        num3 = int.Parse(Console.ReadLine());

                        result = MCDtresN(num1, num2, num3);

                        Console.WriteLine($"El MCD de {num1}, {num2} y {num3} es: {result}");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("MCD array numeros");
                        Console.WriteLine("Ingrese el tamaño que quiere darle al array: ");
                        arrayT = int.Parse(Console.ReadLine());
                        nums = new int[arrayT];

                        for (int i = 0; i < nums.Length; i++)
                        {
                            Console.WriteLine($"Ingrese el numero para la posicion {i + 1}");
                            nums[i] = int.Parse(Console.ReadLine());
                        }

                        result = MCDn(nums);

                        Console.WriteLine($"El MCD del array es: {result}");
                        Console.ReadKey();
                        break;
                    case 4:
                        activeMenu = false; // Sale del menú y termina el programa
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }
                if(activeMenu)
                {
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadKey();
                }
                
            }
        }

        static int MCDn(int[] nums)
        {
            int mcd;
            //obtengo el mcd de los 2 primeros numeros
            mcd = MCDdosN(nums[0], nums[1]);

            //obtengo el mcd del tercer numero usando el mcd de los dos anteriores
            for(int i = 2; i < nums.Length;i ++)
            {
                mcd = MCDdosN(mcd, nums[i]);
            }

            return mcd;

        }
        static int MCDtresN(int num1, int num2, int num3)
        {
            int mcd;
            //obtengo el mcd de los 2 primeros numeros
            mcd = MCDdosN(num1, num2);

            //obtengo el mcd del tercer numero usando el mcd de los dos anteriores
            mcd = MCDdosN(num3, mcd);

            return mcd;

        }
        static int MCDdosN(int num1, int num2)
        {
            int mayor;
            int menor;
            int residuo;
            int mcd;

            //verificar que no se divida por cero
            if (num1 == 0 || num2 == 0)
            {
                
                 return -1; // Valor indicativo de error
            }
            //comprobacion del mayor num
            //en caso que la div tenga resto cero el
            //menor se asigna al mcd para retornarlo
            if (num1 > num2)
            {
                residuo = num1 % num2;
                menor = num2;
                mcd = menor;
            }
            else
            {
                residuo = num2 % num1;
                menor = num1;
                mcd = menor;
            }

            //mientras el residuo no sea cero
            while (residuo > 0)
            {
                mayor = menor;
                menor = residuo;
                residuo = mayor % menor;
                mcd = menor;
            }
            return mcd;
        }
    }      
    
}
