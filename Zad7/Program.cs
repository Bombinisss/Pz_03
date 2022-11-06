using System;
using System.Linq;

namespace Zad7
{
    internal class Program
    {
        static int HexaToDecimal(char c)
        {
            switch (c)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                case 'A':
                case 'a':
                    return 10;
                case 'B':
                case 'b':
                    return 11;
                case 'C':
                case 'c':
                    return 12;
                case 'D':
                case 'd':
                    return 13;
                case 'E':
                case 'e':
                    return 14;
                case 'F':
                case 'f':
                    return 15;
            }
            return -1;
        }

        static int HexaToDecimal(char[] hexaDecimalString)
        {
            int dec = 0;
            int multiplier = 1;

            for (int i = hexaDecimalString.Length - 1; i >= 0; i--)
            {
                dec += HexaToDecimal(hexaDecimalString[i]) * multiplier;
                multiplier *= 16;
            }
            return dec;
        }
        static void Main(string[] args)
        {
            char[] hexaDecimal = new char[4];

            Console.WriteLine("Podaj hex: ");
            hexaDecimal[0]=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Podaj hex: ");
            hexaDecimal[1]=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Podaj hex: ");
            hexaDecimal[2]=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Podaj hex: ");
            hexaDecimal[3]=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Dec: " + HexaToDecimal(hexaDecimal));

            Console.ReadKey();
        }
    }
}