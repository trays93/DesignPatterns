using System;

namespace AdapterKiegészítéssel
{
    class Program
    {
        static void Main()
        {
            Személy személy = new Személy("Nagyon", "Ügyes");

            Ügyfél ügyfél = new Ügyfél(személy);
            ügyfél.Kiír();

            Console.ReadKey();
        }
    }
}
