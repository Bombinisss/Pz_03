using System;

namespace Zad1
{
    internal class Program
    {
        public static int Minimum(int a, int b, int c)
        {
            if (a < b && a < c) return a;

            else if (b < a && b < c) return b;

            else if (c < b && c < a) return c;
            else if (a == b && a < c)
                return a;
            return c;
        }

        public static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            Console.WriteLine("Podaj a b c: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Minimum to :" + Minimum(a, b, c));
            Console.ReadKey();
        }
    }
}