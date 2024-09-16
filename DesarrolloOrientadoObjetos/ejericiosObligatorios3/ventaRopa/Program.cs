using System;
namespace VentaRopa
{
    internal class Program
    {
        public static void Main(string[] args)
        {

        }
    }

    public class Ropa
    {
        private int numeroStock;
        private string nombrePresentacion;
        private float precioUnitario;
        private float precioMayorista;

        public Ropa (int numeroStock, string nombrePresentacion)
        {
            this.numeroStock = numeroStock;
            this.nombrePresentacion = nombrePresentacion;
        }

        
    }

    public class Pantalon : Ropa 
    {
        private string tipo;
        private int talle;//talles del 35 al 52
        public Pantalon(int numeroStock,string nombrePresentacion,string tipo, int talle):base(numeroStock,nombrePresentacion)
        {
            this.talle = talle;
            this.tipo = tipo;
        }
    }

    public class RopaTalleAlphaSizing : Ropa
    {
        private string talle; //S,M,L, etc

        public RopaTalleAlphaSizing(int numeroStock,string nombrePresentacion,string talle):base(numeroStock,nombrePresentacion)
        {
            this.talle = talle;
            
        }
    }

    public class Remera : RopaTalleAlphaSizing
    {
        private string tipo;

        public Remera(int numeroStock, string nombrePresentacion, string talle, string tipo):
        base(numeroStock,nombrePresentacion,talle)
        {
            this.tipo = tipo;
        }
    }

    public class Abrigo: RopaTalleAlphaSizing
    {
        private string tipo;

        public Abrigo(int numeroStock, string nombrePresentacion, string talle, string tipo):
        base(numeroStock,nombrePresentacion,talle)
        {
            this.tipo = tipo;
        }
    }
}
