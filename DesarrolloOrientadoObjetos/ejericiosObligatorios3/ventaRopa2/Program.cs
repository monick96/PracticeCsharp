using System;
namespace VentaRopa
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //instancia ropa, caso donde viene ropa mezclada
            Ropa ropaMezclada = new Ropa(500,"Remeras y abrigos");

            //remera oversize caso en que se ingresan datos precio mayorista y unitario 
            //luego  de separar ropa mezclada
            //cambiar talles o tipos a uno que no este en el array de talles o tipos para verificar que funcionan validaciones
           Remera remeraOversize = new Remera("m","Oversize");
           //validamos que el talle  y el tipo remera ingresado sea valido para continuar
           if(remeraOversize.talleEsValido(remeraOversize.GetTalle()) && remeraOversize.tipoRemeraEsValido(remeraOversize.GetTipoRemera()))
           {
                remeraOversize.setNumeroStock(15);
                remeraOversize.setPrecioMayorista(3000);
                remeraOversize.CalcularPrecioUnitario();//10% por defecto
                remeraOversize.mostrarInfo();
           }else
           {
                System.Console.WriteLine("El talle o tipo de remera no es valido");
           }
           

            //abrigo buzo-> caso que se ingresa el precio mayorista del producto 
            //y se calcula el precio unitario con 10% sbre el precio mayorista
           Abrigo abrigoBuzo = new Abrigo(6000,"s","Buzo");
           //validamos talle y tipo
           if (abrigoBuzo.talleEsValido(abrigoBuzo.GetTalle()) && abrigoBuzo.tipoAbrigoEsValido(abrigoBuzo.GetTipoAbrigo()))
           {
                abrigoBuzo.mostrarInfo();
            
           }else
           {
                System.Console.WriteLine("El talle o tipo de Abrigo no es valido");
           }
           

           //pantalon Jean-> caso que se ingresaran todos los datos de un producto
           //y precio mayorista se ajusta a mas del 10%
           Pantalon pantalonJean = new Pantalon(400,"Pantalones Jean",12000,"Jean",40);
           //validamos talle y tipo
           if (pantalonJean.talleEsValido(pantalonJean.GetTalle()) && pantalonJean.tipoPantalonEsValido(pantalonJean.GetTipoPantalon()))
           {
                pantalonJean.CalcularPrecioUnitario(15);//10% por defecto
                pantalonJean.mostrarInfo();
            
           }else
           {
                System.Console.WriteLine("El talle o tipo de Abrigo no es valido");
           }
  
        }
    }

    public class Ropa
    {
        protected int numeroStock;
        protected string nombrePresentacion;
        protected float precioUnitario;
        protected float precioMayorista;

        public Ropa (int numeroStock, string nombrePresentacion,float  precioMayorista)
        {
            this.numeroStock = numeroStock;
            this.nombrePresentacion = nombrePresentacion;
            this.precioMayorista = precioMayorista;
            
        }

        public Ropa (int numeroStock, string nombrePresentacion)
        {
            this.numeroStock = numeroStock;
            this.nombrePresentacion = nombrePresentacion;
            
        }

         public Ropa (float precioMayorista)
        {
            this.precioMayorista = precioMayorista;
            this.CalcularPrecioUnitario(); //al ingresar precio mayorista ya se puede calcular el unitario
        }

        public Ropa(){}

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

        
        /// <summary>
        /// solo accesible desde la clase ropa. Para cambiar valor implemento calcularPrecioUnitario
        /// que recibe por parametro el porcentaje a aumentar sobre el precio mayorista
        /// y en ese metodo llama al metodo setPrecioUnitario
        /// </summary>
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

        public void mostrarInfo()
        {
            System.Console.WriteLine("----------------");

            System.Console.WriteLine("Info Ropa");

            System.Console.WriteLine($"Numero stock: {this.numeroStock}");
            System.Console.WriteLine($"Nombre Presentacion: {this.nombrePresentacion}");
            System.Console.WriteLine("----------------");

        }
        
    }

    public class Pantalon : Ropa 
    {
        private string tipo;//jean , joggin

        private string [] tiposPantalon = {"Jean","Joggin"};
        private int talle;//talles del 36 al 52
        public Pantalon(string tipo, int talle):base()
        {
            this.talle = talle;
            this.tipo = tipo;
        }

        public Pantalon(float precioMayorista, string tipo, int talle):base(precioMayorista)
        {
            this.talle = talle;
            this.tipo = tipo;
        }

        public Pantalon(int numeroStock, string nombrePresentacion,float precioMayorista, string tipo, int talle):base(numeroStock,nombrePresentacion,precioMayorista)
        {
            this.talle = talle;
            this.tipo = tipo;
        }

        public string GetTipoPantalon()
        {
            return this.tipo;
        }

        public int GetTalle()
        {
            return this.talle;
        }

        public bool talleEsValido(int talle)
        {
            bool talleValido = false;
            //verificamos si el talle es par y si esta entre los numeros 36 y 52 inclusive
            if ((talle %2 == 0 )&& (talle >=36 && talle <= 52))
            {
                talleValido = true;
                
            }

            return talleValido;
        }

        public bool tipoPantalonEsValido(string tipoPantalon)
        {
            bool tipoPantalonValido = false;
            for (int i = 0; i < this.tiposPantalon.Length; i++)
            {
                if (this.tiposPantalon[i].ToLower().Equals(tipoPantalon.ToLower()))
                {
                    tipoPantalonValido = true;
                    break;
                }
            }

            return tipoPantalonValido;
        }
        

        public void mostrarInfo()
        {
            System.Console.WriteLine("-----------------------------------");

            System.Console.WriteLine("Info Pantalon");

            //si numero stock >0 que lo imprima
            if (this.numeroStock>0){
                System.Console.WriteLine($"Numero stock: {this.numeroStock}");
            }
            //si nombrePresentacion es distinto de null o vacio que lo imprima
            if (!string.IsNullOrEmpty(this.nombrePresentacion)){
                System.Console.WriteLine($"Nombre presentacion : {this.nombrePresentacion}");
            }
            
            System.Console.WriteLine($"Tipo pantalon : {this.tipo}");
            System.Console.WriteLine($"Talle pantalon : {this.talle}");

            if(this.precioUnitario>0)
            {
                System.Console.WriteLine($"Precio Unitario: {this.precioUnitario}");
            }
 
            System.Console.WriteLine("-----------------------------------");
        }

        
    }

    //clase que no se instancia sirve para que abigo y remera compartan el atributo talle
    //Se denomina Alpha Sizing a los talles representados con letras (s, m,l, etc)
    public class RopaTalleAlphaSizing : Ropa
    {
        protected string talle; //S,M,L, etc

        protected string [] talles= {"S","M","L","XL"};

        public RopaTalleAlphaSizing(string talle):base()
        {
            this.talle = talle;
            
            
        }

        public RopaTalleAlphaSizing(float precioMayorista, string talle):base(precioMayorista)
        {
            this.talle = talle;
            
            
        }

        public RopaTalleAlphaSizing(int numeroStock, string nombrePresentacion,float precioMayorista,string talle):base(numeroStock, nombrePresentacion,precioMayorista)
        {
            this.talle = talle;
            
            
        }

        public string GetTalle()
        {
            return this.talle;
        }

        public bool talleEsValido(string talle)
        {
            bool talleValido = false;
            for (int i = 0; i < this.talles.Length; i++)
            {
                if (this.talles[i].Equals(talle.ToUpper()))
                {
                    talleValido = true;
                    break;
                }
            }

            return talleValido;
        }
    }

    public class Remera : RopaTalleAlphaSizing
    {
        private string tipo; // clasicas,oversize, top
        private string[] tiposRemera = {"Clasicas","Oversizes","Top"};

        public Remera(string talle, string tipo):base(talle)
        {
            this.tipo = tipo;
        }

        public Remera(float precioMayorista, string talle, string tipo):base(precioMayorista,talle)
        {
            this.tipo = tipo;
        }

        public Remera(int numeroStock, string nombrePresentacion,float precioMayorista,string talle, string tipo):
        base(numeroStock,nombrePresentacion,precioMayorista,talle)
        {
            this.tipo = tipo;
        }

        public string GetTipoRemera()
        {
            return this.tipo;
        }

        public bool tipoRemeraEsValido(string tipoRemera)
        {
            bool tipoRemeraValido = false;
            for (int i = 0; i < this.tiposRemera.Length; i++)
            {
                if (this.tiposRemera[i].ToLower().Equals(tipoRemera.ToLower()))
                {
                    tipoRemeraValido = true;
                    break;
                }
            }

            return tipoRemeraValido;
        }

        public void mostrarInfo()
        {
            System.Console.WriteLine("-----------------------------------");

            System.Console.WriteLine("Info Remera");

            //si numero stock >0 que lo imprima
            if (this.numeroStock>0){
                System.Console.WriteLine($"numeroStock stock : {this.numeroStock}");
            }
            //si nombrePresentacion es distinto de null o vacio que lo imprima
            if (!string.IsNullOrEmpty(this.nombrePresentacion)){
                System.Console.WriteLine($"Nombre presentacion : {this.nombrePresentacion}");
            }
            System.Console.WriteLine($"Tipo remera : {this.tipo}");
            System.Console.WriteLine($"Talle remera : {this.talle}");
            if(this.precioUnitario>0)
            {
                System.Console.WriteLine($"Precio Unitario: {this.precioUnitario}");
            }
            

            System.Console.WriteLine("-----------------------------------");
        }
    }

    public class Abrigo: RopaTalleAlphaSizing
    {
        private string tipo;// sweater,buzos, camperas

        private string[] tiposAbrigo = {"Sweater","Buzo","Campera"};

        public Abrigo(string talle, string tipo):base(talle)
        {
            this.tipo = tipo;
        }

         public Abrigo(float precioMayorista,string talle, string tipo):base(precioMayorista,talle)
        {
            this.tipo = tipo;
        }

         public Abrigo(int numeroStock, string nombrePresentacion,float precioMayorista,string talle, string tipo):
         base(numeroStock, nombrePresentacion,precioMayorista,talle)
        {
            this.tipo = tipo;
        }

        public string GetTipoAbrigo()
        {
            return this.tipo;
        }

        public bool tipoAbrigoEsValido(string tipoAbrigo)
        {
            bool tipoAbrigoValido = false;
            for (int i = 0; i < this.tiposAbrigo.Length; i++)
            {
                if (this.tiposAbrigo[i].ToLower().Equals(tipoAbrigo.ToLower()))
                {
                    tipoAbrigoValido = true;
                    break;
                }
            }

            return tipoAbrigoValido;
        }

        public void mostrarInfo()
        {
            //System.Console.WriteLine("-----------------------------------");

            System.Console.WriteLine("Info Abrigo");

            //si numero stock >0 que lo imprima
            if (this.numeroStock>0){
                System.Console.WriteLine($"numeroStock stock : {this.numeroStock}");
            }
            //si nombrePresentacion es distinto de null o vacio que lo imprima
            if (!string.IsNullOrEmpty(this.nombrePresentacion)){
                System.Console.WriteLine($"Nombre presentacion : {this.nombrePresentacion}");
            }
            System.Console.WriteLine($"Tipo abrigo : {this.tipo}");
            System.Console.WriteLine($"Talle abrigo : {this.talle}");

            if(this.precioUnitario>0)
            {
                System.Console.WriteLine($"Precio Unitario: {this.precioUnitario}");
            }

            System.Console.WriteLine("-----------------------------------");
        }
    }
}
