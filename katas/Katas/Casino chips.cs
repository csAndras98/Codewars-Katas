using System;

public class Solution
{
    public static int solve(int[] arr)
    {
        int counter = 0;

        Array.Sort(arr);

        while (arr[1] != 0)
        {
            counter++;
            arr[2] = arr[2] - 1;
            arr[1] = arr[1] - 1;
            Array.Sort(arr);
        }

        return counter;
    }
}