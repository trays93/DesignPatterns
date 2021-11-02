using System;

namespace Egyke
{
    class Program
    {
        static void Main()
        {
            // Használat:
            Egyke e = Egyke.Példány();
            e.Művelet();

            Egyke egyke = Egyke.PéldányTulajdonság;
            e.Művelet();
            Console.ReadKey();
        }
    }
}
