using System;
using System.Collections.Generic;

public class SplitString
{
    public static string[] Solution(string str)
    {
        List<string> solution = new List<string>();

        if (str.Length % 2 != 0)
        {
            str = str + "_";
        }

        for (int i = 0; i < str.Length; i += 2)
        {
            solution.Add(str.Substring(i, 2));
        }
        return solution.ToArray();
    }
}