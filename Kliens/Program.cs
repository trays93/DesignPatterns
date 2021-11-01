using System;

namespace Kliens
{
    class Program
    {
        static void Main()
        {
            IActualPrices proxy = new ActualPricesProxy();

            Console.WriteLine("Gold Price:");
            Console.WriteLine(proxy.GoldPrice);

            Console.WriteLine("Silver Price:");
            Console.WriteLine(proxy.SilverPrice);

            Console.WriteLine("Dollar to Forint Price:");
            Console.WriteLine(proxy.DollarToForint);

            Console.ReadKey();
        }
    }
}
