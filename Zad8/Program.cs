using System;

namespace Zad8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int count = 0, result = 0;;
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    result += i;
                    count++;
                }
                else if (i % 3 != 0)
                {
                    Console.WriteLine(i);
                    result += i;
                    count++;
                }

                if (result % 7 != 0) result -= i;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}