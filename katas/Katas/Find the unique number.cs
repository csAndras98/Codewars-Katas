using System;
using System.Collections.Generic;
using System.Linq;

public class FindUnique
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        //your code
        int[] nums = numbers.ToArray();
        Array.Sort(nums);

        if (nums[0] == nums[1])
        {
            return nums[nums.Length - 1];
        }
        else return nums[0];
    }
}