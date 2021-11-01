namespace AdapterBővítőMetódussal
{
    public static class Bővítő
    {
        public static string TeljesNév(this Személy személy)
            => $"{személy.Vezetéknév} {személy.Utónév}";
    }
}
