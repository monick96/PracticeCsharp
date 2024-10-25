namespace Ejercicio3
{
    abstract class Pago
    {
        protected DateTime fecha;
        protected float monto;

        public Pago (DateTime fecha, float monto)
        {
            this.fecha = fecha;
            this.monto = monto;
        }

        public abstract void ProcesarPago();

        public virtual void MostrarRecibo()
        {
            System.Console.WriteLine("**Recibo**");
            System.Console.WriteLine($"Monto: {this.fecha}");
            System.Console.WriteLine($"Monto: {this.monto}");
        }
    }
}