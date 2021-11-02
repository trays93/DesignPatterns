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
            _egyediPéldány = _egyediPéldány ?? new Egyke();
            return _egyediPéldány;
        }

        public static Egyke PéldányTulajdonság
        {
            get
            {
                if (_egyediPéldány == null)
                    _egyediPéldány = new Egyke();
                return _egyediPéldány;
            }
        }

        public void Művelet()
        {
            Console.WriteLine("Helló az egykéből!");
        }
    }
}
