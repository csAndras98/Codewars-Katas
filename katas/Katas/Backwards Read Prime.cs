using System;
using System.Collections.Generic;

public class BackWardsPrime
{

    public static string backwardsPrime(long start, long end)
    {
        // your code
        List<long> valid = new List<long>();

        for (long i = start; i <= end; i++)
        {
            long number = i;
            long reverse = 0;
            while (number > 0)
            {
                long remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            if (isPrime(reverse) && isPrime(i) && i != reverse)
            {
                valid.Add(i);
            }
        }
        return String.Join(" ", valid.ToArray());
    }

    public static bool isPrime(long number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }
}