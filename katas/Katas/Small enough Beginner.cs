using System;
using System.Collections.Generic;
using System.Text;

namespace katas.Katas
{
    public static bool SmallEnough(int[] a, int limit)
    {
        Array.Sort(a);
        Array.Reverse(a);
        return a[0] <= limit;
    }
}
