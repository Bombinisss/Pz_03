using System;

namespace Zad2
{
    internal class Program
    {
        public static int Maximum(int a, int b, int c)
        {
            int output = 0;

            output = a > b && a > c ? a : c > a && c > b ? c : b;

            return output;
        }

        public static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            Console.WriteLine("Podaj a b c: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Maximum to :" + Maximum(a, b, c));
            Console.ReadKey();
        }
    }
}