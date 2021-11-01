using System;

namespace AdapterBeágyazással
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter = new Adapter("Nagyon", "Ügyes");

            Ügyfél ügyfél = new Ügyfél(adapter);
            ügyfél.Kiír();

            Console.ReadKey();
        }
    }
}
