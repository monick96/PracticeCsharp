using System; 
namespace ConsumoCombustible
{
    class Program
    {
        static void Main(string [] args)
        {
            //Un vehículo consume 12 litros de combustible cada 100 km a 130 km/h. 
            //Se desea realizar un programa que calcule el total consumido en un viaje de 500 km. 
            //Para esto el programa debe pedir la
            // velocidad medida en 3 puntos del viaje. Con el promedio de las velocidades, 
            //calcular el total de combustible consumido.

            float velocidad1;
            float velocidad2;
            float velocidad3;
            float totalConsumo;
            float promedioVelocidad;
            //12l/100km cuanto gasta por km a 130km
            float consumoPorKm = 12.0f / 100.0f;
           
            //si el consumo de combustible es lineal con respecto a la velocidad
            //entonces dedusco que si divido el consumo por km por 130km/h 
            //obtengo la constante de consumo por km y por km/h 
            float consumoPorKm_PorKmPorHora = consumoPorKm / 130.0f;
    

            Console.WriteLine("Ingrese velocidad del punto 1:");
            velocidad1 = float.Parse(Console.ReadLine());
            

            Console.WriteLine("Ingrese velocidad del punto 2:");
            velocidad2 = float.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese velocidad del punto 3:");
            velocidad3 = float.Parse(Console.ReadLine());


            //100km a 130km/h -----12l
            //xkm km/h ----- xl
            //12l/100km cuanto gasta por km a 130km

            promedioVelocidad = (velocidad1 +velocidad2 +velocidad3) /3.0f;
           
            totalConsumo= promedioVelocidad * 500.0f * consumoPorKm_PorKmPorHora;

            Console.WriteLine("El total consumido de combustible es de : " + totalConsumo + "L" );


        }
    }
}
