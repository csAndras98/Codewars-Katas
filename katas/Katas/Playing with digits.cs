using System;
using System.Linq;

public class DigPow
{
    public static long digPow(int n, int p)
    {
        string num = n.ToString();
        int[] digits = new int[num.Length];

        for (int i = 0; i < num.Length; i++)
        {
            digits[i] = (int)Math.Pow(num[i] - '0', p + i);
        }
        if (digits.Sum(digit => digit) % n == 0)
        {
            return digits.Sum(digit => digit) / n;
        }
        return -1;
    }
}