using System;

namespace Ejercicio7Equipo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos a la seleccion Argentina con la clase Equipo
            Equipo argentina = new Equipo("Argentina");

            //pedimos datos por consola
            //Jugador
            System.Console.WriteLine("Ingrese datos de un jugador de la seleccion: ");
            System.Console.WriteLine("Ingrese nombre del jugador:");
            string nombre = Console.ReadLine();
            System.Console.WriteLine("Ingrese apellido del jugador:");
            string apellido = Console.ReadLine();
            System.Console.WriteLine("Ingrese posicion del jugador:");
            string posicion = Console.ReadLine();

            //instanciamos al jugador ingresado por consola
            Jugador jugador = new Jugador(nombre,apellido,argentina,posicion);

            //DT
            System.Console.WriteLine("Ingrese datos del DT de la seleccion Argentina: ");
            System.Console.WriteLine("Ingrese nombre del DT:");
            string nombreDT = Console.ReadLine();
            System.Console.WriteLine("Ingrese apellido del DT:");
            string apellidoDT = Console.ReadLine();
            System.Console.WriteLine("Ingrese la antiguedad en años del DT:");
            int antiguedaDT = int.Parse(Console.ReadLine());

            //instanciamos al DT ingresado por consola
            DirectorTecnico DT = new DirectorTecnico(nombre,apellido,argentina,antiguedaDT);

            //Mostrar objetos creados
            //jugador
            System.Console.WriteLine("Datos del Jugador");
            jugador.mostrarDatos();

            //DT
            System.Console.WriteLine("Datos del Director Tecnico");
            DT.mostrarDatos();

            
        }
    }

    //clase Equipo
    public class Equipo
    {
        public string nombreEquipo;

        public Equipo(string nombreEquipoParam)
        {
            nombreEquipo = nombreEquipoParam;
        }

    }

    //Clase MiembroEquipo
    public class MiembroEquipo
    {
        public string nombre;
        public string apellido;
        public Equipo equipo;
        

        public MiembroEquipo(string nombreParam, string apellidoParam, Equipo equipoParam)
        {
            nombre = nombreParam;
            apellido = apellidoParam;
            equipo = equipoParam;
        }

        public void mostrarDatos()
        {
            System.Console.WriteLine($"Nombre: {nombre}");
            System.Console.WriteLine($"Apellido: {apellido}");
            System.Console.WriteLine($"Equipo: {equipo}");
        }  
    }

    public class Jugador:MiembroEquipo
    {
        public string posicion;

        public Jugador(string nombreParam, string apellidoParam, Equipo equipoParam, string posicionParam)
        : base(nombreParam, apellidoParam, equipoParam)
        {
            posicion = posicionParam;
        }

        public void correr()
        {
            System.Console.WriteLine($"{nombre}, esta corriendo..");
        }

        public void patearPelota()
        {
            System.Console.WriteLine($"{nombre}, esta pateando la pelota..");
        }

        public void mostrarDatos()
        {
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine($"Nombre: {nombre}");
            System.Console.WriteLine($"Apellido: {apellido}");
            System.Console.WriteLine($"Equipo: {equipo.nombreEquipo}");
            System.Console.WriteLine($"Posicion: {posicion}");
            System.Console.WriteLine("-----------------------");

        }
    }

     public class DirectorTecnico:MiembroEquipo
    {
        public int antiguedadAnios;

        public DirectorTecnico( string nombreParam, string apellidoParam, Equipo nombreEquipoParam, int antiguedadAniosParam)
        : base(nombreParam, apellidoParam, nombreEquipoParam)
        {
            antiguedadAnios = antiguedadAniosParam;
        }

        public void motivar()
        {
            System.Console.WriteLine($"El éxito no es la victoria, sino el esfuerzo que pusiste en ella");
        }

        public void armarEstrategia()
        {
            System.Console.WriteLine($"Estudiando al rival..");
        }

        public void mostrarDatos()
        {
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine($"Nombre: {nombre}");
            System.Console.WriteLine($"Apellido: {apellido}");
            System.Console.WriteLine($"Equipo: {equipo.nombreEquipo}");
            System.Console.WriteLine($"Antiguedad: {antiguedadAnios} años");
            System.Console.WriteLine("-----------------------");

        }
    }

     
}