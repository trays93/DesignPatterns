namespace Decorator
{
    public class CreamDecorator : Decorator
    {
        public CreamDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            _name = "Cream";
            _price = 1.0;
        }
    }
}
