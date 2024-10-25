using System;

namespace EquipoSoftware 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //en vez de declarar dos arrays(uno para Tester y Otro para Desarrollador) voy a usar el proceso de upcasting o generalizacion 
            //es una consecuencia de la herenci, que me perite convertir clases especializadas a su clase base
            //en este caso tester y desarrollador son hijas de integrante. asi que declaro una array de ese tipo
            //declaracion de array con longitud para cinco itegrantes
            Integrante[] integrantes = new Integrante[5];

            //instanciacion de Miembros del equipo de desarrollo
            //luego instancio a los miembros de forma especializada
            //datetime  ---> anio/mes/dia
            //desarrolladores
            Desarrollador juan = new Desarrollador("Juan","Perez",new DateTime(2022,09,02) ,new DateTime(1990,10,11), "Java");
            Desarrollador pepe = new Desarrollador("Pepe", "Rodriguez",new DateTime(2021,11,03),new DateTime(1992,12,01),"Csharp");
            Desarrollador rosita = new Desarrollador("Rosita","Lopez",new DateTime(2023,01,05), new DateTime(1993,10,11),"C");
            
            //testers
            //con declarcion simplificada
            Tester roberta = new("Roberta", "Araujo",new DateTime(2023,12,15), new DateTime(1994,02,25),TipoTesting.Manual);
            Tester andy = new("Andy", "Perez", new DateTime(2017,02,20),new DateTime(1995,10,12),TipoTesting.Automatico);

            //agregar miembros al array de integrantes para
            //aca cada objeto se convierte en su clase base(Integrante)
            // pero sigue manteniendo las propiedades de su clase especializada
            integrantes[0] = juan;
            integrantes[1] = pepe;
            integrantes[2] = rosita;
            integrantes[3] = roberta;
            integrantes[4] = andy;

            //Info de los integrantes
            //como estoy usando virtual en la clase base y override 
            //en cada clase derivada para el metodo MostrarInfo()
            // el compilador sabe gracias al polimorfismo 
            //cual metodo de MostrarInfo() le corresponde a cada clase
            foreach (Integrante integrante in integrantes)
            {
                integrante.MostrarInfo();
                
            }
            
        }
    }


}