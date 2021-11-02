using System;

namespace Observer
{
    public class Befektető
    {
        private readonly int _darab;

        public string Név { get; set; }

        public Befektető(string név, Részvény részvény, int darab)
        {
            Név = név;
            _darab = darab;
            részvény.ÁrfolyamVáltozás += Megfigyel;
        }

        public void Megfigyel(double árfolyam)
        {
            Console.WriteLine($"{Név}:\t{_darab * árfolyam} Ft");
        }
    }
}
