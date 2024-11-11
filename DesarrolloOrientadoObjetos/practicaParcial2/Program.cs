using System;

namespace PracticaParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acuario acuario = new Acuario("Noaj Aquarium");

            //instancio peces
            // Crear instancias de PezAguaDulce (PezBetta y PezGato) 
            PezBetta betta = new PezBetta("Nemo", "Betta Splendens", 7.5f, 26.0f, 6.5f);

            PezGato gato = new PezGato("Whiskers", "Corydoras", 10.0f, 24.0f, 7.0f); 

            // Crear instancias de PezAguaSalada (Tiburon y PezAnemona) 
            Tiburon tiburon = new Tiburon("Sharky", "Carcharodon carcharias", 500.0f, true, false); 

            PezAnemona anemona = new PezAnemona("Anemone", "Amphiprioninae", 15.0f, true, true);

            //agregar a lista de acuario
            // Llamar al método para agregar peces a la lista
            acuario.AgregarPeces(new Pez[] {betta, gato, tiburon, anemona});

            acuario.MostrarYalimentarPeces();

        }
    }

    class Acuario
    {
        private string nombre;
        private List<Pez> peces;

        public Acuario(string nombre)
        {
            this.nombre = nombre;
            // Inicializar la lista de peces
            this.peces = new List<Pez>(); 
        }

        public void MostrarYalimentarPeces()
        {
            System.Console.WriteLine(this.nombre);
            foreach (Pez pez in peces)
            {
                pez.MostrarInfo();
                pez.Alimentar();
            }
        }

        public void AgregarPeces(Pez[] arrayPeces)
        {
            this.peces.AddRange(arrayPeces);
        }

    }

    abstract class Pez
    {
        protected string nombre;
        protected string especie;
        protected float tamanioCM;

        public Pez (string nombre, string especie, float tamanioCM)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.tamanioCM = tamanioCM;
        }

        public void Alimentar()
        {
            System.Console.WriteLine($"{this.nombre} se esta alimentando...");
        }

        public abstract void MostrarInfo();

    }

    abstract class PezAguaDulce:Pez
    {
        protected float temperaturaC;
        protected float ph;
        public PezAguaDulce(
            string nombre, string especie, float tamanioCM,
            float temperaturaC, float ph
        ):base(
            nombre, especie, tamanioCM
        )
        {
            this.temperaturaC = temperaturaC;
            this.ph = ph;
        }

        public override void MostrarInfo()
        {
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine($"Nombre: {this.nombre}");
            System.Console.WriteLine($"Especie: {this.especie}");
            System.Console.WriteLine($"Tamanio en cm: {this.tamanioCM}");
            System.Console.WriteLine($"Temperatura: {this.temperaturaC} °C");
            System.Console.WriteLine($"Ph: {this.ph}");
        }
        
    } 

    abstract class PezAguaSalada:Pez
    {
        protected bool corales;
        protected bool algasMarinas;
        public PezAguaSalada(
            string nombre, string especie, float tamanioCM,
            bool corales, bool algasMarinas
        ):base(
            nombre, especie, tamanioCM
        )
        {
            this.corales = corales;
            this.algasMarinas = algasMarinas;
        }

        public override void MostrarInfo()
        {
            System.Console.WriteLine("--------------------------------------------------");
            System.Console.WriteLine($"Nombre: {this.nombre}");
            System.Console.WriteLine($"Especie: {this.especie}");
            System.Console.WriteLine($"Tamanio en cm: {this.tamanioCM}");
            System.Console.WriteLine($"Requiere Corales: {(this.corales ? "Si":"No")}");
            System.Console.WriteLine($"Requiere Algas marinas: {(this.algasMarinas ? "Si" : "No")}");
        }
        
    } 

    interface IPezEstatico
    {
        void Camuflarse();
        void AdherirseAsuperficie();
    }

    interface IPezNadador    
    {
        void VelocidadNado();
        void Nadar();
    }

    class Tiburon : PezAguaSalada, IPezNadador
    {
        public Tiburon(
            string nombre, string especie, float tamanioCM,
            bool corales, bool algasMarinas
        ):base(nombre, especie, tamanioCM, corales, algasMarinas)
        {

        }

        public void VelocidadNado()
        {
            System.Console.WriteLine($"{this.nombre} esta nadando muy rapido..");
        }

        public void Nadar()
        {
            System.Console.WriteLine($"{this.nombre} esta nadando");
        }
    }

     class PezBetta : PezAguaDulce, IPezNadador
    {
        public PezBetta(
            string nombre, string especie, float tamanioCM,
            float temperaturaC, float ph
        ):base(nombre, especie, tamanioCM, temperaturaC, ph)
        {

        }

        public void VelocidadNado()
        {
            System.Console.WriteLine($"{this.nombre} esta nadando muy rapido..");
        }

        public void Nadar()
        {
            System.Console.WriteLine($"{this.nombre} esta nadando");
        }
    }

     class PezGato : PezAguaDulce, IPezEstatico
    {
        public PezGato(
            string nombre, string especie, float tamanioCM,
            float temperaturaC, float ph
        ):base(nombre, especie, tamanioCM, temperaturaC, ph)
        {

        }

        public void Camuflarse()
        {
            System.Console.WriteLine($"{this.nombre} esta camuflado..");
        }

        public void AdherirseAsuperficie()
        {
            System.Console.WriteLine($"{this.nombre} esta adherido a una superficie");
        }
    }

    class PezAnemona : PezAguaSalada, IPezEstatico
    {
        public PezAnemona(
            string nombre, string especie, float tamanioCM,
            bool corales, bool algasMarinas
        ):base(nombre, especie, tamanioCM, corales, algasMarinas)
        {

        }
        public void Camuflarse()
        {
            System.Console.WriteLine($"{this.nombre} esta camuflado..");
        }

        public void AdherirseAsuperficie()
        {
            System.Console.WriteLine($"{this.nombre} esta adherido a una superficie");
        }
    }

}