namespace Ejercicio3
{
    class PagoConTarjeta: Pago, IValidar
    {
        private string numeroTarjeta;
        
        public PagoConTarjeta(DateTime fecha, float monto, string numeroTarjeta):base(fecha, monto)
        {
            this.numeroTarjeta = numeroTarjeta;
        }

        public override void MostrarRecibo()
        {
            System.Console.WriteLine("**Recibo**");
            //obtiene los ultimos 4 elementos de la strin
            string ultimosCuatro = this.numeroTarjeta.Substring(this.numeroTarjeta.Length - 4);
            base.MostrarRecibo();
            System.Console.WriteLine($"Tarjeta: xxxx {ultimosCuatro}");

        }

        public override void ProcesarPago()
        {
            if (Validar())
            {
               System.Console.WriteLine("---------------------------");
                this.MostrarRecibo();
                System.Console.WriteLine("Pago Aprobado!");
                System.Console.WriteLine("--------------------------");
            }
            else
            {
                System.Console.WriteLine("-------------------------------");
                System.Console.WriteLine($"El campo: numero de tarjeta \nno puede estar vacio");
                System.Console.WriteLine("--------------------------------");
            }
        }

        public bool Validar()
        {
            bool valido = false;

            if (!string.IsNullOrEmpty(this.numeroTarjeta))
            {
                valido = true;
            }

            return valido;
        }
    }
}