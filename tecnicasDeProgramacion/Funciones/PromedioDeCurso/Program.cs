using System;
namespace PromedioDeCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa  que permita calcular el mayor promedio de un curso de 30
            alumnos para poder asignar la beca al mismo.
            Para ello deberá cargarse la siguiente información de cada alumno:
             Número de legajo
             3 notas parciales
            Para asegurarse el ingreso correcto de las notas, deberán validarse las mismas para que sea un número
            entre 1 y 10 en una función.
            Una vez validadas, deberá calcularse el promedio del alumno a quienes correspondan las mismas.
            También se desea conocer el promedio general y el porcentaje de aprobados y desaprobados del curso.
            Generar un nuevo vector, que contenga los promedios de los alumnos aprobados. Si existe, se deberá
            informar el nuevo vector generado.
            Al encontrar el mayor promedio, deberá informarse su número de legajo y la leyenda “recibe beca” para
            confirmarlo.*/
            //int[] legajos = {1,2,3,4,5,6};//prueba
            //float [] promedioAlumnos = {4,9,5,8,3,2}; //prueba
            int numEstudiantes = 30;
            int cantNotas = 3;
            //promedios y legajos inicial
            int[] legajos = new int[numEstudiantes];
            float[] promedioAlumnos = new float[numEstudiantes];
            //array que guarda 2 resultados [0] porcentaje aprobados, [1] porcentaje desaprobados
            float [] porcentajeAprobadosDesaprobados;
            //lo paso por ref a CalcularPorcentajeAprobadosDesaprobados()
            //para despues poder dimensionar mi array de aprobados si existe
            int contAprobados = 0;
            //arrays de legajos y promedios aprobados
            int[] legajosAprobados = new int[contAprobados];
            float [] promediosAprobados = new float [contAprobados];

            //invocacion funciones
            RellenarArray(legajos,promedioAlumnos,cantNotas);

            //descomentar si se quiere ver los array originales
            //MostrarArray(promedioAlumnos,legajos);

            //de esta funcion obtengo por referencia la cantidad de aprobados para dimensionar mi vector de aprobados
            porcentajeAprobadosDesaprobados = CalcularPorcentajeAprobadosDesaprobados(promedioAlumnos,ref contAprobados);
            //de los arrays iniciales filtro solo los aprobados
            RellenarArrayAprobados(legajosAprobados,promediosAprobados,legajos, promedioAlumnos);

            //muestro promedio general, porcentaje aprobados, desaprobados
            System.Console.WriteLine($"El promedio general es de {CalcularPromedioGeneral(promedioAlumnos)}");
            System.Console.WriteLine($"El porcentaje de aprobados es de {porcentajeAprobadosDesaprobados[0]}%");
            System.Console.WriteLine($"El porcentaje de desaprobados es de {porcentajeAprobadosDesaprobados[1]}%");

            System.Console.WriteLine("Estudiantes aprobados:");
            MostrarArray(promediosAprobados,legajosAprobados);

            //muestra el mayor promedio y el msj que recibe la beca
            MayorPromedio(legajosAprobados, promediosAprobados);

        }

        static void MayorPromedio(int[] legajosAprobados, float[] promediosAprobados)
        {
            float maxProm;
            int maxLegajo;
            if (legajosAprobados.Length != 0 && promediosAprobados.Length != 0 )
            {
                maxProm = promediosAprobados[0];
                maxLegajo = legajosAprobados[0];
                for(int i = 1; i < promediosAprobados.Length; i++)
                {
                    if(promediosAprobados[i] > maxProm)
                    {
                        maxProm = promediosAprobados[i];
                        maxLegajo = legajosAprobados[i];
                    }
                }

                System.Console.WriteLine($"El alumno {maxLegajo} con mayor Promedio: {maxProm}");
                System.Console.WriteLine("Es el beneficiario de la beca!");
            }
        }

        static void RellenarArrayAprobados
        (int [] legajosAprobados, float[] promediosAprobados, int[] legajos, float[] promedios)
        {
            int posRellenar = 0;
            for (int i = 0; i < legajos.Length; i ++)
            {
                if (Aprobado(promedios[i]))
                {
                    legajosAprobados[posRellenar] = legajos[i];
                    promediosAprobados[posRellenar] = promedios[i];
                    posRellenar++;
                }
            }

        }

        //calcular porcentaje de aprobados
        static float[] CalcularPorcentajeAprobadosDesaprobados(float[] promedios,ref int contAprobados)
        {
            float [] porcentajes = new float[2];
            int contDesaprobados = 0;
            for(int i = 0; i < promedios.Length; i++)
            {
                if(Aprobado(promedios[i]))
                {
                    contAprobados ++;
                }
                else
                {
                    contDesaprobados ++;
                }

            }

            //aprobados en pos [0] del array
            porcentajes[0] = contAprobados * 100 / promedios.Length;

            //desaprobados en pos [1]
            porcentajes[1]= contDesaprobados * 100 / promedios.Length;

            return porcentajes;

        }

        //calcular promedio general
        static float CalcularPromedioGeneral(float [] array)
        {
            float prom;
            float suma = 0;

            for(int i = 0; i<array.Length; i ++)
            {
                suma+= array[i];
            }

            prom = suma / array.Length;

            return prom;
        }


        //rellena array de legajos y promedios ,calculando el promedio de cada estudiante
        static void RellenarArray(int[] legajos,float[] promedios, int cantNotas)
        {
            System.Console.WriteLine("Ingrese los datos de los alumnos...");
            for(int i = 0; i < promedios.Length; i ++)
            {
                float  sumaNotas = 0;
            

                System.Console.WriteLine($"Ingrese el legajo n° {i + 1}");
                legajos[i] = int.Parse(Console.ReadLine());

                System.Console.WriteLine($"Ingrese las 3 notas para el legajo {legajos[i]} :");
                System.Console.WriteLine("El rango permitido es de 1 a 10");
                for(int j = 0; j < cantNotas; j++)
                {
                    float nota = 0;
                    System.Console.WriteLine($"Ingrese la nota n°{j + 1}:");
                    nota = float.Parse(Console.ReadLine());

                    while(!EsNotaValida(nota))
                    {
                        System.Console.WriteLine("Nota invalida");

                        System.Console.WriteLine($"Ingrese la nota n°{j + 1} nuevamente:");
                        nota = float.Parse(Console.ReadLine());
                    }

                    sumaNotas += nota;
                }

                promedios[i] = sumaNotas/cantNotas;
            }
        }
    
        static bool EsNotaValida(float num)
        {
            bool valido = false;

            if(num >= 1 && num <= 10)
                valido = true;

            return valido;
        }
        //bool aprobado
        static bool Aprobado(float nota)
        {
            bool aprobado = false;

            if(nota >=4)
                aprobado = true;

            return aprobado;
        }


        static void MostrarArray(float [] arrayPromedios, int[] legajos){
            if (arrayPromedios.Length != 0 && legajos.Length != 0 )
            {
                for(int i = 0; i < arrayPromedios.Length;i++)
                {
                    System.Console.WriteLine($"Legajo: {legajos[i]}");
                    System.Console.WriteLine($"Promedio: {arrayPromedios[i]}");
                    System.Console.WriteLine("--------------------------------");
                }
            }
            else
            {
                System.Console.WriteLine("NO hay nada que mostrar:( ");
            }
        }
    }
}
