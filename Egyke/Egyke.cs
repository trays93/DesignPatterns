using System;

namespace Egyke
{
    /// <summary>
    /// Egy adott osztályból csak egy példány lehessen a memóriában
    /// és ez az osztály felelős a példány nyílvántartásáért.
    /// </summary>
    public class Egyke
    {
        private static Egyke _egyediPéldány;

        protected Egyke() { }

        public static Egyke Példány()
        {
            return _egyediPéldány ?? new Egyke();
        }

        public void Művelet()
        {
            Console.WriteLine("Helló az egykéből!");
        }
    }
}
