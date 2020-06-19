using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeTools
{
    public static class CommonHelp
    {
        public static List<string> SplitList(string str)
        {
            if(string.IsNullOrWhiteSpace(str)) return new List<string>();
            List<string> spitlist;
            if (str.Contains(',') || str.Contains('，'))
            {
                spitlist = str.Split(new char[] { ',', '，' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();
            }
            else
            {
                spitlist = str.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();
            }
            return spitlist;
        }

        
    }
}
