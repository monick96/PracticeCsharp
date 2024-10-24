namespace Ejercicio2
{
    abstract class Integrante : Iintegrante
    {
        protected string nombre;
        protected string apellido;
        protected int edad;

        public Integrante(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public virtual void MostrarInfo()
        {
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("Info Integrante: ");
            System.Console.WriteLine($"Nombre: {this.nombre}");
            System.Console.WriteLine($"Apellido: {this.apellido}");
            System.Console.WriteLine($"Edad: {this.edad}");
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }
    }
}