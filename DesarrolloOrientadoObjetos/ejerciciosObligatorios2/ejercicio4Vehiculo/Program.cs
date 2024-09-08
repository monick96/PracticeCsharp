using System;

namespace Ejercicio4Vehiculo 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Vehiculo
    {
        //Atributos
        public string motor;
        public int velocidadMaxima;
        public int capacidadPasajeros;
        public int velocidad;
        public string marca;
        public string origen;
        public string color;

        //metodos
        
        public Vehiculo(string motorParam, string marcaParam, string colorParam, string origenParam, int velocidadParam, int velocidadMaximaParam, int capacidadPasajerosParam)
        {
            motor = motorParam;
            marca = marcaParam;
            color = colorParam;
            origen = origenParam;
            velocidad = velocidadParam;
            velocidadMaxima = velocidadMaximaParam;
            capacidadPasajeros = capacidadPasajerosParam;

        }

        public Vehiculo()
        {
        }

        public void arrancar()
        {
            System.Console.WriteLine("Arrancando...");
        }

        public void acelerar()
        {
            System.Console.WriteLine("Acelerando...");
        }

        public void frenar()
        {
            System.Console.WriteLine("Frenando...");
        }

    }

    public class VehiculoTerrestre:Vehiculo
    {
        //Atributos
        public int cantidadRuedas;
       
        //metodos
        public VehiculoTerrestre( int cantidadRuedasParam)
        {
            cantidadRuedas = cantidadRuedasParam;
        }

        public VehiculoTerrestre()
        {

        }

       

    }

    public class Motocicleta:Vehiculo
    {
        
        //metodos
        public Motocicleta(){}

        public void ajustarManubrio()
        {
            System.Console.WriteLine("Ajustando Manubrio...");
        }

    }

    
}
