using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static int MaxSequence(int[] arr)
    {
        //TODO : create code

        if (arr.Length == 0)
        {
            return 0;
        }

        List<int> sums = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int num = 0;

            for (int j = i; j < arr.Length; j++)
            {
                num += arr[j];
                sums.Add(num);
            }
        }
        return (sums.Max(x => x) > 0) ? sums.Max(x => x) : 0;
