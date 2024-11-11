using System;

namespace Cafetera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancia de una Cafetera Manual 
            CafeteraManual miCafeteraManual = new CafeteraManual(1.5f, "Modelo Manual 123", "Acero Inoxidable"); 
            // Crear instancia de una Cafetera Eléctrica 
            CafeteraElectrica miCafeteraElectrica = new CafeteraElectrica(2.0f, "Modelo Eléctrico 456", "Plástico");
            Cafetera [] cafeteras = {miCafeteraElectrica, miCafeteraManual};

            foreach (Cafetera cafetera in cafeteras)
            {
                cafetera.PrepararCafe();
                cafetera.ServirCafe();
            }
        }
    }

    abstract class Cafetera
    {
        protected float capacidad;
        protected string modelo;
        protected string material;

        public Cafetera(float capacidad, string modelo, string material)
        {
            this.capacidad = capacidad;
            this.material = material;
            this.modelo = modelo;
        }

        public abstract void ServirCafe();
        public abstract void PrepararCafe();
        
    }

    class CafeteraManual : Cafetera
    {
        public CafeteraManual(float capacidad, 
        string modelo, string material):base(capacidad, modelo, material){}

        public override void PrepararCafe()
        {
            System.Console.WriteLine($"Cafetera Manual {this.modelo} preparando cafe...");
        }

        public override void ServirCafe()
        {
            System.Console.WriteLine($"Cafetera Manual {this.modelo} sirviendo cafe...");
        }
    }

    class CafeteraElectrica : Cafetera
    {
        public CafeteraElectrica(float capacidad, string modelo, string material):base(capacidad, modelo, material){}

        public override void PrepararCafe()
        {
            System.Console.WriteLine($"Cafetera Electrica {this.modelo} preparando cafe...");
        }

        public override void ServirCafe()
        {
            System.Console.WriteLine($"Cafetera Electrica {this.modelo} sirviendo cafe...");
        }
    }
}