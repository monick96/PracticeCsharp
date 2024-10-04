using System;

namespace Parcial1DOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jugador
            Jugador jugador1 = new Jugador("Juan", "salvatierra", 25,2,"Delantero");
            jugador1.mostrarInfo();

            //entrenador
            Entrenador entrenador1 = new Entrenador("Lionel", "Scaloni", 45,6);
            entrenador1.mostrarInfo();

            //Administrativo
            Administrativo administrativo1 = new Administrativo("Sara", "Perez", 28, "Psicologa","Auxiliar de RRHH");
            administrativo1.mostrarInfo();

            
        }
    }

    public class Integrante
    {
        protected string nombre;
        protected string apellido;
        protected int edad;

        public Integrante(string nombre, string apellido,int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

         public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public int GetEdad()
        {
            return this.edad;
        }

        public void mostrarInfo()
        {
            System.Console.WriteLine("Datos del Integrante:");
            System.Console.WriteLine($"Nombre: {getNombre()}");
            System.Console.WriteLine($"Apellido: {GetApellido()}");
            System.Console.WriteLine($"Edad: {GetEdad()}");
           
        }
    }

    public class Jugador:Integrante
    {
        private int posicion;
        private string categoria;

        public Jugador (string nombre, string apellido,int edad,
         int posicion, string categoria):base(nombre,apellido,edad)
        {
            this.posicion = posicion;
            this.categoria = categoria;
        }

         public void setPosicion(int posicion)
        {
            this.posicion = posicion;
        }

        public int getPosicion()
        {
            return this.posicion;
        }

         public void setCategoria(string categoria)
        {
            this.categoria = categoria;
        }

        public string getCategoria()
        {
            return this.categoria;
        }

        public void mostrarInfo()
        {
            base.mostrarInfo();
            System.Console.WriteLine($"Pocision: {this.posicion}");
            System.Console.WriteLine($"Categoria: {this.categoria}");
            System.Console.WriteLine("---------------------------");
        }
    }

      public class Entrenador:Integrante
    {
        private int aniosExperiencia;

        public Entrenador (string nombre, string apellido,int edad,
         int aniosExperiencia):base(nombre,apellido,edad)
        {
            this.aniosExperiencia = aniosExperiencia;
        
        }

         public void setAniosExperiencia(int aniosExperiencia)
        {
            this.aniosExperiencia = aniosExperiencia;
        }

        public int getAniosExperiencia()
        {
            return this.aniosExperiencia;
        }

        public void mostrarInfo()
        {
            base.mostrarInfo();
            System.Console.WriteLine($"Años de experiencia: {this.aniosExperiencia}");
            System.Console.WriteLine("---------------------------");
        }
    }

     public class Administrativo:Integrante
    {
        private string profesion;
        private string puesto;

        public Administrativo (string nombre, string apellido,int edad,
         string profesion, string puesto):base(nombre,apellido,edad)
        {
            this.profesion = profesion;
            this.puesto = puesto;
        
        }

         public void setProfesion(string profesion)
        {
            this.profesion = profesion;
        }

        public string getProfesion()
        {
            return this.profesion;
        }

        public void setPuesto(string puesto)
        {
            this.puesto = puesto;
        }

        public string getPuesto()
        {
            return this.puesto;
        }

        public void mostrarInfo()
        {
            base.mostrarInfo();
            System.Console.WriteLine($"Profesion: {this.profesion}");
            System.Console.WriteLine($"Puesto: {this.puesto}");
            System.Console.WriteLine("---------------------------");
        }
    }
    

}

