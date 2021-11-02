using System;
using System.Threading;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Részvény r = new Részvény();

            Befektető géza = new Befektető("Géza", r, 500);
            Befektető balázs = new Befektető("Balázs", r, 1000);

            r.Árfolyam = 10;
            Thread.Sleep(1000);
            r.Árfolyam = 12;

            Console.ReadKey();
        }
    }
}
