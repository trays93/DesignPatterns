namespace Decorator
{
    public class ArtificalScentDecorator : Decorator
    {
        public ArtificalScentDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            _name = "Artificial Scent";
            _price = 3.0;
        }
    }
}
