using System.Collections.Generic;
using System.Linq;
using System;

public class SnailSolution
{
    public static int[] Snail(int[][] array)
    {
        if (array[0].Length == 0) return new int[0];

        var snail = new List<int>();
        var length = array.GetLength(0);
        var lastIndex = length - 1;
        var firstIndex = 0;
        var skipColumn = false;
        var skipRow = false;

        var j = 0;
        for (var i = 0; i <= lastIndex; i++)
        {
            if (!skipColumn)
            {
                for (; j <= lastIndex; j++)
                {
                    snail.Add(array[i][j]);
                    if (i == lastIndex && !skipRow)
                    {
                        i--;
                        skipColumn = true;
                        break;
                    }

                    if (i == lastIndex)
                    {
                        if (array.Length * array.Length == snail.Count) break;
                        j--;
                        snail.Add(array[i][j]);
                        i--;
                        break;
                    }

                    if (j != lastIndex) continue;

                    skipColumn = true;
                    j--;
                    i++;
                }
            }
            else
            {
                if (array.Length == snail.Count) break;
                if (j == firstIndex)
                {
                    if (i == firstIndex + 1)
                    {
                        firstIndex++;
                        j++;
                    }
                    else i--;
                }
                else j--;

                if (i == firstIndex)
                {
                    skipColumn = false;
                    lastIndex--;
                    skipRow = true;
                }
                else snail.Add(array[i][j]);

                i--;
            }
        }

        return snail.ToArray();
    }
}