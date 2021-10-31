namespace SimpleFactory
{
    public class CommaStyle : Name
    {
        public CommaStyle(string fullName)
        {
            string[] sa = fullName.Split(',');
            FirstName = sa[1].Trim();
            LastName = sa[0].Trim();
        }
    }
}
