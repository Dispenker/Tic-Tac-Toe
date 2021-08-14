using System.Collections.Generic;
using System.Linq;

namespace T_T_T.Q_Learning
{
    public class QActions
    {
        public List<double> Actions { get; set; }

        public QActions(int countActions)
        {
            Actions = Enumerable.Repeat(0d, countActions).ToList();
        }
    }
}
