using System;

namespace PracticaParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Acuario
    {
        private string nombre;
        private List<Pez> peces;

        public Acuario(string nombre)
        {
            this.nombre = nombre;
        }

        public void MostrarPeces()
        {
            foreach (Pez pez in peces)
            {
                pez.MostrarInfo();
            }
        }
        
    }

    abstract class Pez
    {
        protected string nombre;
        protected string especie;
        protected float tamanioCM;



    }
}