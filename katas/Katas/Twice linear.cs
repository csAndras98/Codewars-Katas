using System;
using System.Collections.Generic;

public class DoubleLinear
{
    public static int DblLinear(int n)
    {

        var u = new List<int>() { 1 };

        int first = 0;
        int second = 0;

        while (u.Count <= n)
        {
            int y = 2 * u[first] + 1;
            int z = 3 * u[second] + 1;

            if (y < z)
            {
                u.Add(y);
                first++;
            }
            else if (y > z)
            {
                u.Add(z);
                second++;
            }
            else
            {
                u.Add(y);
                first++;
                second++;
            }
        }

        return u[n];
    }
}