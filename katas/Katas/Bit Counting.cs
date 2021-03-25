using System;
using System.Linq;

public class Kata
{
    public static int CountBits(int n)
    {
        string binary = Convert.ToString(n, 2);
        return binary.Count(i => i == '1');
    }
}