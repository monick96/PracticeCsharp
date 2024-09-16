using System;
namespace VentaRopa
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //remera oversize
           Remera remeraOversize = new Remera(500, "Remeras","s","Oversize");
           remeraOversize.setPrecioMayorista(3000);
           remeraOversize.CalcularPrecioUnitario();//10% por defecto
           remeraOversize.mostrarInfo();

            //abrigo buzo
           Abrigo abrigoBuzo = new Abrigo(600, "Abrigos","s","Buzo");
           abrigoBuzo.setPrecioMayorista(6000);
           abrigoBuzo.CalcularPrecioUnitario();//10% por defecto
           abrigoBuzo.mostrarInfo();

           //pantalon Jean
           Pantalon pantalonJean = new Pantalon(400, "Pantalon","Jean",40);
           pantalonJean.setPrecioMayorista(10000);
           pantalonJean.CalcularPrecioUnitario();//10% por defecto
           pantalonJean.mostrarInfo();
           
           
           
           
           

        }
    }

    public class Ropa
    {
        protected int numeroStock;
        protected string nombrePresentacion;
        protected float precioUnitario;
        protected float precioMayorista;

        public Ropa (int numeroStock, string nombrePresentacion)
        {
            this.numeroStock = numeroStock;
            this.nombrePresentacion = nombrePresentacion;
        }

        public int getNumeroStock()
        {
            return this.numeroStock;
        }

        public void setNumeroStock(int nuevoStock)
        {
            this.numeroStock = nuevoStock;
        }

        public float getPrecioUnitario()
        {
            return this.precioUnitario;
        }

        private void setPrecioUnitario(float nuevoPrecioUnitario)
        {
            this.precioUnitario = nuevoPrecioUnitario;
        }

        public float getPrecioMayorista()
        {
            return this.precioMayorista;
        }

        public void setPrecioMayorista(float nuevoPrecioMayorista)
        {
            this.precioMayorista = nuevoPrecioMayorista;
        }

        public string getNombrePresentacion()
        {
            return this.nombrePresentacion;
        }

        public void setNombrePresentacion(string nuevoNombre)
        {
            this.nombrePresentacion = nuevoNombre;
        }

        public void CalcularPrecioUnitario( int indiceUnitario = 10)
        {
            float precioUnitario = this.precioMayorista + ((this.precioMayorista * 10)/100);
            setPrecioUnitario(precioUnitario);
        }
        
    }

    public class Pantalon : Ropa 
    {
        private string tipo;//jean , joggin
        private int talle;//talles del 35 al 52
        public Pantalon(int numeroStock,string nombrePresentacion,string tipo, int talle):base(numeroStock,nombrePresentacion)
        {
            this.talle = talle;
            this.tipo = tipo;
        }

        public void mostrarInfo()
        {
            System.Console.WriteLine("-----------------------------------");

            System.Console.WriteLine($"numeroStock stock : {this.numeroStock}");
            System.Console.WriteLine($"Nombre presentacion : {this.nombrePresentacion}");
            System.Console.WriteLine($"Tipo pantalon : {this.tipo}");
            System.Console.WriteLine($"Talle pantalon : {this.talle}");
            System.Console.WriteLine($"Precio Unitario: {this.precioUnitario}");

            System.Console.WriteLine("-----------------------------------");
        }
    }

    public class RopaTalleAlphaSizing : Ropa
    {
        protected string talle; //S,M,L, etc

        public RopaTalleAlphaSizing(int numeroStock,string nombrePresentacion,string talle):base(numeroStock,nombrePresentacion)
        {
            this.talle = talle;
            
        }
    }

    public class Remera : RopaTalleAlphaSizing
    {
        private string tipo; // clasicas,oversize, top

        public Remera(int numeroStock, string nombrePresentacion, string talle, string tipo):
        base(numeroStock,nombrePresentacion,talle)
        {
            this.tipo = tipo;
        }

        public void mostrarInfo()
        {
            System.Console.WriteLine("-----------------------------------");

            System.Console.WriteLine($"numeroStock stock : {this.numeroStock}");
            System.Console.WriteLine($"Nombre presentacion : {this.nombrePresentacion}");
            System.Console.WriteLine($"Tipo remera : {this.tipo}");
            System.Console.WriteLine($"Talle remera : {this.talle}");
            System.Console.WriteLine($"Precio Unitario: {this.precioUnitario}");

            System.Console.WriteLine("-----------------------------------");
        }
    }

    public class Abrigo: RopaTalleAlphaSizing
    {
        private string tipo;// sweater,buzos, camperas

        public Abrigo(int numeroStock, string nombrePresentacion, string talle, string tipo):
        base(numeroStock,nombrePresentacion,talle)
        {
            this.tipo = tipo;
        }

        public void mostrarInfo()
        {
            System.Console.WriteLine("-----------------------------------");

            System.Console.WriteLine($"numeroStock stock : {this.numeroStock}");
            System.Console.WriteLine($"Nombre presentacion : {this.nombrePresentacion}");
            System.Console.WriteLine($"Tipo abrigo : {this.tipo}");
            System.Console.WriteLine($"Talle abrigo : {this.talle}");
            System.Console.WriteLine($"Precio Unitario: {this.precioUnitario}");

            System.Console.WriteLine("-----------------------------------");
        }
    }
}
