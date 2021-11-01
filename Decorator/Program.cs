using System;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            CakeBase cakeBase = new CakeBase();
            PrintProductDetails(cakeBase);

            CreamDecorator creamCake = new CreamDecorator(cakeBase);
            PrintProductDetails(creamCake);

            CherryDecorator cherryCake = new CherryDecorator(creamCake);
            PrintProductDetails(cherryCake);

            ArtificalScentDecorator scentedCake = new ArtificalScentDecorator(cherryCake);
            PrintProductDetails(scentedCake);

            NameCardDecorator namedCake = new NameCardDecorator(scentedCake);
            PrintProductDetails(namedCake);

            PastryBase pastryBase = new PastryBase();
            PrintProductDetails(pastryBase);

            creamCake = new CreamDecorator(pastryBase);
            cherryCake = new CherryDecorator(creamCake);
            PrintProductDetails(cherryCake);
        }

        private static void PrintProductDetails(BakeryComponent bakeryComponent)
        {
            Console.WriteLine($"Item: {bakeryComponent.GetName()}, Price: {bakeryComponent.GetPrice()}\n");
        }
    }
}
