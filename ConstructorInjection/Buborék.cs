using System.Collections.Generic;

namespace ConstructorInjection
{
    public class Buborék : IRendez
    {
        public List<double> Rendez(List<double> eredeti, bool növekvő)
        {
            var új = new List<double>(eredeti);

            for (int i = 0; i < új.Count; i++)
            {
                for (int j = 1; j < új.Count; j++)
                {
                    if ((növekvő && (új[j - 1] > új[j])) || (!növekvő && (új[j] > új[j - 1])))
                    {
                        var m = új[j - 1];
                        új[j - 1] = új[j];
                        új[j] = m;
                    }
                }
            }

            return új;
        }
    }
}
