using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeTools
{
    public partial class TDateSet
    {
        private List<string> _propertyList;

        public TDateSet(string str)
        {
            _propertyList = CommonHelp.SplitList(str);
        }

        private void firstLower(string str)
        {
            str = str.First().ToString().ToLower() + str.Substring(1);
        }
    }
}
