namespace Decorator
{
    public class CherryDecorator : Decorator
    {
        public CherryDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            _name = "Cherry";
            _price = 2.0;
        }
    }
}
