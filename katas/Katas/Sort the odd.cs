using System.Collections.Generic;

public class Kata
{
    public static int[] SortArray(int[] array)
    {
        List<int> oddNums = new List<int>();

        foreach (int num in array)
        {
            if (num % 2 != 0)
            {
                oddNums.Add(num);
            }
        }

        oddNums.Sort();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                array[i] = oddNums[0];
                oddNums.Remove(oddNums[0]);
            }
        }
        return array;
    }
}