using System;

namespace CalculadoraInterfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCientifica calc1 = new CalculadoraCientifica();
            CalculadoraFinanciera calc2 = new CalculadoraFinanciera();

            List<Calculadora> calculadoras = [calc1, calc2];

            foreach (Calculadora calculadora in calculadoras)
            {
                calculadora.MostrarInfo();
            }
            
            //metods calculadora cientifica
            calc1.CalcularPotencia(5,2);
            calc1.Sumar(5,3);
            
            //metodos calculadora Financiera
            calc2.CalcularInteresCompuesto(46000,9);
            calc2.Dividir(5,0);

        }
    }
    
    //clase abstracta padre
    abstract class Calculadora : IcalculosBasicos
    {
        public Calculadora(){}
        //implemento los metodos de la interfaz utilizada comunes a heredar a las clases hijas
        public float Sumar(float a, float b)
        {
            float suma = a + b;
            System.Console.WriteLine($"La suma da {suma}");
            return suma;
            
        }

        public float Restar(float a, float b)
        {
            float resta = a - b;
            System.Console.WriteLine($"La resta da {resta}");
            return resta;
            
        }

        public float Multiplicar(float a, float b)
        {
            float multiplicacion = a * b;
            System.Console.WriteLine($"La multiplicacion da {multiplicacion}");
            return multiplicacion;
            
        }

        public float Dividir(float a, float b)
        {
            if (b != 0)
            {
                float division = a / b;
                System.Console.WriteLine($"La division da {division}");
                return division;
            }else
            {
                throw new DivideByZeroException("No se puede dividir por cero");
            }
             
        }

        public abstract void MostrarInfo();
    }
    //clases hijas
    class CalculadoraCientifica : Calculadora, iCalculosCientificos
    {
        public CalculadoraCientifica():base(){}
        
        //metodo que calcula potencia implementada desde la interfaz IcalculosCientificos
        public double CalcularPotencia(double num, double potencia)
        {
            System.Console.WriteLine($"La potencia  es {Math.Pow(num, potencia)}");
            return Math.Pow(num, potencia);
        }

        public override void MostrarInfo()
        {
            System.Console.WriteLine("Soy una calculadora CIentifica y calculo la potencia");
        }
    }

    class CalculadoraFinanciera : Calculadora, iCalculosFinancieros
    {
        public CalculadoraFinanciera():base(){}
        
        //metodo que calcula interes compuesto
        public double CalcularInteresCompuesto(double capital, double interesPorcentaje)
        {
            System.Console.WriteLine($"El interes compuesto es de  $ {capital * Math.Pow((1 + interesPorcentaje/100), 1)}");
            return capital * Math.Pow((1 + interesPorcentaje/100), 1);
        }

          public override void MostrarInfo()
        {
            System.Console.WriteLine("Soy una calculadora Financiera y calculoel interes compuesto");
        }
    }

    // ambas calculadoras pueden hacer operaciones basicas traidas de la interfaz calculos basicos,
    // y cada una ademas implementan metodos de una interfaz creada 
    //segun el tipo de calculos a realizar para cada tipo de calculadora

    //Interfaces
    interface IcalculosBasicos
    {
        float Sumar(float a, float b);
        float Restar(float a, float b);
        float Dividir(float a, float b);
        float Multiplicar(float a, float b);
    }

    interface iCalculosCientificos
    {
        double CalcularPotencia(double a, double b);
    }
    interface iCalculosFinancieros
    {
        double CalcularInteresCompuesto(double capital, double porcentajeInteres);
    }
}