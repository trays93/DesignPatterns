namespace Decorator
{
    public class CakeBase : BakeryComponent
    {
        private string _name = "Cake Base";
        private double _price = 200.0;

        public override string GetName() => _name;

        public override double GetPrice() => _price;
    }
}
