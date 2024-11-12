using System;

namespace Parcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //La encuenta
            //    - .Net
           //PARTE TEÓRICA (3 puntos):
           /* 1) Detalle un ejemplo donde sea conveniente usar clases abstractas por
            sobre clases comunes.
                Un ejemplo podria ser si estamos programando cafeteras que van a tener atributos 
                comunes como capacidad, modelo, material, pero vamos a tener tipos de cafetera manual y electrica.
                pero cafetera manual no hace el cafe, ni sirve el cafe como cafetera electrica, entonces alli necesitamos
                una clase abstracta que econtenga estos atributos comunes para las cafeteras y declare como abstracos los metodos
                servirCafe() y prepararCafe() para que cada clase hija los implemente segun como realicen esas funcionalidades
            2) ¿De que manera considera más conveniente recorrer un arreglo si no se
            conoce su longitud?
                Un bucle for each, ejemplo tengo un array de cafeteras seria (For each(Cafetera cafetera in cafeteras))
            3) ¿Cuándo crees que deberíamos implementar una interfaz y no una clase
            Abstracta?
                Podrian ser cuando:
                - queremos que varias clases implementen metodos de distintas fuentes sin estar relacionados, 
                - Necesitamos que una clase implemente si o si un conjunto de metodos
                - Necesitamos que distintas clases usen los mismos metodos pero implementados de manera diferente(polimorfismo por interfaz)
            */

            Comercial comercio1 = new Comercial(2,"Palermo",60000, "Alquiler", true, false);
            Vivienda vivienda1 = new Vivienda(6,"Lanus", 5000000,"Venta", true, false);

            List<Propiedad> propiedades = [comercio1, vivienda1];

            foreach (Propiedad propiedad in propiedades)
            {
                propiedad.MostrarInfo();
                propiedad.PublicarPropiedad();
                propiedad.ResponderConsulta();
            }

            //metodos de propiedades interfaz
            comercio1.calcularComision();
            comercio1.RenovarContrato();

            vivienda1.PoseAireLibre();
            vivienda1.TipoGarantia();

        }
    }

    //Interfaces
    interface IPropiedad
    {
        void ResponderConsulta();
        void PublicarPropiedad();
    }

      interface IVivienda
    {
        void TipoGarantia();
        void PoseAireLibre();
    }

      interface IComercial
    {
        void calcularComision();
        void RenovarContrato();
    }
    
    //clases
    abstract class Propiedad : IPropiedad
    {
        protected int ambientes;
        protected string ubicacion;
        protected float precio;
        protected string operacion;//alquiler,compra,temporal

        public Propiedad(int ambientes, string ubicacion, float precio, string operacion)
        {
            this.ambientes = ambientes;
            this.ubicacion = ubicacion;
            this.precio = precio;
            this.operacion = operacion;
        }

        public void ResponderConsulta()
        {
            System.Console.WriteLine("Respondiendo consulta...");
        }

        public void PublicarPropiedad()
        {
            System.Console.WriteLine("Publicando propiedad");
        }

        public abstract void MostrarInfo();

    }

    class Comercial : Propiedad, IComercial
    {
        private bool seguridad24Hs;
        private bool estacionamiento;

        public Comercial(
            int ambientes, string ubicacion, float precio, string operacion,
            bool seguridad24Hs, bool estacionamiento
        ): base(ambientes, ubicacion, precio, operacion)
        {
            this.seguridad24Hs = seguridad24Hs;
            this.estacionamiento = estacionamiento;
           
        }

        public void calcularComision()
        {
            System.Console.WriteLine("Calculando Comision...");
        }

        public void RenovarContrato()
        {
            System.Console.WriteLine("Contrato Renovado...");
        }

        public override void MostrarInfo()
        {
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("Datos Propiedad");
            System.Console.WriteLine($"Ambientes: {this.ambientes}");
            System.Console.WriteLine($"Ubicacion: {this.ubicacion}");
            System.Console.WriteLine($"Precio ${this.precio}");
            System.Console.WriteLine($"Operacion {this.operacion}");
            System.Console.WriteLine($"Seguridad 24 hs : {(this.seguridad24Hs ? "si" : "no")}");
            System.Console.WriteLine($"Estacionamiento: {(this.estacionamiento ? "si" : "no")}");
        }
    }

    class Vivienda : Propiedad, IVivienda
    {
        private bool mascota;
        private bool patio;

        public Vivienda(
            int ambientes, string ubicacion, float precio, string operacion,
            bool mascota, bool patio
        ): base(ambientes, ubicacion, precio, operacion)
        {
            this.mascota = mascota;
            this.patio = patio;
           
        }

        public void PoseAireLibre()
        {
            System.Console.WriteLine($"La propiedad {(this.patio ? "si": "no")} posee aire libre");
        }

        public void TipoGarantia()
        {
            System.Console.WriteLine("Garantia X");
        }

        public override void MostrarInfo()
        {
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("Datos Propiedad");
            System.Console.WriteLine($"Ambientes: {this.ambientes}");
            System.Console.WriteLine($"Ubicacion: {this.ubicacion}");
            System.Console.WriteLine($"Precio ${this.precio}");
            System.Console.WriteLine($"Operacion {this.operacion}");
            System.Console.WriteLine($"Permite Mascota: {(this.mascota ? "si" : "no")}");
            System.Console.WriteLine($"Tiene Patio: {(this.patio ? "si" : "no")}");

        }
    }
}