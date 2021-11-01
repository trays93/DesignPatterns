using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Kölcsön kölcsön = new Kölcsön();
            Ügyfél ügyfél = new Ügyfél("John Doe");
            string kölcsönreJogosult = kölcsön.KölcsönreJogosult(ügyfél, 125000)
                ? "elfogadva" : "elutasítva";

            Console.WriteLine($"{ügyfél.Név} kölcsönkérelme {kölcsönreJogosult}");

            Console.ReadKey();
        }
    }
}
