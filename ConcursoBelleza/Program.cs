using System;
namespace ConcursoBelleza
{
    class Program
    {
        static void Main(string [] args)
        {
            //5. Realizar el algoritmo y codificar en lenguaje C, un programa para la organización de un concurso de
            // belleza. De las 20 participantes del concurso, se irá registrando los siguientes datos:

            // Número de participante.
            // Puntos por inteligencia.
            // Puntos por cultura general.
            // Puntos por belleza.

            // Se necesita informar por pantalla:

            //     - El total de puntos obtenidos entre todas las participantes en cada una de las categorías (total en
            //         inteligencia, total en belleza y total en cultura general). ok
                    
            //     - Cuántas participantes tiene como menor puntaje en la categoría inteligencia, cuántas en la categoría
            //         cultura general y cuántas en belleza.

            //     - Puntaje total acumulado por todas las participantes en las tres categorías.ok

            //     - Número de participante y puntaje general, de la concursante de mayor puntaje general.

            int numParticipante;
            int puntosInteligencia;
            int puntosCultura;
            int puntosbelleza;
            ///totales
            int totalBelleza = 0;
            int totalInteligencia = 0;
            int totalCultura = 0;
            //total puntos de categorias
            int sumaCategorias;
            //menores puntjes
            int menorCultura = 0;
            int menorBelleza = 0;
            int menorInteligencia = 0;
            //mejr participante
            //int mayorPuntaje;
            int numeroParticipanteMayorPuntaje = 0;
            int mayorPuntajeGeneral = 0;
            int puntajeGeneral;
            //bandera
            int bandera = 1;

            for( int i = 1; i<=2; i ++)
            {
                Console.WriteLine("Ingrese el numero de Parcipante:");
                numParticipante = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese los puntos de Intelligencia del Parcipante:");
                puntosInteligencia = int.Parse(Console.ReadLine());

                totalInteligencia += puntosInteligencia;

                Console.WriteLine("Ingrese los puntos de Cultura general del Parcipante:");
                puntosCultura = int.Parse(Console.ReadLine());

                totalCultura += puntosCultura;

                Console.WriteLine("Ingrese los puntos de belleza del Parcipante:");
                puntosbelleza = int.Parse(Console.ReadLine());

                totalBelleza += puntosbelleza;

                puntajeGeneral = puntosbelleza + puntosCultura +  puntosInteligencia;

                if(puntosbelleza<puntosCultura && puntosbelleza<puntosInteligencia)
                {
                    menorBelleza ++;
                }
                else if(puntosCultura<puntosbelleza && puntosCultura<puntosInteligencia)
                {
                    menorCultura ++;
                }
                else
                    menorInteligencia ++ ;
                


                if(bandera== 1)
                {
                    numeroParticipanteMayorPuntaje = numParticipante;
                    mayorPuntajeGeneral = puntajeGeneral;
                    bandera = 0;
                }
                else
                {
                    if(puntajeGeneral > mayorPuntajeGeneral)
                    {
                        mayorPuntajeGeneral = puntajeGeneral;
                        numeroParticipanteMayorPuntaje = numParticipante;
                    }
                }


            }

            sumaCategorias = totalInteligencia + totalCultura + totalBelleza;

            Console.WriteLine("La suma de los puntajes de todas las categorias de los participantes es de: " + sumaCategorias);
            Console.WriteLine("En la categoria Belleza el puntaje total fue de : " + totalBelleza);
            Console.WriteLine("En la categoria Intelligencia el punteje total fue de : " + totalInteligencia);
            Console.WriteLine("En la categoria Cultura General el punteje total fue de : " + totalCultura);
            Console.WriteLine("La participante numero : " + numeroParticipanteMayorPuntaje + " obtuvo el mayor puntaje general con : " + mayorPuntajeGeneral + 
            " puntos");

            Console.WriteLine(menorBelleza + " participantes obtuvieron un puntaje menor en Belleza");
            Console.WriteLine(menorCultura + " participantes obtuvieron un puntaje menor en Cultura general");
            Console.WriteLine(menorInteligencia + " participantes obtuvieron un puntaje menor en Intelligencia");
            
        }
    }
}