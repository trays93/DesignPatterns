using System;
using System.Collections.Generic;

namespace ConstructorInjection
{
    public class Ügyfél
    {
        private IRendez _rendező;
        private List<double> _adatok;

        public Ügyfél(IRendez rendező)
        {
            _rendező = rendező;
            Feltölt(10);
        }

        private void Feltölt(int darab)
        {
            _adatok = new List<double>(darab);
            Random r = new Random();

            for (int i = 0; i < darab; i++)
            {
                _adatok.Add(r.NextDouble());
            }
        }

        public void Kiír(List<double> számok)
        {
            foreach (var szám in számok)
            {
                Console.Write($"{szám,5:F3}, ");
            }

            Console.WriteLine();
        }

        public void Munka()
        {
            Console.WriteLine("Az eredeti számsor:");
            Kiír(_adatok);

            var növekvő = _rendező.Rendez(_adatok, true);
            Console.WriteLine("Növekvő sorba rendezve:");
            Kiír(növekvő);

            var csökkenő = _rendező.Rendez(_adatok, false);
            Console.WriteLine("Csökkenő sorba rendezve:");
            Kiír(csökkenő);
        }
    }
}
