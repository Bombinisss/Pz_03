using System;

namespace Zad6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Podaj jedno + - * /");
            string operation = Console.ReadLine();
            Console.WriteLine("Podaj operator pierwszy");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj operator drugi");
            int input2 = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            switch (operation)
            {
                case "+":
                {
                    result = Addition(input1, input2);
                    break;
                }
                case "-":
                {
                    result = Subtraction(input1, input2);
                    break;
                }
                case "*":
                {
                    result = Multiplication(input1, input2);
                    break;
                }
                case "/":
                {
                    result = Division(input1, input2);
                    break;
                }
                default:
                    Console.WriteLine("ZŁY OPERATOR!!");
                    break;
            }

            Console.WriteLine("Wynik wynosi {0}", result);
            Console.ReadKey();
        }

        public static double Addition(double input1, double input2)
        {
            double result = input1 + input2;
            return result;
        }

        public static double Subtraction(double input1, double input2)
        {
            double result = input1 - input2;
            return result;
        }

        public static double Multiplication(double input1, double input2)
        {
            double result = input1 * input2;
            return result;
        }

        public static double Division(double input1, double input2)
        {
            double result = input1 / input2;
            return result;
        }
    }
}