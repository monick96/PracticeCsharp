/*
 *Analizar y comentar un programa
Escribir comentarios en el c´odigo para cada linea en particular, qu´e hace y por qu´e lo
hace con relaci´on al programa, NO transcribir el c´odigo en prosa!
Por ejemplo si dice
A = 5
No poner solamente ’se asigna a la variable A el valor 5’ sino ademas para qu´e se le asigna
el valor 5, qu´e sentido tiene esto dentro de la funci´on, algoritmo, programa con respecto a la
soluci´on.
Adem´as, hay que comentar qu´e hace cada funci´on en general, su prop´osito, que par´ametros
recibe, el tipo, qu´e significa cada par´ametro y para qu´e se lo usa.
 Se debe incluir tambi´en un comentario general que refleje para qu´e sirve todo este c´odigo
fuente.
Por ultimo, que limitaciones tiene el programa, que validaciones agregarıan y que otras
cosas cambiar´ıan?

*/
using System;
namespace AnalisisPetTicketVenta
{
    class PreTicketDeVenta
    {
        double PidoDoublePorConsola(string mensaje)
        {
            do
            {
                Console.WriteLine(mensaje);
                if (Single.TryParse(Console.ReadLine(), out float numero))
                {
                    return numero;
                }
                { Console.WriteLine("No es un numero valido."); }
            }
            while (true);
        }
        int CargaDatos(double[,] preventa)
        {
            int cant = 0;
            double codigo;
            double cantidad;
            double precioUnitario;
            do
            {
                codigo = PidoDoublePorConsola("Ingrese el codigo del producto:");
                cantidad = PidoDoublePorConsola("Ingrese la cantidad pedida:");
                precioUnitario = PidoDoublePorConsola("Ingrese el precio por unidad:");
                Console.WriteLine();
                if (codigo == 0 || cantidad == 0)
                {
                    break;
                }
                else
                {
                    preventa[cant, 0] = codigo;
                    preventa[cant, 1] = cantidad;
                    preventa[cant, 2] = precioUnitario;
                    preventa[cant, 3] = 0;
                    cant++;
                }
            } while (cant < preventa.GetLength(1));
            return cant;
        }
        double CalculoTotal(double[,] datos, int cant)
        {
            double total = 0;
            int lineas = 0;
            lineas = Math.Min(cant, datos.GetLength(0));
            for (int i = 0; i < lineas; i++)
            {
                datos[i, 3] = datos[i, 1] * datos[i, 2];
                total += datos[i, 3];
            }
            return total;
        }
        void MostrarPreTicket(double[,] venta, int cant, double importeTotal)
        {
            int lineas = 0;
            Console.WriteLine("Ticket Pre-Venta");
            Console.WriteLine(" Codigo Cantidad Precio Unitario Precio");
            lineas = Math.Min(cant, venta.GetLength(0));
            for (int i = 0; i < lineas; i++)
            {
                Console.WriteLine(" {0} {1} {2,10:C2} {3,10:C2}", venta[i, 0], venta);
            }
            Console.WriteLine("Total = {0,10:C2}", importeTotal);
        }
        void PreTicket()
        {
            double[,] datos;
            int cantDatos = 0;
            double total = 0;
            datos = new double[10, 4];
            cantDatos = CargaDatos(datos);
            total = CalculoTotal(datos, cantDatos);
            MostrarPreTicket(datos, cantDatos, total);
        }
        static void Main(string[] args)
        {
            PreTicketDeVenta miProg;
            miProg = new PreTicketDeVenta();
            miProg.PreTicket();
            Console.ReadKey();
        }
    }

    
}
