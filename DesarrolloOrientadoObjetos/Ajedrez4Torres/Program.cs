using System;

namespace Ajedrez4Torres 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Torre 
    {
        private int fila;
        private char columna;
        private int numeroTorre;
        private string color;

        public Torre(string color,int numeroTorre, char columna, int fila)
        {
            this.color = color;
            this.fila = fila;
            this.columna = columna;
            this.numeroTorre = numeroTorre;
        }

        public void CambiarPosicion(int fila, char columna)
        {
            this.fila = fila;
            this.columna = columna;

            this.MostrarPosicion();
        }

        public void MostrarPosicion()
        {
            System.Console.WriteLine($"Torre {this.numeroTorre} {this.color}");
            System.Console.WriteLine($"{this.columna}{this.fila}");
        }
    }

    class Jugador 
    {
        private string nombre;
        private List<Torre> torres;
        private int cantidadTorres;

    }
}