using System;

namespace AdapterÖröklődéssel
{
    class Program
    {
        static void Main()
        {
            Adapter adapter = new Adapter("Nagyon", "Ügyes");

            Ügyfél ügyfél = new Ügyfél(adapter);
            ügyfél.Kiír();

            Console.ReadKey();
        }
    }
}
