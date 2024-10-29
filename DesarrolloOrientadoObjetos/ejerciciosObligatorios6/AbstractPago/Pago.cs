namespace Ejercicio3
{
    internal abstract class Pago
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
            System.Console.WriteLine($"Fecha: {this.fecha}");
            System.Console.WriteLine($"Monto: ${this.monto}");
        }
    }
}