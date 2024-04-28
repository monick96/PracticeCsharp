using System;
namespace Maraton
{
    class Program
    {
        static void Main (string [] args)
        {
            //Una maratón tiene 26 millas y 385 yardas. Sabiendo que una milla tiene 1760 yardas, calcular la
            //distancia de la maratón en kilómetros. 
            //1milla--1760 yardas
            //26illas------- x yardas
            //1 yarda --- 0.0009144 km
            //xyardas -----xkm


            float millas = 26.0f;
            float millasYardas;
            float yardaskm;
            
            //paso millas a yardas le sumo los 385 yardas
            millasYardas = (millas * 1760) + 385;

            //paso yardas a km
            yardaskm = millasYardas * 0.0009144f;

            Console.WriteLine("26 millas y 385 yardas son " + yardaskm + " km");            

        }
    }
}
