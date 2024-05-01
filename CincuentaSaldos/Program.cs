using System;
namespace CincuentaSaldos
{
    class Program
    {
        static void Main (string [] args)
        {
            //Se ingresan 50 saldos de cuentas de un banco. Calcular e informar:
            // a. Cantidad de saldos superiores a $1000.
            // b. Promedio de los restantes.

            float saldo;
            int contSaldoMasMil = 0;
            int contadorResto = 0;
            float promedio;
            float sumaSaldo = 0;

            for( int i = 0; i < 50; i ++)
            {
                Console.WriteLine("Ingrese el saldo: ");
                saldo = float.Parse(Console.ReadLine());

                if(saldo>1000)
                {
                    contSaldoMasMil ++;
                }
                else
                {
                    contadorResto ++;
                    sumaSaldo += saldo;
                }
            }

            promedio = sumaSaldo / contadorResto;

            Console.WriteLine("Se ingresaron " + contSaldoMasMil + " saldos mayores a mil");
            Console.WriteLine("El prodedio de saldos restentes es de $" + promedio);
        }
    }
}
