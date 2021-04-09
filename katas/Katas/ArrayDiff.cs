using System;
using System.Collections.Generic;

public class Kata
{
    public prop
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        // Your brilliant solution goes here
        // It's possible to pass random tests in about a second ;)

        List<int> result = new List<int>();

        foreach (int num in a)
        {
            if (Array.IndexOf(b, num) == -1)
            {
                result.Add(num);
            }
        }
        return result.ToArray();
    }
}