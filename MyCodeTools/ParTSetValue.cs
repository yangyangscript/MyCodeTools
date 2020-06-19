using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeTools
{
    public partial class TSetValue
    {
        private List<string> _propertyList;
        public TSetValue(string str)
        {
            _propertyList = CommonHelp.SplitList(str);
        }
    }
}
