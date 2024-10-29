using System;
using System.Runtime.InteropServices;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador messi = new Jugador("Lionel", "Messi" , 30, 10, "delantero");
            Administrativo isabel = new Administrativo("Isabel","Rojas",39,"Archivista", "Licenciada en Recursos Humanos");
            Entrenador scaloni = new Entrenador("Lionel", "Scaloni", 40, 15);
            messi.MostrarInfo();
            isabel.MostrarInfo();
            scaloni.MostrarInfo();

            int option = 0;
            // Inicializamos un array vacío
            Integrante[] integrantes = new Integrante[0];
           
            CargarIntegrantes(option, ref integrantes);

            foreach (Integrante integrante in integrantes)
            {
                integrante.MostrarInfo();
            }
        }


        
        public static void CargarIntegrantes(int option, ref Integrante[] integrantes)
        {
            while (option != 4)
            {
                System.Console.WriteLine("Menu creacion Integrantes");
                System.Console.WriteLine("1 - Crear Jugador");
                System.Console.WriteLine("2 - Crear Entrenador");
                System.Console.WriteLine("3 - Crear Administrativo");
                System.Console.WriteLine("4 - Salir");
                
                //contador para hacer el rezise
                int count = 0;
                option = int.Parse(Console.ReadLine());

                switch (option) 
                {
                    case 1:
                        System.Console.WriteLine("Ingrese nombre:");
                        string nombreJugador = Console.ReadLine();
                        System.Console.WriteLine("Ingrese apellido:");
                        string apellidoJugador = Console.ReadLine();
                        System.Console.WriteLine("Ingrese edad:");
                        int edadJugador = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Ingrese posición:");
                        int posicion = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Ingrese categoría:");
                        string categoria = Console.ReadLine();

                        Jugador nuevoJugador = new Jugador(nombreJugador, apellidoJugador, edadJugador, posicion, categoria);
                        Array.Resize(ref integrantes, count + 1);
                        integrantes[count] = nuevoJugador;
                        count++;
                        break;

                    case 2:
                        System.Console.WriteLine("Ingrese nombre:");
                        string nombreEntrenador = Console.ReadLine();
                        System.Console.WriteLine("Ingrese apellido:");
                        string apellidoEntrenador = Console.ReadLine();
                        System.Console.WriteLine("Ingrese edad:");
                        int edadEntrenador = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Ingrese años de experiencia:");
                        int aniosExperiencia = int.Parse(Console.ReadLine());

                        Entrenador nuevoEntrenador = new Entrenador(nombreEntrenador, apellidoEntrenador, edadEntrenador, aniosExperiencia);
                        Array.Resize(ref integrantes, count + 1);
                        integrantes[count] = nuevoEntrenador;
                        count++;
                        break;

                    case 3:
                        System.Console.WriteLine("Ingrese nombre:");
                        string nombreAdministrativo = Console.ReadLine();
                        System.Console.WriteLine("Ingrese apellido:");
                        string apellidoAdministrativo = Console.ReadLine();
                        System.Console.WriteLine("Ingrese edad:");
                        int edadAdministrativo = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Ingrese profesión:");
                        string profesion = Console.ReadLine();
                        System.Console.WriteLine("Ingrese puesto:");
                        string puesto = Console.ReadLine();

                        Administrativo nuevoAdministrativo = new Administrativo(nombreAdministrativo, apellidoAdministrativo, edadAdministrativo, profesion, puesto);
                        Array.Resize(ref integrantes, count + 1);
                        integrantes[count] = nuevoAdministrativo;
                        count++;
                        break;

                    case 4:
                        System.Console.WriteLine("Saliendo...");
                        break;

                    default:
                        System.Console.WriteLine("Opción inválida, intente nuevamente.");
                        break;
                
                }
            }  
        }
    }

}