using System;

namespace PropertyInjection
{
    class Program
    {
        /// <summary>
        /// Tulajdonságon keresztüli függőség befecskendezés
        /// </summary>
        static void Main()
        {
            Ügyfél ügyfél = new Ügyfél();
            ügyfél.RendezőTulajdonság = new Buborék();
            ügyfél.Munka();
            Console.ReadKey();
        }
    }
}
