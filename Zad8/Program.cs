using System;

namespace Zad8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int result = 0,result2=0;
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0)
                {
                    result += i;

                    if (result % 7 != 0)
                    {
                        result -= i;
                    }
                    else
                    {
                        Console.WriteLine("Niepodzielna przez 2: "+i);
                        result2 += i;
                    }
                }
                else if (i % 3 != 0)
                {
                    
                    result += i;

                    if (result % 7 != 0)
                    {
                        result -= i;
                    }
                    else
                    {
                        Console.WriteLine("Niepodzielna przez 3: "+i);
                        result2 += i;
                    }
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}