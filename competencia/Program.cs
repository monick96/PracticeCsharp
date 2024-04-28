using System;

namespace competencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa para la organización de un torneo deportivo,
            //que contenga la información correspondiente al número de participante,
            //edad y puntos obtenidos en una competencia, y que finalice al ingresar número
            //de participante 0 (inexistente).
            //Dicho programa debe calcular e informar:
            //a)¿Cuántos participantes tienen más de 20 años?
            //b)¿Cuántos participantes obtuvieron menos de 50 puntos?
            //c)Total de puntos obtenidos.
            //d)Número de participante, edad y puntos obtenidos del participante de menor número.

            int numeroParticipante, edad, puntos, contadorParticipantes,
            contadorParticipantesMenos50, totalPuntos, menosPuntos,
            bandera, menosPuntosEdad, menosPuntosNumero, contadorParticipantesEdadMas20;

            //inicializacion de variables
            bandera = 1;
            menosPuntos = 0;
            contadorParticipantes = 0;
            contadorParticipantesMenos50 = 0;
            contadorParticipantesEdadMas20 = 0;
            totalPuntos = 0;
            menosPuntosEdad = 0;
            menosPuntosNumero = 0;

            Console.WriteLine("Ingrese numero de participante: ");
            numeroParticipante = int.Parse(Console.ReadLine());

            while (numeroParticipante != 0)
            {
                Console.WriteLine("Ingrese edad del participante: ");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese los puntos participante: ");
                puntos = int.Parse(Console.ReadLine());

                //fijamos el piso de puntos 
                if (bandera == 1)
                {
                    menosPuntos = puntos;
                    menosPuntosNumero = numeroParticipante;
                    menosPuntosEdad = edad;
                    bandera = 0;
                }
                else
                {
                    //comparamos si el puntaje ingresados es menor al almacenado
                    if (puntos < menosPuntos)
                    {
                        menosPuntos = puntos;
                        menosPuntosNumero = numeroParticipante;
                        menosPuntosEdad = edad;
                    }
                }

                //contamos los participantes
                contadorParticipantes += 1;

                //verificamos si la edad es menor a 20
                if (edad > 20)
                {
                    contadorParticipantesEdadMas20 += 1;
                }

                //verificamos si los puntos son menor a 50
                if (puntos < 50)
                {
                    contadorParticipantesMenos50 += 1;
                }

                totalPuntos += puntos;
              

                Console.WriteLine("Ingrese numero de participante: ");
                numeroParticipante = int.Parse(Console.ReadLine());


            }

            Console.WriteLine(contadorParticipantesEdadMas20 + " participantes tienen más de 20 años");
            Console.WriteLine(contadorParticipantesMenos50 + " participantes obtuvieron menos de 50 puntos");
            Console.WriteLine("Total de puntos obtenidos fue de: " + totalPuntos);
            //Número de participante, edad y puntos obtenidos del participante de menor número
            Console.WriteLine("El participante numero: " + menosPuntosNumero + " de " +
            menosPuntosEdad + " años " + " obtuvo el menor puntaje con: " + menosPuntos + "puntos");
            Console.ReadKey();

        }
    }
}

