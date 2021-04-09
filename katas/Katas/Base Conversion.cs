using System;
using System.Text;

public class Kata
{
    public static string Convert(string input, string source, string target)
    {
        ulong n = 0;
        foreach (var c in input)
            n = n * (uint)source.Length + (uint)source.IndexOf(c.ToString(), 0, source.Length);

        var sb = new StringBuilder();
        do sb.Insert(0, target[(int)(n % (uint)target.Length)]);
        while ((n /= (uint)target.Length) > 0);

        return sb.ToString();
    }
}