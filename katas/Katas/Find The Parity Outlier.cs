using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    public static int Find(int[] integers)
    {
        if (integers.Count(c => c % 2 == 0) == 1)
        {
            return integers.Where(c => c % 2 == 0).FirstOrDefault();
        }
        else
        {
            return integers.Where(c => c % 2 != 0).FirstOrDefault();
        }
    }
}