using System;

namespace DecimalHexaHexaDecimal30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*30.  	Crear una función que pasando un número decimal, 
             * lo devuelva en hexadecimal. Haz otra función que dado 
             * un número en hexadecimal, lo devuelva en decimal.*/
            //pendiente manejar la conversion de numeros con coma

            decimal num;
            string hexa;

            Console.WriteLine("Conversion de decimal a hexadecimal");
            Console.WriteLine("Ingrese el decimal a convertir: ");
            num = decimal.Parse(Console.ReadLine());
            hexa = decimalHexa(num);
            Console.WriteLine($"el numero {num} en hexadecimal es: {hexa}");

            Console.WriteLine("Presione enter para convertir de hexadecimal a decimal...");
            Console.ReadKey();
            ////////////////////////////////////////////////////////
            Console.WriteLine("Conversion de hexadecimal a decimal");
            Console.WriteLine("Ingrese el hexadecimal a convertir: ");
            hexa = Console.ReadLine();
            num = HexaDecimal(hexa);
            Console.WriteLine($"el hexadecimal {hexa} en decimal es: {num}");

            Console.ReadKey();

        }

        //decimal a hexa
        static string decimalHexa(decimal num) 
        {
            string hexaResult = "";
            decimal absNum = Math.Abs(num);
            char[] arrayResult;


            if (absNum >= 0 && absNum <=9)
                hexaResult = absNum.ToString();
            else if (absNum >= 10 && absNum <= 15)
            {
                hexaResult = HexaValues(absNum).ToString();
            }
            else
            {
                while (absNum >= 1)
                {
                    decimal resto = Math.Floor(absNum % 16);
                    if (resto > 9 && resto < 16)
                    {
                        char hexa = HexaValues(resto);
                        hexaResult += hexa;
                    }
                    else
                    {
                        hexaResult += resto.ToString();
                    }
                    absNum = absNum / 16;
                }
            }

            //ordenamiento
            arrayResult = hexaResult.ToCharArray();

            //resetear variable de retorno
            hexaResult = "";

            ///for para ordenar de atras para delante sin usar reverse
            for (int i = arrayResult.Length-1;i >= 0;i--)
            {
                hexaResult += arrayResult[i];
            }

            if (num < 0)
                hexaResult = "-" + hexaResult;

            return hexaResult;
        }


        //hexa a decimal
        
        static decimal HexaDecimal(string hexa)
        {
            decimal[] arrayHexa = new decimal[hexa.Length];
            decimal dec = 0;
            bool esNegativo = false;
            char[] arrayChar = hexa.ToCharArray();
            byte peso= (byte)(arrayHexa.Length -1);

            //convierto cada caracter en un numero tipo decimal 
            //numberString[i] - '0' convierte el carácter del dígito en su valor numérico.
            for(int i = 0; i < arrayHexa.Length; i++)
            {
                if (arrayChar[i] == 'A'|| arrayChar[i] == 'B' || arrayChar[i] == 'C' || arrayChar[i] == 'D' || arrayChar[i] == 'E' || arrayChar[i] == 'F')
                    arrayHexa[i] = HexaValues(hexa[i]);
                else if (arrayChar[i] == '-')
                {
                    arrayHexa[i] = -1; //manejo de espacio y signos
                    esNegativo = true;
                    peso--;
                }
                else
                {
                    arrayHexa[i] = arrayChar[i] - '0';
                }
                
            }

            //multiplicamos el valor de cada numero * 16
            //elevado al peso de la posicion
            for(int i = 0; i<arrayHexa.Length;i++)
            {
                if (arrayHexa[i] != (decimal)-1)
                {
                    dec += (arrayHexa[i] * (decimal)(Math.Pow(16, peso)));
                    peso--;
                }
                
            }

            if (esNegativo)
                dec *= -1;

            return dec;

        }

        //recibe decimal devuelve char
        static char HexaValues(decimal num)
        {
            char optionValue = ' ';

            switch (num)
            {
                case (10):
                    optionValue = 'A';
                    break;
                case (11):
                    optionValue = 'B';
                    break;
                case (12):
                    optionValue = 'C';
                    break;
                case (13):
                    optionValue = 'D';
                    break;
                case (14):
                    optionValue = 'E';
                    break;
                case (15):
                    optionValue = 'F';
                    break;
                default:
                    break;
            }

            return optionValue;
        }

        //recibe char devuelve int
        static int HexaValues(char option)
        {
            int optionValue = 0;

            switch(option)
            {
                case ('A'):
                    optionValue = 10;
                    break;
                case ('a'):
                    optionValue = 10;
                    break;
                case ('B'):
                    optionValue = 11;
                    break;
                case ('b'):
                    optionValue = 11;
                    break;
                case ('C'):
                    optionValue = 12;
                    break;
                case ('c'):
                    optionValue = 12;
                    break;
                case ('D'):
                    optionValue = 13;
                    break;
                case ('d'):
                    optionValue = 13;
                    break;
                case ('E'):
                    optionValue = 14;
                    break;
                case ('e'):
                    optionValue = 14;
                    break;
                case ('F'):
                    optionValue = 15;
                    break;
                case ('f'):
                    optionValue = 15;
                    break;
                default:
                    Msg("Opcion invalida");
                    break; 
            }

            return optionValue;
        }

        //procedimiento para mostrr msgs en consola
        static void Msg(string msg)
        {
            Console.WriteLine(msg);
        }
           
    }
}
