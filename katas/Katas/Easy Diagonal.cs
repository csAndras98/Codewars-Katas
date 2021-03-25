using System;
using System.Numerics;

public class Diagonal
{
    public static BigInteger diagonal(int n, int p)
    {
        n++;
        BigInteger sum = 0;
        BigInteger k = 1;
        for (BigInteger i = p + 1; i <= n; i++)
        {
            sum += k;
            k = k * i / (i - p);
        }
        return sum;
    }
}
