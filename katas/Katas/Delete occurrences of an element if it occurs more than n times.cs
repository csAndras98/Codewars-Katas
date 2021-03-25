using System;
using System.Collections.Generic;
using System.Linq;

public class DeleteOccurrences
{
    public static int[] DeleteNth(int[] arr, int x)
    {

        List<int> nums = new List<int>();

        foreach (int num in arr)
        {
            if (nums.Where(n => n == num).Count() < x)
            {
                nums.Add(num);
            }
        }
        return nums.ToArray();
    }
}