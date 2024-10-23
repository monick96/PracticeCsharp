using System;

namespace Ejercicio1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instancia serpiente
            Serpiente cascabel = new Serpiente(200,5,true,"fria","forma de diamante",true);

            //instancia Perro
            Perro ayudanteSanta = new Perro(1000,15,true,"caliente","simple liso","Ayudante de santa");
            Animal [] arrayAnimales  = {cascabel,ayudanteSanta};

            foreach (Animal animal in arrayAnimales)
            {
                animal.MostrarInfo();
            }
            //metodos particulares serpiente
            cascabel.Moverse();
            cascabel.RegularTemperatura();

            //metodos particulares perro
            ayudanteSanta.Moverse();
            ayudanteSanta.HacerSonido();
        }
    }
}
