using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pago con efectivo
            Cliente juan = new Cliente("Juan");
            PagoConEfectivo cuenta = new PagoConEfectivo(DateTime.Now, 40000,50000,juan);
            PagoConEfectivo cena = new PagoConEfectivo(DateTime.Now.AddDays(2), 120,100,juan);
            //cuenta.ProcesarPago();

            //pago con tarjeta
            PagoConTarjeta servicio = new PagoConTarjeta(DateTime.Now.AddDays(5), 55000, "25456844654654656");
            PagoConTarjeta netflix = new PagoConTarjeta(DateTime.Now.AddDays(5), 55000, "");
            //servicio.ProcesarPago();

            //array de pagos
            Pago[] pagos = {cuenta,cena, servicio,netflix};

            foreach (Pago pago in pagos)
            {
                pago.ProcesarPago();
            }
        }
    }
}