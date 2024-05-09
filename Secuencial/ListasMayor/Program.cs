using System;
namespace ListasMayor
{
    class Program
    {
        static void Main(string [] args)
        {
            //Realizar un programa que permita cargar dos listas de 15 valores cada una. Informar con un mensaje
            //cuál de las dos listas tiene un valor acumulado mayor (mensajes "Lista 1 mayor", "Lista 2 mayor",
            //"Listas iguales")

            int valor;
            int sumaLista1 = 0;
            int sumaLista2 = 0;

            //lista1
            for(int i = 1; i <16 ; i++)
            {
                Console.WriteLine("Ingrese los valore de la lista 1: ");
                valor = int.Parse(Console.ReadLine());
                sumaLista1 += valor;
            }

            //lista2
            for(int i = 1; i <16 ; i++)
            {
                Console.WriteLine("Ingrese los valore de la lista 2: ");
                valor = int.Parse(Console.ReadLine());
                sumaLista2 += valor;
            }

            //evaluacion de valores
            if(sumaLista1 == sumaLista2)
            {
                Console.WriteLine("La listas iguales");
            }
            else if(sumaLista1>sumaLista2)
            {
                Console.WriteLine("La lista 1 es mayor");
            }
            else
                Console.WriteLine("La lista 2 es mayor");
        }
    }
}