namespace Ejercicio2
{
    class Jugador : Integrante
    {
        private int posicion;
        private string categoria;

        public Jugador(string nombre, string apellido, int edad,int posicion,
         string categoria):base(nombre, apellido, edad)
        {
            this.categoria = categoria;
            this.posicion = posicion;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            System.Console.WriteLine($"Categoria: {this.categoria}");
            System.Console.WriteLine($"Posicion: {this.posicion}");
        }
    }
}