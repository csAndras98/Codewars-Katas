using System;

public class Solution
{
    public static string solve(string[] arr)
    {

        int[] times = new int[arr.Length];

        int result = 0;

        if (times.Length == 1)
        {
            return "23:59";
        }
        for (int i = 0; i < arr.Length; i++)
        {
            times[i] = int.Parse(arr[i].Split(":")[0]) * 60 + int.Parse(arr[i].Split(":")[1]);
        }
        Array.Sort(times);

        for (int i = 1; i < times.Length; i++)
        {
            if (times[i] - times[i - 1] > result)
            {
                result = times[i] - times[i - 1];
            }
        }
        if (times[0] + 1440 - times[times.Length - 1] > result)
        {
            result = times[0] + 1440 - times[times.Length - 1];
        }
        return (result / 60).ToString().PadLeft(2, '0') + ":" + (result % 60 - 1).ToString().PadLeft(2, '0');

    }
}