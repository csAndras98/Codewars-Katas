using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static (int, int)[] TwosDifference(int[] array)
    {
        List<(int, int)> result = new List<(int, int)>();
        array = array.OrderBy(x => x).ToArray();
        for (var j = 0; j < array.Length; j++)
        {
            if (array.Contains(array[j] + 2))
            {
                result.Add((array[j], array[j] + 2));
            }
        }
        return result.ToArray();
    }
}
