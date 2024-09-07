using System;

namespace Ejercicio1Persona 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clase Persona");

            Persona pedro = new Persona("456978","Pedro","Pedro",18,'M');

            pedro.saludar();

            pedro.obtenerNombreYApellido();

            pedro.modificarEdad(19);

        }
    }

    public class Persona
    {
        //Atributos
        public string dni;
        public string nombre;
        public string apellido;
        public int edad;
        public char sexo;

        //Metodos
        //constructor
        public Persona (string dniParam, string nombreParam, string apellidoParam, int edadParam, char sexoParam)
        {
            dni = dniParam;

            nombre = nombreParam;

            apellido = apellidoParam;

            edad = edadParam;

            sexo = sexoParam;

        }

        public void saludar () 
        {
            System.Console.WriteLine($"Hola, soy {nombre}");
        }

        public void obtenerNombreYApellido()
        {
            System.Console.WriteLine($"Nombre: {nombre}");

            System.Console.WriteLine($"Apellido: {apellido}");

        }

        public void modificarEdad(int edadParam)
        {
            System.Console.WriteLine($"Edad: {edad}");

            edad = edadParam;

            System.Console.WriteLine($"Edad modificada a: {edad}");

        }


    }
}