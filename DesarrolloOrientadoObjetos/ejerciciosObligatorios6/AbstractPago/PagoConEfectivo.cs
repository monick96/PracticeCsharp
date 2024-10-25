namespace Ejercicio3
{
    class PagoConEfectivo: Pago, IValidar
    {
        private float montoPagoCliente;
        private Cliente cliente;

        public PagoConEfectivo(DateTime fecha,float monto, float montoPagoCliente,
         Cliente cliente):base(fecha, monto)
        {
            this.montoPagoCliente = montoPagoCliente;
            this.cliente = cliente;
        }

        public override void ProcesarPago()
        {
            if (Validar())
            {
                this.MostrarRecibo();
            }
            else
            {
                System.Console.WriteLine("--------------------");
                System.Console.WriteLine($"Monto no valido, ${this.montoPagoCliente}\nes menor al total");
                System.Console.WriteLine("--------------------");
            }
            
        }

        public override void MostrarRecibo()
        {
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("**Recibo**");
            System.Console.WriteLine($"Cliente: {this.cliente.GetName()}");
            base.MostrarRecibo();
            System.Console.WriteLine($"Recibimos: ${this.montoPagoCliente}");
        }

        public bool Validar()
        {
           bool montoValido = false;

            if (this.montoPagoCliente >= monto )
            {
                montoValido = true;
            }

            return montoValido;
        }




    }
}