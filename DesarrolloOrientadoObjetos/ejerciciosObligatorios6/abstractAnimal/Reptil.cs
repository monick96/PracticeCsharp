namespace Ejercicio1
{
    abstract class Reptil:Vertebrado
    {
       
        protected string tipoEscama;
        public Reptil (float peso, int edad, bool columnaVertebral, string tipoSangre, string tipoEscama):base(peso,edad, columnaVertebral, tipoSangre)
        {
            this.tipoEscama = tipoEscama;
        }
        public override void Moverse()
        {
            System.Console.WriteLine("Reptando...");
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            System.Console.WriteLine($"Tipo Escama: {this.tipoEscama}");
        }
         public abstract void RegularTemperatura();
        
    }
}