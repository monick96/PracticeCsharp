using System;

namespace Ejercicio6Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

      public class Animal
    {
        //Atributos
        public string sexo;
        public int tamanio;
        public int edad;
        public string tipoAlimentacion; //carnivoro, herviboro, etc
        public string tipoReproduccion; //mamifero,oviparo, etc
        public string color;

        //metodos
        
        public Animal(string sexoParam, int tamanioParam, string colorParam, int edadParam, string tipoAlimentacionParam, string tipoReproduccionParam)
        {
            sexo = sexoParam;
            tamanio = tamanioParam;
            color = colorParam;
            edad = edadParam;
            tipoAlimentacion = tipoAlimentacionParam;
            tipoReproduccion = tipoReproduccionParam;

        }

        public Animal()
        {
        }

        public void alimentarse()
        {
            System.Console.WriteLine("comiendo...");
        }

        public void reproducirse()
        {
            System.Console.WriteLine("reproduciendose...");
        }

        public void defenderse()
        {
            System.Console.WriteLine("defendiendome...");
        }

    }

    public class AnimalVertebrado:Animal
    {
        //Atributos
        public int cantidadExtremidades;
       
        //metodos
        public AnimalVertebrado( int cantidadExtremidadesParam)
        {
            cantidadExtremidades = cantidadExtremidadesParam;
        }

        public AnimalVertebrado()
        {

        }

       

    }

    public class Reptil:AnimalVertebrado
    {
        //atributos
        public string tipoDesplazamiento;//caminar, reptar
        public string formaEscama;

        //metodos
        public Reptil(string tipoDesplazamientoParam,string formaEscamaParam)
        {
            tipoDesplazamiento = tipoDesplazamientoParam;
            formaEscama = formaEscamaParam;
        }
        public Reptil(){}

        public void moverse()
        {
            System.Console.WriteLine("Moviendose...");
        }

        public void cambiarPiel()
        {
            System.Console.WriteLine("Cambiando Piel...");
        }

    }

    public class Vibora:Reptil
    {
        //atributo
        public string especie;

        //metodo
        public Vibora(string especieParam)
        {
            especie = especieParam;
        }

    }
}
