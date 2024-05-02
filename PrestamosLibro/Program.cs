using System;
namespace PrestamoLibro
{
    class Program
    {
        static void Main(string [] args)
        {
            // 6. Realizar el algoritmo (diagrama y codificación) de un programa utilizado para efectuar un estudio en
            // una biblioteca municipal sobre el préstamo de los siguientes libros:
            // cod  cant 
            // 1245 240
            // 3285 315
            // 5872 127

            // Para registrar el mismo, deberán indicarse código de libro y cantidad que desea retirar, sabiendo que
            // no pueden retirarse más de cinco por préstamo. En caso de que el código sea igual a cero, se
            // finalizará el ingreso.
            // Por cada préstamo, deberá solicitarse a la persona su número de documento para saber quién tendrá
            // posesión de los libros. A su vez, deberá descontarse la cantidad pedida de la cantidad en depósito
            // para así asegurar la existencia de los libros solicitados. En caso de no encontrarse disponible la
            // cantidad pedida, deberá informarse en pantalla la siguiente leyenda: “El libro x no dispone de esa
            // cantidad”. Además, se desea conocer cuántos libros de cada uno fueron prestados y cuál fue el que
            // menos ejemplares fueron retirados.
            // Una vez finalizado el ingreso de los datos, deberá generarse un número de préstamo iniciado en 1000
            // que se incrementará de a uno el cual será informado en pantalla junto con el número de documento de
            // la persona y código de libro a retirar.

            //libros y cant
            int codLibro1 = 1245;
            int cantLibro1 = 240;
            int codLibro2 = 3285;
            int cantLibro2 = 315;
            int codLibro3 = 5872;
            int cantLibro3 = 127;
            int documento = 0;
            int limiteRetiro = 5;
            int numeroPrestamo = 1000;
            int cantidadRetiro = 0;
            int inputCodigo;
            int contLibro1 = 0;
            int contLibro2 = 0;
            int contLibro3 = 0;
            int codigoLibroRetirado = 0;

            Console.WriteLine("Ingrese el codigo de libro, para terminar ingrese 0");
            inputCodigo = int.Parse(Console.ReadLine());

            while(inputCodigo !=0)
            {
                if (inputCodigo == codLibro1 || inputCodigo == codLibro2 || inputCodigo == codLibro3)
                {  
                    codigoLibroRetirado = inputCodigo;
                   
                    
                    Console.WriteLine("Ingrese la cantidad a retirar (puede retirar hasta 5 unidades): ");
                    cantidadRetiro = int.Parse(Console.ReadLine()); 
                    

                    if (cantidadRetiro <= limiteRetiro && cantidadRetiro >0)
                    {
                        Console.WriteLine("Ingrese su numero de documento: ");
                        documento = int.Parse(Console.ReadLine()); 

                        numeroPrestamo ++;

                        if(inputCodigo == codLibro1 && cantidadRetiro< cantLibro1)
                        {
                            cantLibro1 -=  cantidadRetiro;
                            contLibro1+= cantidadRetiro;
                            limiteRetiro = 0;

                        }
                        else if(cantidadRetiro< cantLibro2 && inputCodigo == codLibro2)
                        {
                            cantLibro2 -=  cantidadRetiro;
                            contLibro2 += cantidadRetiro;
                            limiteRetiro = 0;
                        }
                        else if(inputCodigo == codLibro3 && cantidadRetiro< cantLibro3 )
                        {
                            cantLibro3 -=  cantidadRetiro;
                            contLibro3 += cantidadRetiro;
                            limiteRetiro = 0;
                        }
                        else
                            Console.WriteLine("El libro con codigo " + inputCodigo + " no dispone de esa cantidad");
                            
                    }
                    else
                    {
                        Console.WriteLine("Valor a retirar incorrecto");

                    }

                    if (limiteRetiro == 0)
                    {
                        inputCodigo = 0;
                    }
                }
                else
                {  
                    Console.WriteLine("Libro no encontrado :(");
                    Console.WriteLine("Ingrese el codigo de libro, para terminar ingrese 0");
                    inputCodigo = int.Parse(Console.ReadLine());
                }
                
            }

            if (contLibro1>codLibro2 && codLibro3>codLibro2)
            {
                Console.WriteLine(" El libro con menos prestamo fue " + codLibro2);
            }
            else if (contLibro2>codLibro1 && codLibro3>codLibro1)
            {
                Console.WriteLine(" El libro con menos prestamo fue " + codLibro1);
            }
            else
                Console.WriteLine(" El libro con menos prestamo fue " + codLibro3);
            
            

            Console.WriteLine("la persona con documento: " + documento + " y codigo de retiro: " + numeroPrestamo + ", retiro el libro con codigo " + codigoLibroRetirado);

            Console.WriteLine( "Del libro " + codLibro1 + " se retiraron " + contLibro1);
            Console.WriteLine( "Del libro " + codLibro2 + " se retiraron " + contLibro2);
            Console.WriteLine( "Del libro " + codLibro3 + " se retiraron " + contLibro3);

        }
    }
}
