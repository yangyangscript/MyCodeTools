using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeTools
{
    public partial class TStringIn
    {
        private List<string> _inList;
        public TStringIn(string str)
        {
            _inList = CommonHelp.SplitList(str);
        }
    }
}
