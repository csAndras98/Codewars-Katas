using System;
using System.Text;

public static class Kata
{
    public static string ExpandedForm(long num)
    {
        var sb = new StringBuilder();

        sb.Append(num.ToString()[0]);
        sb.Append('0', num.ToString().Length - 1);

        for (int i = 1; i < num.ToString().Length; i++)
        {
            if (!num.ToString()[i].Equals('0'))
            {
                sb.Append(" + " + num.ToString()[i]);
                sb.Append('0', num.ToString().Length - 1 - i);
            }
        }

        return sb.ToString();
    }
}