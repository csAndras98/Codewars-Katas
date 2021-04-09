using System;
using System.Linq;
using System.Collections.Generic;
public class JomoPipi
{
    public static string Numericals(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        return string.Join("", s.Select(x =>
        {
            int i = 1;
            if (dic.ContainsKey(x))
                i = ++dic[x];
            else
                dic[x] = 1;
            return i;
        }));
    }
}