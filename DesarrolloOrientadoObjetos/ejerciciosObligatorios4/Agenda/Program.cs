using System;
using System.Runtime;

namespace EjerciciosObligatorios 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Resulta que lei que en chsarp se usa la convencion PascalCase, 
            //yo venia acostumbrada de Java al camelCase, 
            //asi que desde ahora en mas usare el PascalCase

            //declaracion de array con longitud para cinco personas
            Persona[] agenda = new Persona[5];

            //instanciacion de personas
            //datetime  ---> anio/mes/dia
            Persona juan = new Persona("Juan","Perez","1523697878", new DateTime(1990,10,11));
            Persona pepe = new Persona("Pepe", "Rodriguez","1123639878",new DateTime(1992,12,01));
            Persona rosita = new Persona("Rosita","Lopez","1136454458", new DateTime(1993,10,11));
            Persona roberta = new Persona("Roberta", "Araujo","1125897899", new DateTime(1994,02,25));
            Persona andy = new Persona("Andy", "Perez", "1122331122",new DateTime(1995,10,12));

            //agregar personas a agenda
            agenda[0] = juan;
            agenda[1] = pepe;
            agenda[2] = rosita;
            agenda[3] = roberta;
            agenda[4] = andy;

            //quien cumple anios hoy
            foreach (Persona persona in agenda)
            {
                if (persona.EsSuCumpleHoy())
                {
                    persona.NotificarCumpleanio();
                }
                
            }

            
        }
    }

    public class Persona
    {
        private string nombre;
        private string apellido;
        private string telefono;
        private DateTime fechaNacimiento;//ej new DateTime(1990, 5, 15);

        public Persona(string nombre, string apellido, 
        string telefono, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
        }

        public DateTime GetFechaNacimiento()
        {
            return this.fechaNacimiento;
        }

        public void NotificarCumpleanio()
        {
            System.Console.WriteLine($"felicitar a {this.nombre} {this.apellido} por su cumpleaños al celular {this.telefono}");
        }

        public bool EsSuCumpleHoy()
        {
            bool esCumpple = false;
            DateTime fechaDeHoy = DateTime.Now;
            DateTime fechaNacimiento = this.GetFechaNacimiento();
            if (fechaNacimiento.Day == fechaDeHoy.Day && fechaNacimiento.Month == fechaDeHoy.Month)
            {
                esCumpple = true;
            }

            return esCumpple;
        }
    }
}
