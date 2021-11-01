namespace AdapterBeágyazással
{
    public class Adapter : INév
    {
        private Személy _személy;

        public Adapter(string vezetéknév, string utónév)
        {
            _személy = new Személy(vezetéknév, utónév);
        }

        public string Vezetéknév
        {
            get => _személy.Vezetéknév;
            set
            {
                _személy.Vezetéknév = value;
            }
        }

        public string Utónév
        {
            get => _személy.Utónév;
            set
            {
                _személy.Utónév = value;
            }
        }

        public string TeljesNév
        {
            get => $"{_személy.Vezetéknév} {_személy.Utónév}";
        }
    }
}
