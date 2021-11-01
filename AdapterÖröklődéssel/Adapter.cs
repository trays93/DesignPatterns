namespace AdapterÖröklődéssel
{
    public class Adapter : Személy, INév
    {
        public Adapter(string vezetéknév, string utónév)
            : base(vezetéknév, utónév) { }

        public string TeljesNév
        {
            get => $"{Vezetéknév} {Utónév}";
        }
    }
}
