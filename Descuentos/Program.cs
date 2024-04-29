using System;
namespace Descuento
{
    class Program
    {
        static void Main(string [] args)
        {
            //Un negocio efectúa descuentos según el importe. Menor a $100 se aplica un descuento del 5%, 
            //entre $100 y $500 un descuento del 10%, y mayor a $500 un 20%.
            //Informar el precio original, el descuento y el precio neto.

            float importe;
            float precioConDescuento;
            float descuento;

            Console.WriteLine("Ingrese el importe: ");
            importe = float.Parse(Console.ReadLine());

            if(importe<100)
            {
                descuento = importe * 0.05f;
                precioConDescuento = importe - descuento;

                Console.WriteLine("El importe $" + importe +" recibio un descuento de $" + 
                descuento + " el importe con descuento es de $" + precioConDescuento);
            }
            else if(importe >= 100 && importe <= 500)
            {
                descuento = importe * 0.10f;
                precioConDescuento = importe - descuento;

                Console.WriteLine("El importe $" + importe +" recibio un descuento de $" + 
                 descuento + " el importe con descuento es de $" + precioConDescuento);
            }
            else
            {
                descuento = importe * 0.20f;
                precioConDescuento = importe - descuento;

                Console.WriteLine("El importe $" + importe +" recibio un descuento de $" + 
                 descuento + " el importe con descuento es de $" + precioConDescuento);
            }
        }
    }
}
