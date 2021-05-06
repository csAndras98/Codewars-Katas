using System;
using System.Collections.Generic;
using System.Text;

namespace katas.Katas
{
    using System;
    using System.Linq;

    public class CodeDecode
    {
        public static string Code(string strng)
        {
            string enc = "";
            string[] bits = strng.Select(x => Convert.ToString(int.Parse(x.ToString()), 2)).ToArray();

            for (int i = 0; i < bits.Length; i++)
            {

                if (bits[i].Length > 0) { enc += string.Join("", new int[bits[i].Length - 1]); }

                enc += "1" + bits[i];
            }
            return enc;
        }
        public static string Decode(string s)
        {
            var i = s.IndexOf('1') + 1;
            return (i > 0) ? Convert.ToInt32(s.Substring(i, i), 2) + Decode(s.Substring(i + i)) : "";
        }
    }
}
