namespace Decorator
{
    public class Decorator : BakeryComponent
    {
        protected BakeryComponent _baseComponent = null;
        protected string _name = "Undefined Decorator";
        protected double _price = 0.0;

        protected Decorator(BakeryComponent baseComponent)
        {
            _baseComponent = baseComponent;
        }

        public override string GetName()
            => $"{_baseComponent.GetName()}, {_name}";

        public override double GetPrice()
            => _price + _baseComponent.GetPrice();
    }
}
