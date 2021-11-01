namespace Decorator
{
    public class PastryBase : BakeryComponent
    {
        private string _name = "Pastry Base";
        private double _price = 20.0;

        public override string GetName() => _name;

        public override double GetPrice() => _price;
    }
}
