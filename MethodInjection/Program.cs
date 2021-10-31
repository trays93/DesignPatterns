using System;

namespace MethodInjection
{
    class Program
    {
        /// <summary>
        /// Metóduson keresztüli függőség befecskendezés
        /// </summary>
        static void Main()
        {
            Ügyfél ügyfél = new Ügyfél();
            ügyfél.RendezésMetódus(new Buborék());
            ügyfél.Munka();
            Console.ReadKey();
        }
    }
}
