using System;
namespace SueldosInstituto
{
    class Program
    {
        static void Main(string [] args)
        {
            //Desarrollar un programa (diagrama y codificación) para realizar el cálculo del salario del mes de
            // diciembre de los empleados de una institución.
            // Para ello se deberá pedir el ingreso de la siguiente información, siempre y cuando el número de
            // empleado sea distinto de cero:
            //  Número de empleado
            //  Sueldo a pagar
            //  Bonificación (si/no)
            // En caso de que reciba bonificación, la misma será de un 20% del sueldo a pagar. Por otro lado,
            // deberá calcularse el aguinaldo correspondiente al empleado sabiendo que el mismo es medio sueldo a
            // pagar, sin aplicar la bonificación.
            // Por cada empleado se debe realizar la siguiente salida en pantalla respetando la distribución de la
            // información y principalmente la cantidad de decimales, si corresponde:
            // -numero empleado
            // -sueldo a pagar $xxxx
            // -bonificacion $xxxx
            // -aguinaldo $xxxx
            // -total a pagar $xxxx
            // Finalmente, se desea conocer número de empleado y sueldo total a pagar de quien recibe el mayor
            // sueldo total.

            int numeroEmpleado;
            float sueldo;
            char bonificacion; //s o n //20% = 0,20
            float valorBonificacion; // sueldo * 0.20
            float aguinaldo; //sueldo/2
            float total;
            int band = 1;
            int numeroEmpleadoMayorTotal = 0;
            float sueldoMayorTotal = 0;

            Console.WriteLine("ingrese el numero de empleado, 0 para terminar: ");
            numeroEmpleado = int.Parse(Console.ReadLine());

            while(numeroEmpleado != 0)
            {

                //monto de sueldo
                Console.WriteLine("Ingrese el monto a abonar: ");
                sueldo = float.Parse(Console.ReadLine());
                
                //bonificacion
                //ñ rompe char
                Console.WriteLine("Ingrese 's' si recibe bonificacion de lo contrario 'n': ");
                bonificacion = char.Parse(Console.ReadLine());

                while(bonificacion != 's' && bonificacion != 'n')
                {
                    Console.WriteLine("Valor incorrecto...");
                    Console.WriteLine("Ingrese 's' o 'n': ");
                    bonificacion = char.Parse(Console.ReadLine());
                }

                if (bonificacion == 's')
                {
                    valorBonificacion = sueldo * 0.20f;
                }
                else
                {
                    valorBonificacion = 0;
                }

                //numero empleado
                Console.WriteLine("Numero de Empleado: " + numeroEmpleado);
                Console.WriteLine(" ");

                //sueldo
                Console.WriteLine("Sueldo a pagar $" + sueldo);

                Console.WriteLine("Bonificacion: $" + valorBonificacion);

                //aguinaldo
                aguinaldo = sueldo/2;
                Console.WriteLine("Aguinaldo: $" + aguinaldo);
                Console.WriteLine(" ");

                //sueldo total a pagar
                total = sueldo + bonificacion + aguinaldo;
                Console.WriteLine("Total a abonar: $" + total);

                //mayor sueldo total
                if(band == 1){
                    sueldoMayorTotal = total;
                    numeroEmpleadoMayorTotal = numeroEmpleado;
                    band = 0;
                }
                else
                {
                    if(total>sueldoMayorTotal)
                    {
                        sueldoMayorTotal = total;
                        numeroEmpleadoMayorTotal = numeroEmpleado;
                    }
                }

                Console.WriteLine("ingrese el numero de empleado, 0 para terminar: ");
                numeroEmpleado = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("El empleado N°: " + numeroEmpleadoMayorTotal + " tiene el mayor sueldo total con $" + sueldoMayorTotal);



        }
    }
}
