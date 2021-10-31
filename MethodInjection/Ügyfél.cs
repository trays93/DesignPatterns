using System;
using System.Collections.Generic;

namespace MethodInjection
{
    public class Ügyfél
    {
        private IRendez _rendező;
        private List<double> _adatok;

        public Ügyfél()
        {
            Feltölt(10);
        }

        public void RendezésMetódus(IRendez rendező)
        {
            _rendező = rendező;
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
