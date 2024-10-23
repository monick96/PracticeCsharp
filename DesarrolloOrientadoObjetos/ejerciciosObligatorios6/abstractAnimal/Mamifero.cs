namespace Ejercicio1
{
    abstract class Mamifero : Vertebrado
    {
       
        protected string tipoPelaje;
        public Mamifero (float peso, int edad, bool columnaVertebral, string tipoSangre, string tipoPelaje):base(peso,edad, columnaVertebral, tipoSangre)
        {
            this.tipoPelaje = tipoPelaje;
        }
        public override void Moverse()
        {
            System.Console.WriteLine("Caminando y moviendo las patitas...");
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            System.Console.WriteLine($"Pelaje: {this.tipoPelaje}");
        }
         public abstract void HacerSonido();
        
    }
}