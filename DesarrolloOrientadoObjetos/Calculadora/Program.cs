using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCientifica calc1 = new CalculadoraCientifica();
            CalculadoraFinanciera calc2 = new CalculadoraFinanciera();
            Calculadora [] calculadoras = {calc1, calc2};
            
            //cientifica
            calc1.Calcular(4,5);

            //financiera.
            calc2.Calcular(60000,8);
        }
    }

    abstract class Calculadora
    {
        public Calculadora(){}
        //defino los metodos comunes a heredar
        public int Sumar(int a, int b)
        {
            int suma = a + b;
            System.Console.WriteLine($"La suma da {suma}");
            return suma;
            
        }

        public int Restar(int a, int b)
        {
            int resta = a - b;
            System.Console.WriteLine($"La resta da {resta}");
            return resta;
            
        }

        public int Multiplicar(int a, int b)
        {
            int multiplicacion = a * b;
            System.Console.WriteLine($"La multiplicacion da {multiplicacion}");
            return multiplicacion;
            
        }

        public int Dividir(int a, int b)
        {
            if (b != 0)
            {
                int division = a / b;
                System.Console.WriteLine($"La division da {division}");
                return division;
            }else
            {
                throw new DivideByZeroException("No se puede dividir por cero");
            }
             
        }
        
        // metodo abstracto que cada tipo de calculadora definira
        public abstract double Calcular(double a , double b);
    }

    class CalculadoraCientifica : Calculadora
    {
        public CalculadoraCientifica():base(){}
        
        //metodo que calcula potencia
        public override double Calcular(double num, double potencia)
        {
            System.Console.WriteLine($"La potencia  es {Math.Pow(num, potencia)}");
            return Math.Pow(num, potencia);
        }
    }

    class CalculadoraFinanciera : Calculadora
    {
        public CalculadoraFinanciera():base(){}
        
        //metodo que calcula interes compuesto
        public override double Calcular(double capital, double interesPorcentaje)
        {
            System.Console.WriteLine($"El interes compuesto es de  $ {capital * Math.Pow((1 + interesPorcentaje/100), 1)}");
            return capital * Math.Pow((1 + interesPorcentaje/100), 1);
        }
    }

    //entonces ambas calculadoras pueden hacer operaciones basicas, y cada una a su manera agrega el desarrollo 
    //que corresponde al metodo calcular
}
