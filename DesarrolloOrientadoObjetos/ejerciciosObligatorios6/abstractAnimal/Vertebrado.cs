using System.Runtime.InteropServices.Marshalling;

namespace Ejercicio1
{
    abstract class Vertebrado : Animal
    {
        protected bool columnaVertebral;
        protected string tipoSangre;//fria o caliente
        public Vertebrado (float peso, int edad, bool columnaVertebral, string tipoSangre):base(peso,edad)
        {
            this.columnaVertebral = columnaVertebral;
            this.tipoSangre = tipoSangre;
        }
        public abstract void Moverse();
        public override void MostrarInfo()
        {
            System.Console.WriteLine("----------");
            System.Console.WriteLine($"Peso: {this.peso}");
            System.Console.WriteLine($"Edad: {this.edad}");
            System.Console.WriteLine($"Columna vertebral: {this.columnaVertebral}");
            System.Console.WriteLine($"Tipo de sangre: {this.tipoSangre}");
        }
       
        
    }
}