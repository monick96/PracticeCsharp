using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarioAdecimalDecimalAbinario29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*29.  	Crear una función que pasando un número decimal, 
             * lo devuelva en binario. Haz otra función que dado un binario binario ,
             * nos devuelva su número decimal. Para representar un número en binario se 
             * puede usar por ejemplo una cadena de caracteres como el string ”0011” representa
             * el número 3, aunque también se puede usar un número del tipo long.*/
            int num;
            num = - 20;//- 10100
            long numB;
            numB = 110111; //55


            Console.WriteLine(DecimalAbinario(num));

            Console.WriteLine(BinarioAdecimal(numB));
            Console.ReadKey();

        }
        //funcion
        static string DecimalAbinario(int num)
        {
            string resultString = "";
            char[] arrayResult;
            int valorAbsNum = Math.Abs(num);
            


            while(valorAbsNum >= 1)
            {
                int result = valorAbsNum % 2;
                valorAbsNum = valorAbsNum / 2;
                resultString += Convert.ToString(result);
            }
            //se agraga el 1 de la ultima division 
            //resultString += Convert.ToString(num);

            //convierto en array para ordenar
            arrayResult = resultString.ToCharArray();

            //reseteo varible
            resultString = "";

            //ordeno los resultados
            for (int i = arrayResult.Length -1; i >= 0; i--)
            {
                resultString += Convert.ToString(arrayResult[i]);
            }
            
            //caso en que el numero sea negativo
            if (num < 0)
            {
                resultString = "- " + resultString;
            }
            
            return resultString;
        }

        //int
        static int BinarioAdecimal(long numB) 
        {
            string longString;
            long[] arrayLong;
            int dec = 0;
            int peso;
            //convierto el long en string
            longString = numB.ToString();

            //creo un array de tipo long para almacenar los valores
            arrayLong = new long[longString.Length];

            //convierto cada caracter en un numero tipo long 
            //numberString[i] - '0' convierte el carácter del dígito en su valor numérico.
            for (int i = 0; i < longString.Length; i++)
            {
                arrayLong[i] = (long)(longString[i] - '0');
            }

            //variable para elevar 2 al peso de la columna del numero binario
            peso = arrayLong.Length - 1;

            //multiplicamos el valor de cada numero *
            //2elevado al peso de la posicion y lo convierto en entero
            for(int i = 0; i<arrayLong.Length;i++)
            {
                dec += (int)(arrayLong[i]* (long)(Math.Pow(2,peso)));
                peso--;
            }

            return dec;
        }
        
    }
}
