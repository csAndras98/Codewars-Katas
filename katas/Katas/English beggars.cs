using System;
public class Kata
{
    public static int[] Beggars(int[] values, int n)
    {
        int[] beggars = new int[n];

        int i = 0;
        int j = 0;

        if (n < 1)
        {
            return beggars;
        }
        while (i < values.Length)
        {
            if (j == beggars.Length)
            {
                j = 0;
            }
            beggars[j] += values[i];
            i++;
            j++;
        }
        return beggars;
    }
}