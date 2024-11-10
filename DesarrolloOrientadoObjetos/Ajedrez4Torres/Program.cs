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
        private string color ; 

        public Torre(string color,int numeroTorre, char columna, int fila)
        {
            this.color = color;
            this.fila = fila;
            this.columna = columna;
            this.numeroTorre = numeroTorre;
        }

        public int GetNumeroTorre()
        {
            return this.numeroTorre;
        }

        public string GetColorTorre()
        {
            return this.color;
        }

        public void CambiarPosicion(int fila, char columna)
        {
            if (this.MovimientoEsValido(fila, columna))
            {
                this.fila = fila;
                this.columna = columna;
                System.Console.WriteLine("Cambio la posicion de la torre");
                this.MostrarPosicion();
            }else
            {
                System.Console.WriteLine($"Movimiento invalido en fila o columna {this.fila}{this.columna}");
            }  
        }

        public bool MovimientoEsValido(int fila, char columna)
        {
            bool valido = false;

            if (this.fila == fila || this.columna == columna)
            {
                valido = true;
            }

            return valido;
        }

        public void MostrarPosicion()
        {
            System.Console.WriteLine($"Torre {this.numeroTorre} {this.color}");
            System.Console.WriteLine($"{this.columna}{this.fila}");
        }
    }

    class Jugador 
    {
        private string nombre {get;}
        private List<Torre> torres;
        private int cantidadTorres {get; set;}

        public Jugador (string nombre)
        {
            this.nombre = nombre;
            this.cantidadTorres = 2;
            this.torres = new List<Torre>();
        }

        public void AgregarTorres(Torre torre)
        {
            if ( this.torres.LongCount()<3)
            {
                this.torres.Add(torre);
                System.Console.WriteLine($"Torre {torre.GetNumeroTorre} {torre.GetColorTorre} agregada");
            }else
            {
                System.Console.WriteLine("Ya no se pueden agregar mas torres");
            }
        }



    }
}