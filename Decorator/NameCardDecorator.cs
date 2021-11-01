namespace Decorator
{
    public class NameCardDecorator : Decorator
    {
        private double _discountRate = 5.0;

        public NameCardDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            _name = "Name Card";
            _price = 4.0;
        }

        public override string GetName()
            => $"{_baseComponent.GetName()}, {_name} (Please Collect your discount card for {_discountRate}%)";
    }
}
