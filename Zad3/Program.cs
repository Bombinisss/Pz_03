using System;

namespace Zad3
{
    internal class Program
    {
        public static bool Contains(int x1, int x2, int x3, int x4)
        {
            if ((x2 >= x4 && x1 <= x4) || (x1 >= x3 && x2 <= x3) || (x4 >= x2 && x4 <= x1) || (x3 >= x1 && x3 <= x2) ||
                (x1 >= x3 && x2 <= x4) || (x3 >= x1 && x4 <= x2)) return true;

            return false;
        }

        public static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0, d = 0;
            Console.WriteLine("Podaj x1 x2 x3 x4: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("Zawiera ?:" + Contains(a, b, c, d));
            Console.ReadKey();
        }
    }
}