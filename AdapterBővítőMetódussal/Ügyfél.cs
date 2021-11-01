using System;

namespace AdapterBővítőMetódussal
{
    public class Ügyfél
    {
        private Személy _név;

        public Ügyfél(Személy név)
        {
            _név = név;
        }

        public void Kiír()
        {
            Console.WriteLine($"{_név.Vezetéknév}\t{_név.Utónév}\t{_név.TeljesNév()}");
        }
    }
}
