using System;
using System.Collections.Generic;

public static class Kata
{
    public static List<int> PascalsTriangle(int n)
    {

        List<int> result = new List<int>();

        int[][] triangle = new int[n][];

        for (int i = 0; i < n; i++)
        {
            triangle[i] = new int[i + 1];
        }

        triangle[0][0] = 1;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                triangle[i + 1][j] += triangle[i][j];
                triangle[i + 1][j + 1] += triangle[i][j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                result.Add(triangle[i][j]);
            }
        }

        return result;
    }
}