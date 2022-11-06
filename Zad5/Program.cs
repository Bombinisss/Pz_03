using System;

namespace Zad5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] PoryRoku = { "Wiosna", "Lato", "Jesień", "Zima" };
            string poraUlubiona = "Lato", poraNielubiana = "Jesień";

            Console.WriteLine("Zgadnij jedno lubiane: Wiosna, Lato, Jesień, Zima");
            if (Console.ReadLine() == poraUlubiona) Console.WriteLine("użytkownik zgadł");

            Console.WriteLine("Zgadnij jedno nielubiane: Wiosna, Lato, Jesień, Zima");
            if (Console.ReadLine() == poraNielubiana) Console.WriteLine("użytkownik zgadł");

            Console.ReadKey();
        }
    }
}