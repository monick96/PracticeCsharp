
namespace Ejercicio2
{
    class Entrenador: Integrante
    {
        private int aniosExperiencia;

        public Entrenador(string nombre, string apellido, int edad,
        int aniosExperiencia):base(nombre, apellido, edad)
        {
            this.aniosExperiencia = aniosExperiencia;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            System.Console.WriteLine($"Experiencia: {this.aniosExperiencia} años");
        }
    }
}