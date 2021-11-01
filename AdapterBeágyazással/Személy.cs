namespace AdapterBeágyazással
{
    public class Személy
    {
        public string Vezetéknév { get; set; }
        public string Utónév { get; set; }

        public Személy(string vezetéknév, string utónév)
        {
            Vezetéknév = vezetéknév;
            Utónév = utónév;
        }
    }
}
