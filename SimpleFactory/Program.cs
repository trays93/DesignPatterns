using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(new NameFactory("Lovas Bálint").Name);
            Console.WriteLine(new NameFactory("Bálint, Lovas").Name);
            Console.ReadKey();
        }
    }
}
