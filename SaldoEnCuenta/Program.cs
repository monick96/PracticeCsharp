using System;
namespace SaldoEnCuenta
{
    class Program
    {
        static void Main (string [] args)
        {
            //Ingresar el saldo de una cuenta bancaria y el importe que 
            //desea extraer el propietario de la misma. Si el saldo
            //es suficiente, calcular e informar el nuevo saldo. 
            //En caso contrario escribir el mensaje: “Saldo Insuficiente”

            float saldo;
            float importeExtraccion;

            Console.WriteLine("Ingrese su saldo: ");
            saldo = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese saldo a extraer: ");
            importeExtraccion = float.Parse(Console.ReadLine());

            if(importeExtraccion>saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else if(importeExtraccion<0)
            {
                Console.WriteLine("Importe invalido!");
            }
            else
            {
                saldo -= importeExtraccion;
                Console.WriteLine("Extraccion completada!");
                Console.WriteLine("Su nuevo saldo es de $" + saldo);
            }
                
        }
    }
}
