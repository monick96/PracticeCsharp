namespace Ejercicio3
{
    internal class Cliente
    {
        private string nombre;

        public Cliente (string nombre)
        {
            this.nombre = nombre;
        }

        public string GetName()
        {
            return this.nombre;
        }
    }
}