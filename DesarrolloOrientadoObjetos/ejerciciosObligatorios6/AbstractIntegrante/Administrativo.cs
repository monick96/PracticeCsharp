namespace Ejercicio2
{
    class Administrativo: Integrante
    {
        private string puesto;
        private string profesion;

        public Administrativo(string nombre, string apellido, int edad,
        string puesto, string profesion):base(nombre, apellido, edad)
        {
            this.profesion = profesion;
            this.puesto = puesto;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            System.Console.WriteLine($"Profesion: {this.profesion}");
            System.Console.WriteLine($"Puesto: {this.puesto}");
        }
    }
}