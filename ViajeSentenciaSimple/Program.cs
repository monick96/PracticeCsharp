using System;
namespace Viaje
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una familia de 4 personas desea irse de viaje. 
            // Para esto deben tener en cuenta lo siguiente:
            //  a) Precio de pasajes aéreos. 
            //  b) Precio de un hotel por noche. 
            //  c) Cantidad de noches. 
            //  d) Alquiler de un auto (precio por día). 
            //  El programa debe calcular el total que saldrá el viaje, teniendo en cuenta que el
            // alquiler del auto será por la mitad de la estadía

            int cantPersonas = 4;
            int cantNoches;
            float precioPasaje;
            float precioHotelPorNoche;
            float alquilerAutoPorDia;
            float total;

            Console.WriteLine("Ingrese el valor de los pasajes por persona: ");
            precioPasaje = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio por noche y por persona del hotel: ");
            precioHotelPorNoche = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de noches que se alojara en el hotel: ");
            cantNoches = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor por dia del alquiler de auto: ");
            alquilerAutoPorDia = int.Parse(Console.ReadLine());

            total = (cantPersonas*precioPasaje) +
             (cantNoches *precioHotelPorNoche * cantPersonas) + 
             (alquilerAutoPorDia*(cantNoches/2));

            Console.WriteLine("El costo total del viaje es de: $" + total);

            
        }
    }
}
