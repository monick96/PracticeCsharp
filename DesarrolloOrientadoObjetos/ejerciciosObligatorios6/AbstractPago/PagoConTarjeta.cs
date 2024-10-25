namespace Ejercicio3
{
    class PagoConTarjeta: Pago, IValidar
    {
        private string numeroTarjeta;
        
        public PagoConTarjeta(DateTime fecha, float monto, string numeroTarjeta):base(fecha, monto)
        {
            this.numeroTarjeta = numeroTarjeta;
        }

        public override void ProcesarPago()
        {
            if (Validar())
            {
                System.Console.WriteLine("Pago Aprobado!");
                this.MostrarRecibo();
            }
            else
            {
                System.Console.WriteLine("Este campo no puede estar vacio");
            }
        }

        public bool Validar()
        {
            bool valido = false;

            if (string.IsNullOrEmpty(this.numeroTarjeta))
            {
                valido = true;
            }

            return valido;
        }
    }
}