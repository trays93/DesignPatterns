using System;

namespace Facade
{
    public class Hitel
    {
        public bool JóAdós(Ügyfél ügyfél)
        {
            Console.WriteLine($"Hiteltörténet ellenőrzése: {ügyfél.Név}");
            return true;
        }
    }
}
