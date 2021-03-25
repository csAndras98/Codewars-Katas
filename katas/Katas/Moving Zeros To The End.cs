using System.Collections.Generic;

public class MoveZeroesToEnd
{
    public static int[] MoveZeroes(int[] arr)
    {
        // TODO: Program me
        List<int> solution = new List<int>();
        int zeroes = 0;
        foreach (int num in arr)
        {
            if (num == 0)
            {
                zeroes++;
            }
            else
            {
                solution.Add(num);
            }
        }
        for (int i = 0; i < zeroes; i++)
        {
            solution.Add(0);
        }
        return solution.ToArray();
    }
}