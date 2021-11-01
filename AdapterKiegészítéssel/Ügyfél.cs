using System;

namespace AdapterKiegészítéssel
{
    public class Ügyfél
    {
        private INév _név;

        public Ügyfél(INév név)
        {
            _név = név;
        }

        public void Kiír()
        {
            Console.WriteLine($"{_név.Vezetéknév}\t{_név.Utónév}\t{_név.TeljesNév}");
        }
    }
}
