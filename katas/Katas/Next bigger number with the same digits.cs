using System;
using System.Linq;

public class Kata
{
    public static long NextBiggerNumber(long n)
    {
        //code me

        string max = string.Join("", n.ToString().ToCharArray().OrderByDescending(x => x));

        for (long i = n + 1; i <= long.Parse(max); i++)
        {
            if (string.Join("", i.ToString().ToCharArray().OrderByDescending(x => x)).Equals(max))
            {
                return i;
            }
        }

        return -1;
    }
}
