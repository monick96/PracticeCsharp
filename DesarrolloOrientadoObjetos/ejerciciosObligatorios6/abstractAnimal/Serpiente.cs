namespace Ejercicio1
{
    class Serpiente : Reptil
    {
       
        protected bool venenosa;
        public Serpiente (float peso, int edad, bool columnaVertebral, string tipoSangre, string tipoEscama, bool venenosa):base(peso,edad, columnaVertebral, tipoSangre,tipoEscama)
        {
            this.venenosa = venenosa;
        }
        public override void Moverse()
        {
            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine("La serpiente esta reptando...");
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            System.Console.WriteLine($"Venenosa: {this.venenosa}");
        }
        public override void RegularTemperatura()
        {
            System.Console.WriteLine("---------------------");
            System.Console.WriteLine(" La serpirnte esta tomando sol...");
        }
        
    }
}