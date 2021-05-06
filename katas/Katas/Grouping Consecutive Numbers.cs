using System;
using System.Collections.Generic;

public class Kata
{
    public static string GenerateGroupings(int[] input)
    {
        // put code here :)
        Array.Sort(input);
        Console.WriteLine(string.Join(" ", input));
        List<string> result = new List<string>();

        int start = input[0], end = input[0];

        for (int i = 1; i < input.Length; i++)
        {
            if (Math.Abs(end - input[i]) > 1)
            {
                AddToResult(result, start, end);
                start = input[i];
            }
            end = input[i];
        }
        AddToResult(result, start, end);
        return string.Join(", ", result);
    }

    private static void AddToResult(List<string> result, int start, int end)
    {
        if (start == end)
        {
            result.Add(start.ToString());
        }
        else
        {
            result.Add($"{start}-{end}");
        }
    }
}
