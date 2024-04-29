using System;
namespace Bateria
{
    class Program
    {
        static void Main(string [] args)
        {
            //La batería de una tablet dura 5 horas reproduciendo video y 8 horas reproduciendo sólo audio. Se
            // desea realizar un programa que calcule cuántas películas de N minutos podría ver con una sola carga
            // y, por otro lado, cuántas veces debería cargar la batería para poder escuchar N canciones de 3
            // minutos.

            //300min
            float minutosTabletVideo = 5.0f * 60.0f; 

            //480min
            float cancionesPorCarga = (8.0f * 60.0f) / 3.0f; 

            float cantPeliculas;
            float cantCargas; 
            float minPeliculas;
            int cantCanciones;

            Console.WriteLine("Ingrese los minutos de peliculas a visualizar: ");
            minPeliculas = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de canciones de 3min que va a escuchar: ");
            cantCanciones = int.Parse(Console.ReadLine());

            cantPeliculas = minutosTabletVideo / minPeliculas;
            Console.WriteLine("Puede mirar " + cantPeliculas + " peliculas");

            cantCargas = (float)(cantCanciones / cancionesPorCarga);
            Console.WriteLine("Nesesita " + cantCargas + " cargas para escuchar " + cantCanciones + " canciones");



        }
    }
}
