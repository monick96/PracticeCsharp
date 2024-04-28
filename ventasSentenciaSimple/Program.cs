﻿using System;

namespace Ventas
{
    class Program
    {
        static void Main(string [] args)
        {
            //Una empresa comercializa 3 productos y desea saber cuál es el que le da mayor porcentaje de ventas.
            //Para esto debe ingresar el total recaudado por cada producto y el valor de cada uno. Tener en cuenta
            //que el programa debe informar la cantidad vendida de cada producto, y su total de ventas y el
            //porcentaje que dicha cantidad de ventas significa del total. 

            float totalRecaudadoP1;
            float totalRecaudadoP2;
            float totalRecaudadoP3;
            float precioP1;
            float precioP2;
            float precioP3;
            int pMayorPorcentaje;
            int cantidadVendidoP1;
            int cantidadVendidoP2;
            int cantidadVendidoP3;
            float totalVentas;

            //entrada y lectura de datos
            //recaudacion total producto
            Console.WriteLine("Ingrese el total de recaudado del producto 1: ");
            totalRecaudadoP1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el total recaudado del producto 2: ");
            totalRecaudadoP2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el total recaudado producto 3: ");
            totalRecaudadoP3 = float.Parse(Console.ReadLine());

            //precio productos unitario
            Console.WriteLine("Ingrese el precio unitario del producto 1: ");
            precioP1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio unitario del producto 2: ");
            precioP2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del producto 3: ");
            precioP3 = float.Parse(Console.ReadLine());

            //calculo cantidad vendida de cada producto
            cantidadVendidoP1 = (int)(totalRecaudadoP1/precioP1);

            cantidadVendidoP2 = (int)(totalRecaudadoP2/precioP2);

            cantidadVendidoP3 = (int)(totalRecaudadoP3);

            //informe unidades vendidas por producto
            Console.WriteLine("La cantidad vendida del producto 1 es de : " + cantidadVendidoP1 + " unidades");
            Console.WriteLine("La cantidad vendida del producto 2 es de : " + cantidadVendidoP2 + " unidades");
            Console.WriteLine("La cantidad vendida del producto 3 es de : " + cantidadVendidoP3 + " unidades");




        }
    }
}
