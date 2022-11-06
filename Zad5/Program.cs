using System;

namespace Zad5
{
    internal class Program
    {
        public enum PoryRoku
        {
            Wiosna, Lato, Jesień, Zima
        }
        public static void Main(string[] args)
        {
            var c = (PoryRoku)2;
            var d = (PoryRoku)3;
            Console.WriteLine("Zgadnij jedno lubiane jako cyfra: Wiosna, Lato, Jesień, Zima");
            if (int.Parse(Console.ReadLine()) == (int)c) Console.WriteLine("użytkownik zgadł");
            else Console.WriteLine("użytkownik niezgadł");

            Console.WriteLine("Zgadnij jedno nielubiane jako cyfra: Wiosna, Lato, Jesień, Zima");
            if (int.Parse(Console.ReadLine()) == (int)d) Console.WriteLine("użytkownik zgadł");
            else Console.WriteLine("użytkownik niezgadł");

            Console.ReadKey();
        }
    }
}