using System;
using System.Numerics;
class QuickCalc
{
    public static BigInteger Choose(int n, int k)
    {
        // your code
        return Factorial(n) / (Factorial(k) * (Factorial(n - k)));
    }

    private static BigInteger Factorial(int n)
    {
        BigInteger result = n;

        if (n <= 1)
        {
            return 1;
        }

        for (int i = n - 1; i >= 1; i--)
        {
            result = result * i;
        }
        return result;
    }
}