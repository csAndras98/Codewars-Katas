using System;
using System.Linq;
class AreTheySame
{
    public static bool comp(int[] a, int[] b)
    {
        // your code
        if (a == null || b == null)
        {
            return false;
        }
        var squares = a.Select(x => x * x).ToArray();
        Array.Sort(squares);
        Array.Sort(b);
        return Enumerable.SequenceEqual(squares, b);
    }
}