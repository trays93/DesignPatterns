using System;

namespace Facade
{
    public class Bank
    {
        public bool VanElegendőMegtakarítása(Ügyfél ügyfél, int összeg)
        {
            Console.WriteLine($"Egyenleg ellenőrzése: {ügyfél.Név}");
            return true;
        }
    }
}
