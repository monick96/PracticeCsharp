namespace Name
{
    class Program
    {
       
        static void Main(string [] args)
        {
            int num1 = 10;
            int num2 = 5;

            int suma = sumar(num1,num2);
            System.Console.WriteLine(suma);
            System.Console.WriteLine(sumar(5,12));

        }

        //Funciones
         static int sumar(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}
