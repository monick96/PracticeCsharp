using System;
namespace NumerosParesMenores
{
    class Program
    {
        static void Main(string [] args)
        {
            //Calcular e informar el promedio de los números pares menores a un valor definido por el usuario.
            //Dicho número no debe ser superior a 1500.

            int num;
            int contador = 0;
            int sumaPares = 0;
            int promedio = 0;

            Console.WriteLine("Ingrese un entero menor a 1500: ");
            num = int.Parse(Console.ReadLine());

            while (num <0 || num>1500)
            {
                Console.WriteLine("Valor fuera de rango... Ingrese un entero menor a 1500: ");
                num = int.Parse(Console.ReadLine());  
            }
            
            //arranco del 2 por que se que el uno no es par
            for(int i = 2; i< num;  i ++)
            {
                if(i%2 == 0){
                    contador ++;
                    sumaPares += i;
                }
            }

            promedio = sumaPares/contador;

            Console.WriteLine( " El promedio de los pares es de: " + promedio);
        }
    }
}
