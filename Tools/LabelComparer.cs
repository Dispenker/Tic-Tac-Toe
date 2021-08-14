using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace T_T_T.Tools
{
    public class LabelComparer : IComparer<Label>
    {
        public int Compare(Label l1, Label l2)
        {
            if (l1.Name.Last() > l2.Name.Last())
                return 1;
            else if (l1.Name.Last() < l2.Name.Last())
                return -1;
            else
                return 0;
        }
    }
}
