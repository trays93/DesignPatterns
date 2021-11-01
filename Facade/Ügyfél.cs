namespace Facade
{
    public class Ügyfél
    {
        private string _név;

        public string Név
        {
            get => _név;
        }

        public Ügyfél(string név)
        {
            _név = név;
        }
    }
}
