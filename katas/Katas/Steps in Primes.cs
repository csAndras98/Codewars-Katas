using System;

class StepInPrimes
{
    public static long[] Step(int g, long m, long n)
    {
        for (long i = m; i <= n; i++)
        {
            if (IsPrime(i) && IsPrime(i + g) && i + g <= n)
            {
                return new long[] { i, i + g };
            }
        }
        return null;
    }

    private static Boolean IsPrime(long n)
    {
        if (n == 1) return false;
        if (n == 2) return true;

        var limit = Math.Ceiling(Math.Sqrt(n));

        for (int i = 2; i <= limit; ++i)
            if (n % i == 0)
                return false;
        return true;
    }

}