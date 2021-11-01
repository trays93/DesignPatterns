namespace AdapterKiegészítéssel
{
    public partial class Személy : INév
    {
        public string TeljesNév
        {
            get => $"{Vezetéknév} {Utónév}";
        }
    }
}
