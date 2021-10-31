using System.Linq;

namespace SimpleFactory
{
    public class ClassicStyle : Name
    {
        public ClassicStyle(string fullName)
        {
            string[] sa = fullName.Split(' ');
            LastName = sa[sa.Count() - 1].Trim();
            FirstName = "";
            for (int i = 0; i < sa.Count() - 1; i++)
            {
                FirstName += sa[i] + " ";
            }
            FirstName = FirstName.Trim();
        }
    }
}
