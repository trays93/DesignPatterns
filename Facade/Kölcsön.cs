using System;

namespace Facade
{
    public class Kölcsön
    {
        private Bank _bank = new Bank();
        private Hitel _hitel = new Hitel();

        public bool KölcsönreJogosult(Ügyfél ügyfél, int összeg)
        {
            Console.WriteLine($"{ügyfél.Név}, {összeg} összegű kölcsönkérelme.");

            bool kölcsönreJogosult = true;

            if (!_bank.VanElegendőMegtakarítása(ügyfél, összeg))
            {
                kölcsönreJogosult = false;
            }
            else if (!_hitel.JóAdós(ügyfél))
            {
                kölcsönreJogosult = false;
            }

            return kölcsönreJogosult;
        }
    }
}
