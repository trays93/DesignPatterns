using System;

namespace ConstructorInjection
{
    class Program
    {
        /// <summary>
        /// Kétfajta objektumtípus:
        /// - szolgáltatást nyújtó objektum
        /// - ügyfél, ami igénybe veszi a szolgáltatást nyújtó objektumot
        /// 
        /// Az objektumok között laza csatolást alakítunk ki interfész segítségével,
        /// amiben deklaráljuk a szolgáltatás metódusait, így a megvalósítást
        /// könnyen lecserélhetővé tesszük.
        /// 
        /// Konstruktoron keresztüli függőség befecskendezés
        /// </summary>
        static void Main()
        {
            Ügyfél ügyfél = new Ügyfél(new Buborék());
            ügyfél.Munka();
            Console.ReadKey();
        }
    }
}
