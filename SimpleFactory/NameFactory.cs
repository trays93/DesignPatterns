namespace SimpleFactory
{
    /// <summary>
    /// Egyszerű gyár
    /// 
    /// Rendelkezik egy gyártó metódussal, ami a paraméterként
    /// átadott érték függvényében különböző típusú objektumokat
    /// hoz létre.
    /// </summary>
    public class NameFactory
    {
        public Name Name { get; set; }

        public NameFactory(string fullName)
        {
            if (fullName.IndexOf(",") > -1)
            {
                Name = new CommaStyle(fullName);
            }
            else
            {
                Name = new ClassicStyle(fullName);
            }
        }
    }
}
