namespace Observer
{
    public class Részvény
    {
        private double _árfolyam;

        public event ÁrfolyamFigyelő ÁrfolyamVáltozás;

        public double Árfolyam
        {
            get => _árfolyam;
            set
            {
                _árfolyam = value;
                ÁrfolyamVáltozás(_árfolyam);
            }
        }
    }
}
