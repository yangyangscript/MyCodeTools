using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeTools
{
    public partial class TClass
    {
        private class TClassParms
        {
            public string Name { get; set; }
            public string Summary { get; set; }
        }

        private List<TClassParms> _items ;

        public TClass(string str)
        {
            _items = new List<TClassParms>();
            var spitlist = CommonHelp.SplitList(str);
            if(!spitlist.Any()) return;
            //if (string.IsNullOrWhiteSpace(str)) return;
            //List<string> spitlist;
            //if (str.Contains(',') || str.Contains('，'))
            //{
            //    spitlist = str.Split(new char[] { ',', '，' }, StringSplitOptions.RemoveEmptyEntries).Select(s=>s.Trim()).ToList();
            //}
            //else
            //{
            //    spitlist = str.Split(new string[] {"\r\n"},StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();
            //}
            foreach (var spitStr in spitlist)
            {
                TClassParms tParm;
                if (!spitStr.Contains('@'))
                {
                    tParm = new TClassParms()
                    {
                        Name = spitStr,
                        Summary = "",
                    };
                }
                else
                {
                    var spitStrList = spitStr.Split('@');
                    tParm = new TClassParms()
                    {
                        Name = spitStrList[0],
                        Summary = spitStrList[1],
                    };
                }
                _items.Add(tParm);
            }

        }
    }
}
