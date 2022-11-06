using System;

namespace Zad4
{
    internal class Program
    {
        private static bool Contains(int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4)
        {
            if ((x2 >= x4 && x1 <= x4) || (x1 >= x3 && x2 <= x3) || (x4 >= x2 && x4 <= x1) || (x3 >= x1 && x3 <= x2) ||
                (x1 >= x3 && x2 <= x4) || (x3 >= x1 && x4 <= x2))
            {
                if ((y2 >= y4 && y1 <= y4) || (y1 >= y3 && y2 <= y3) || (y4 >= y2 && y4 <= y1) ||
                    (y3 >= y1 && y3 <= y2) || (y1 >= y3 && y2 <= y4) || (y3 >= y1 && y4 <= y2))
                    return true;
            }

            return false;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj x1 y1 x2 y2: ");
            int a = int.Parse(Console.ReadLine() ?? "0");
            int y1 = int.Parse(Console.ReadLine() ?? "0");
            int b = int.Parse(Console.ReadLine() ?? "0");
            int y2 = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Podaj x1 y1 x2 y2: ");
            int c = int.Parse(Console.ReadLine() ?? "0");
            int y3 = int.Parse(Console.ReadLine() ?? "0");
            int d = int.Parse(Console.ReadLine() ?? "0");
            int y4 = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Zawiera ?:" + Contains(a, b, c, d, y1, y2, y3, y4));
            Console.ReadKey();
        }
    }
}