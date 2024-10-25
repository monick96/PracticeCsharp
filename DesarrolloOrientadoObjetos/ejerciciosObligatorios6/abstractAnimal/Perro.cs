namespace Ejercicio1
{
    class Perro : Mamifero
    {
       
        protected string nombre;
        public Perro (float peso, int edad, bool columnaVertebral, string tipoSangre, string tipoPelaje, string nombre):base(peso,edad, columnaVertebral, tipoSangre,tipoPelaje)
        {
            this.nombre = nombre;
        }
        public override void Moverse()
        {
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine($"{this.nombre} esta:");
            System.Console.WriteLine("Caminando y moviendo las patitas...");
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            System.Console.WriteLine($"Nombre: {this.nombre}");
        }
        public override void HacerSonido()
        {
            System.Console.WriteLine("---------------------------------");
            System.Console.WriteLine($"{this.nombre} esta Ladrando...");
        }
        
    }
}