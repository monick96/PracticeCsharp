namespace Ejercicio3
{
    class PagoConEfectivo: Pago, IValidar
    {
        private float montoPagoCliente;
        private Cliente cliente;

        public PagoConEfectivo(DateTime fecha, float montoPagoCliente, Cliente cliente):base(fecha, monto)
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
                System.Console.WriteLine("Monto no valido");
            }
            
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