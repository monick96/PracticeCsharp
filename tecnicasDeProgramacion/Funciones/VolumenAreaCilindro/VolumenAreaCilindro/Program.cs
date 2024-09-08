using System;

namespace VolumenAreaCilindro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                8. Se necesita una función que calcule
                y muestre en pantalla el área o el volumen de un 
                cilindro, según se especifique. Para distinguir un caso de otro, 
                además de pasarle por parámetro el radio y la altura, se le pasará 
                el carácter ’a’ (para área) o ’v’ (para el volumen).
            */

            float valorR;
            float valorH;
            char caso;

            Console.WriteLine("Ingrese el radio del cilindro: ");
            valorR = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del cilindro: ");
            valorH = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese 'a' siquiere calcular el area, 'v' si quiere calcular el volumen: ");
            caso = char.Parse(Console.ReadLine());

            while (caso != 'a' && caso != 'v')
            {
                Console.WriteLine("Opcion incorrecta!");
                Console.WriteLine("Ingrese 'a' siquiere calcular el area, 'v' si quiere calcular el volumen: ");
                caso = char.Parse(Console.ReadLine());
            }

            float result = CalcularAreaVolumenCilindro(valorH, valorR, caso);

            if (caso == 'a') 
            {
                Console.WriteLine($" EL area del cilindro es de: {result}");
            }
            else
            {
                Console.WriteLine($" EL volumen del cilindro es de: {result}");
            }

            /// Fin punto 8
            Console.WriteLine("Presione enter para ir al siguiente punto...");
            Console.ReadKey();

            //////////////////////////////////////////////////////////////////////////////////
            /*
             
            9. Idem al anterior pero que devuelva un array con ambos cálculos: el área y el volumen. 

             */
            /////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Ingrese el radio del cilindro: ");
            valorR = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del cilindro: ");
            valorH = float.Parse(Console.ReadLine());

            float[] areaVolCilindro = CalcularAreaVolumenCilindro2(valorH, valorR);
            Console.WriteLine($" EL volumen del cilindro es de: {areaVolCilindro[0]} y el volumen es de : {areaVolCilindro[1]}");
            Console.ReadKey();


        }

        //declaracion funciones
        static float CalcularAreaVolumenCilindro(float h,float r,char caso)
        {
            float result;

            if (caso == 'a')
            {
                result = (float)Math.PI * (r * r);
                return result;
            }
            else 
            {
                result = ((float)Math.PI * (r * r)) * h;
                return result;
            }
            return result;
        }

        static float[] CalcularAreaVolumenCilindro2(float h, float r)
        {
            float[] result = new float[2];

            //calculo area
            result[0] = (float)Math.PI * (r * r);

            //calculo volumen
            result[1] = ((float)Math.PI * (r * r)) * h;
            
            return result;
        }
    }
}

